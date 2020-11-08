using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLApplication
{
    public class DOM:IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public List<Auto> AnalyzeFile(Auto mySearch, string path)
        {
            doc.Load(path);
            List<List<Auto>> info = new List<List<Auto>>();
            if(mySearch.country == null && 
                mySearch.cost == null &&
                mySearch.marka == null &&
                mySearch.model == null &&
                mySearch.year == null &&
                mySearch.color == null)
            {
                return ErrorCatch(doc);
            }

            if (mySearch.country != null) info.Add(SearchByAttribute("auto", "Country", mySearch.country, doc));
            if (mySearch.cost != null) info.Add(SearchByAttribute("auto", "Cost", mySearch.cost, doc));
            if (mySearch.marka != null) info.Add(SearchByAttribute("auto", "Marka", mySearch.marka, doc));
            if (mySearch.model != null) info.Add(SearchByAttribute("auto", "Model", mySearch.model, doc));
            if (mySearch.year != null) info.Add(SearchByAttribute("auto", "Year", mySearch.year, doc));
            if (mySearch.color != null) info.Add(SearchByAttribute("auto", "Color", mySearch.color, doc));

            return Cross(info, mySearch);

        }

        public List<Auto> SearchByAttribute(string nodeName, string attribute, string myTemplate, XmlDocument doc)
        {
            List<Auto> find = new List<Auto>();

            if (myTemplate != null)
            {
                XmlNodeList lst = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + myTemplate + "\"]");
                foreach(XmlNode e in lst)
                {
                    find.Add(Info(e));
                }
            }
            return find;
        }

        public List<Auto> ErrorCatch(XmlDocument doc)
        {
            List<Auto> result = new List<Auto>();
            XmlNodeList lst = doc.SelectNodes("//" + "auto");
            foreach(XmlNode elem in lst)
            {
                result.Add(Info(elem));
            }
            return result;
        }

        public Auto Info(XmlNode node)
        {
            Auto search = new Auto();
            search.country = node.Attributes.GetNamedItem("Country").Value;
            search.cost = node.Attributes.GetNamedItem("Cost").Value;
            search.marka = node.Attributes.GetNamedItem("Marka").Value;
            search.model = node.Attributes.GetNamedItem("Model").Value;
            search.year = node.Attributes.GetNamedItem("Year").Value;
            search.color = node.Attributes.GetNamedItem("Color").Value;

            return search;
        }

        public List<Auto> Cross(List<List<Auto>> list, Auto myTemplate)
        {
            List<Auto> result = new List<Auto>();
            List<Auto> clear = CheckNodes(list, myTemplate);
            foreach(Auto elem in clear)
            {
                bool isln = false;
                foreach(Auto s in result)
                {
                    if (s.Compare(elem))
                    {
                        isln = true;
                    }
                }
                if (!isln)
                {
                    result.Add(elem);
                }
            }
            return result;
        }

        public  List<Auto> CheckNodes(List<List<Auto>> list, Auto myTemplate)
        {
            List<Auto> newResult = new List<Auto>();
            foreach(List<Auto> elem in list)
            {
                foreach(Auto s in elem)
                {
                    if((myTemplate.country == s.country || myTemplate.country == null) &&
                        (myTemplate.cost == s.cost || myTemplate.cost == null) &&
                        (myTemplate.marka == s.marka || myTemplate.marka == null) &&
                        (myTemplate.model == s.model || myTemplate.model == null) &&
                        (myTemplate.year == s.year || myTemplate.year == null) &&
                        (myTemplate.color == s.color || myTemplate.color == null))
                    {
                        newResult.Add(s);
                    }
                }
            }
            return newResult;
        }
    }
}
