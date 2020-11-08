using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLApplication
{
    public interface IStrategy
    {
        List<Auto> AnalyzeFile(Auto mySearch, string path);
    }
}
