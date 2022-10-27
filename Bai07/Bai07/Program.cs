using System.Xml;

namespace Bai07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            XmlDocument doc = new XmlDocument();
            doc.Load("Lophoc.xml");
            XmlElement root = doc.DocumentElement;

            Lophoc lh = new Lophoc();
            lh.ReadFile(root);
            lh.printNode(root);
            */

            XmlDocument doc = new XmlDocument();

            XmlElement root = doc.CreateElement("thuvien");

            Cuonsach s1 = new Cuonsach("j01", "Cong nghe thong tin", "Lap tring java", "100", "Tran Van A", "0866778584", "100000", "Nguyen Thi B");

            Cuonsach s2 = new Cuonsach("c01", "Cong nghe thong tin", "Lap tring C", "200", "Tran Van B", "0866778584", "50000", "Tran Van C");
            
            themSach(doc, root, s1);

            themSach(doc, root, s2);

            doc.AppendChild(root);

            doc.Save("Thuvien.xml");

        }

        public static void themSach(XmlDocument doc, XmlElement root, Cuonsach s)
        {
            XmlElement cuonsach = doc.CreateElement("cuonsach");

            cuonsach.SetAttribute("masach", s.masach);
            cuonsach.SetAttribute("theloai", s.theloai);

            XmlElement tensach = doc.CreateElement("tensach");

            tensach.InnerText = s.tensach;

            //XmlText ttensach = doc.CreateTextNode("Lap tring java");

            XmlElement sotrang = doc.CreateElement("sotrang");

            XmlText tsotrang = doc.CreateTextNode(s.sotrang);

            XmlElement tacgia = doc.CreateElement("tacgia");

            XmlText ttacgia = doc.CreateTextNode(s.tacgia);

            XmlElement hoten = doc.CreateElement("hoten");

            XmlText thoten = doc.CreateTextNode(s.hoten);

            XmlElement dienthoai = doc.CreateElement("dienthoai");

            XmlText tdienthoai = doc.CreateTextNode(s.dienthoai);

            XmlElement giatien = doc.CreateElement("giatien");

            XmlText tgiatien = doc.CreateTextNode(s.giatien);

            //tensach.AppendChild(ttensach);
            sotrang.AppendChild(tsotrang);
            tacgia.AppendChild(ttacgia);
            hoten.AppendChild(thoten);
            dienthoai.AppendChild(tdienthoai);
            giatien.AppendChild(tgiatien);

            root.AppendChild(cuonsach);
            cuonsach.AppendChild(tensach);
            cuonsach.AppendChild(sotrang);
            cuonsach.AppendChild(tacgia);
            cuonsach.AppendChild(hoten);
            cuonsach.AppendChild(dienthoai);
            cuonsach.AppendChild(giatien);
           
        }
    }
}