using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai07
{
    internal class Lophoc
    {
        public void ReadFile(XmlNode node)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Lophoc.xml");
            //XmlElement root = doc.DocumentElement;
            XmlNodeList list = node.SelectNodes("sinhvien");
            int i = 0;
            foreach (XmlNode item in list)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Sinh vien thu :" + i);
                Console.WriteLine("Ma sinh vien : " + item.Attributes[0].InnerText);
                Console.WriteLine("Ho ten : " + item.SelectSingleNode("hoten").InnerText);
                Console.WriteLine("Tuoi : " + item.SelectSingleNode("tuoi").InnerText);
                Console.WriteLine("Dia chi : " + item.SelectSingleNode("diachi").InnerText);
                i++;
            }
        }
        public void printNode(XmlNode node)
        {
            Console.WriteLine("Type : " + node.NodeType);
            Console.WriteLine("Name : " + node.Name);
            Console.WriteLine("Value : "+ node.Value);
            XmlNodeList children = node.ChildNodes;
            if(children.Count > 0)
            {
                foreach(XmlNode i in children)
                {
                    printNode(i);
                }
            }
        }
    }
}
