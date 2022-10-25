using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Bai06
{
    internal class ReadFile
    {
        public  void ReadFileXML()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Chuong Trinh Doc File ThuVien.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load("ThuVien.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList li = root.SelectNodes("cuonsach");
            int i = 0;
            foreach(XmlNode item in li)
            {
                Console.WriteLine("-----------------\nPhan tu thu: " + i);
                Console.WriteLine("Ten sach :" + item.SelectSingleNode("tensach").InnerText);
                Console.WriteLine("So trang: " + item.SelectSingleNode("sotrang").InnerText);
                Console.WriteLine("Ho ten tac gia: " + item.SelectSingleNode("tacgia/hoten").InnerText);
                Console.WriteLine("So dien thoai ta gia: " + item.SelectSingleNode("tacgia/dienthoai").InnerText);
                Console.WriteLine("Gia tien: " + item.SelectSingleNode("giatien").InnerText);
                i++;
            }
        }
    }
}
