using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLApplication
{
    public class SAX: IStrategy
    {
        private List<Auto> lastResult = null;
        public List<Auto> AnalyzeFile(Auto mySearch, string path)
        {
            XmlReader reader = XmlReader.Create(path);
            List<Auto> result = new List<Auto>();

            Auto find = null;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "auto")
                        {
                            find = new Auto();
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "Country")
                                {
                                    find.country = reader.Value;
                                }
                                if (reader.Name == "Cost")
                                {
                                    find.cost = reader.Value;
                                }
                                if (reader.Name == "Marka")
                                {
                                    find.marka = reader.Value;
                                }
                                if (reader.Name == "Model")
                                {
                                    find.model = reader.Value;
                                }
                                if (reader.Name == "Year")
                                {
                                    find.year = reader.Value;
                                }
                                if (reader.Name == "Color")
                                {
                                    find.color = reader.Value;
                                }
                            }
                            result.Add(find);
                        }
                        break;
                }
            }
            lastResult = Filter(result, mySearch);
            return lastResult;
        }

        private List<Auto> Filter(List<Auto> allRes, Auto myTemplate)
        {
            List<Auto> newResult = new List<Auto>();
            if (allRes != null)
            {
                foreach (Auto i in allRes)
                {
                    if((myTemplate.country == i.country || myTemplate.country == null) &&
                        (myTemplate.cost == i.cost || myTemplate.cost == null) &&
                        (myTemplate.marka == i.marka || myTemplate.marka == null) &&
                        (myTemplate.model == i.model || myTemplate.model == null) &&
                        (myTemplate.year == i.year || myTemplate.year == null) &&
                        (myTemplate.color == i.color || myTemplate.color == null))
                    {
                        newResult.Add(i);
                    }
                }
            }
            return newResult;
        }
    }
}
