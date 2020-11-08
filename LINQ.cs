using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLApplication
{
    public class LINQ:IStrategy
    {
        private List<Auto> find = null;
        XDocument doc = new XDocument();

        public List<Auto> AnalyzeFile(Auto mySearch, string path)
        {
            doc = XDocument.Load(@path);
            find = new List<Auto>();
            List<XElement> matches = (from val in doc.Descendants("auto")
                                      where ((mySearch.country == null || mySearch.country == val.Attribute("Country").Value) &&
                                      (mySearch.cost == null || mySearch.cost == val.Attribute("Cost").Value) &&
                                      (mySearch.marka == null || mySearch.marka == val.Attribute("Marka").Value) &&
                                      (mySearch.model == null || mySearch.model == val.Attribute("Model").Value) &&
                                      (mySearch.year == null || mySearch.year == val.Attribute("Year").Value) &&
                                      (mySearch.color == null || mySearch.color == val.Attribute("Color").Value))
                                      select val).ToList();
            foreach(XElement match in matches)
            {
                Auto res = new Auto();
                res.country = match.Attribute("Country").Value;
                res.cost = match.Attribute("Cost").Value;
                res.marka = match.Attribute("Marka").Value;
                res.model = match.Attribute("Model").Value;
                res.year = match.Attribute("Year").Value;
                res.color = match.Attribute("Color").Value;
                find.Add(res);
            }
            return find;
        }
    }
}
