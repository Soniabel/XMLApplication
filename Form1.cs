using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace XMLApplication
{
    public partial class Form1 : Form
    {
        private string path = "XMLFile1.xml";
        private string pathXsl = "XSLFile1.xsl";
        public Form1()
        {
            InitializeComponent();
            buildBox(comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6);
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            radioButtonLINQ.Checked = true;
        }
        
        public void buildBox(ComboBox countryBox, ComboBox costBox, ComboBox markaBox, ComboBox modelBox, ComboBox yearBox, ComboBox colorBox)
        {
            IStrategy p = new LINQ();
            List<Auto> res = p.AnalyzeFile(new Auto(), path);
            List<string> country = new List<string>();
            List<string> cost = new List<string>();
            List<string> marka = new List<string>();
            List<string> model = new List<string>();
            List<string> year = new List<string>();
            List<string> color = new List<string>();
            foreach(Auto elem in res)
            {
                if (!country.Contains(elem.country))
                {
                    country.Add(elem.country);
                }
                if (!cost.Contains(elem.cost))
                {
                    cost.Add(elem.cost);
                }
                if (!marka.Contains(elem.marka))
                {
                    marka.Add(elem.marka);
                }
                if (!model.Contains(elem.model))
                {
                    model.Add(elem.model);
                }
                if (!year.Contains(elem.year))
                {
                    year.Add(elem.year);
                }
                if (!color.Contains(elem.color))
                {
                    color.Add(elem.color);
                }
            }
            country = country.OrderBy(x => x).ToList();
            cost = cost.OrderBy(x => x).ToList();
            marka = marka.OrderBy(x => x).ToList();
            model = model.OrderBy(x => x).ToList();
            year = year.OrderBy(x => x).ToList();
            color = color.OrderBy(x => x).ToList();

            countryBox.Items.AddRange(country.ToArray());
            costBox.Items.AddRange(cost.ToArray());
            markaBox.Items.AddRange(marka.ToArray());
            modelBox.Items.AddRange(model.ToArray());
            yearBox.Items.AddRange(year.ToArray());
            colorBox.Items.AddRange(color.ToArray());
        }

        private Auto OurSearch()
        {
            string[] info = new string[7];
            if (checkBox1.Checked) info[0] = Convert.ToString(comboBox1.Text);
            if (checkBox2.Checked) info[1] = Convert.ToString(comboBox2.Text);
            if (checkBox3.Checked) info[2] = Convert.ToString(comboBox3.Text);
            if (checkBox4.Checked) info[3] = Convert.ToString(comboBox4.Text);
            if (checkBox5.Checked) info[4] = Convert.ToString(comboBox5.Text);
            if (checkBox6.Checked) info[5] = Convert.ToString(comboBox6.Text);
            Auto idealSearch = new Auto(info);
            return idealSearch;
        }

        private void ParsingForXML()
        {
            Auto myTemplate = OurSearch();
            List<Auto> res;

            if (radioButtonSAX.Checked)
            {
                IStrategy parser = new SAX();
                res = parser.AnalyzeFile(myTemplate, path);
                Output(res);
            }
            else if (radioButtonDOM.Checked)
            {
                IStrategy parser = new DOM();
                res = parser.AnalyzeFile(myTemplate, path);
                Output(res);
            }
            else if (radioButtonLINQ.Checked)
            {
                IStrategy parser = new LINQ();
                res = parser.AnalyzeFile(myTemplate, path);
                Output(res);
            }

        }

        private void Output(List<Auto> res)
        {
            richTextBox1.Clear();
            foreach(Auto n in res)
            {
                richTextBox1.AppendText("Країна виробник:" + n.country + "\n");
                richTextBox1.AppendText("Ціна:" + n.cost + "\n");
                richTextBox1.AppendText("Марка автомобіля:" + n.marka + "\n");
                richTextBox1.AppendText("Модель автомобіля:" + n.model + "\n");
                richTextBox1.AppendText("Рік випуску:" + n.year + "\n");
                richTextBox1.AppendText("Колір:" + n.color + "\n");
                richTextBox1.AppendText("----------------------------\n");
            }
        }

        private void IntoHTML()
        {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(pathXsl);
            string input = path;
            string result = @"HTML.html";
            xsl.Transform(input, result);
            MessageBox.Show("Готово!");
        }

        private void Clear()
        {
            richTextBox1.Clear();
            radioButtonDOM.Checked = false;
            radioButtonLINQ.Checked = false;
            radioButtonSAX.Checked = false;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ParsingForXML();
        }

        private void buttonTransToHTML_Click(object sender, EventArgs e)
        {
            IntoHTML();
            var openHTML = System.Diagnostics.Process.Start("HTML.html");
        
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { comboBox1.Enabled = true; }else { comboBox1.Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { comboBox2.Enabled = true; } else { comboBox2.Enabled = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { comboBox3.Enabled = true; } else { comboBox3.Enabled = false; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) { comboBox4.Enabled = true; } else { comboBox4.Enabled = false; }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) { comboBox5.Enabled = true; } else { comboBox5.Enabled = false; }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) { comboBox6.Enabled = true; } else { comboBox6.Enabled = false; }
        }
    }
}
