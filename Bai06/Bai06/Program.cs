
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai06
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile a = new ReadFile();
            //a.ReadFileXML();
            Congty ct = new Congty();
            ct.ReadFile();
        }
    }
}

