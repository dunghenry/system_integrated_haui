using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai06
{
    internal class Congty
    {
        public void ReadFile()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Read file Congty.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load("Congty.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList li = root.SelectNodes("nhanvien");
            int i = 0;
            foreach(XmlNode item in li)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Phan tu thu : " + i);
                Console.WriteLine("Ho ten : " + item.SelectSingleNode("hoten").InnerText);
                Console.WriteLine("Tuoi: " + item.SelectSingleNode("tuoi").InnerText);
                Console.WriteLine("Luong : " + item.SelectSingleNode("luong").InnerText);
                Console.WriteLine("Xa/Phuong: " + item.SelectSingleNode("diachi/xa").InnerText);
                Console.WriteLine("Quan/Huyen: " + item.SelectSingleNode("diachi/huyen").InnerText);
                Console.WriteLine("Tinh/Thanh pho: " + item.SelectSingleNode("diachi/tinh").InnerText);
                Console.WriteLine("Dien thoai: " + item.SelectSingleNode("dienthoai").InnerText);
            }
        }
    }
}
