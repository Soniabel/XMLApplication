namespace XMLApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonTransToHTML = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Країна виробник";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(35, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ціна";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(35, 116);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(150, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Марка автомобіля";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(35, 161);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(158, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Модель автомобіля";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(35, 204);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(104, 21);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Рік випуску";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(35, 248);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(66, 21);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Колір";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(103, 318);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(61, 21);
            this.radioButtonLINQ.TabIndex = 6;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(185, 318);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(61, 21);
            this.radioButtonDOM.TabIndex = 7;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(274, 318);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(56, 21);
            this.radioButtonSAX.TabIndex = 8;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(30, 384);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(145, 34);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonTransToHTML
            // 
            this.buttonTransToHTML.Location = new System.Drawing.Point(310, 384);
            this.buttonTransToHTML.Name = "buttonTransToHTML";
            this.buttonTransToHTML.Size = new System.Drawing.Size(145, 34);
            this.buttonTransToHTML.TabIndex = 10;
            this.buttonTransToHTML.Text = "Трансформація";
            this.buttonTransToHTML.UseVisualStyleBackColor = true;
            this.buttonTransToHTML.Click += new System.EventHandler(this.buttonTransToHTML_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(581, 384);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(145, 34);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(415, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(373, 336);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "США",
            "Німеччина",
            "Італія"});
            this.comboBox1.Location = new System.Drawing.Point(217, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "30600$",
            "26900$",
            "39300$",
            "46900$"});
            this.comboBox2.Location = new System.Drawing.Point(217, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "BMW",
            "Mercedes",
            "Porsche",
            "Maserati"});
            this.comboBox3.Location = new System.Drawing.Point(217, 113);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(178, 24);
            this.comboBox3.TabIndex = 15;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "X4",
            "Benz",
            "Macan",
            "Quattroporte"});
            this.comboBox4.Location = new System.Drawing.Point(217, 159);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(178, 24);
            this.comboBox4.TabIndex = 16;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "2016",
            "2015",
            "2014",
            "2013"});
            this.comboBox5.Location = new System.Drawing.Point(217, 201);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(178, 24);
            this.comboBox5.TabIndex = 17;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "чорний",
            "фіолетовий",
            "синій",
            "білий"});
            this.comboBox6.Location = new System.Drawing.Point(217, 245);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(178, 24);
            this.comboBox6.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTransToHTML);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.radioButtonLINQ);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.RadioButton radioButtonLINQ;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonTransToHTML;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
    }
}

