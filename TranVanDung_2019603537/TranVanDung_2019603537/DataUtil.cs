using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TranVanDung_2019603537
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string filename;
        public DataUtil()
        {
            filename = "danhsachsach.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement ds = doc.CreateElement("danhsachsach");
                doc.AppendChild(ds);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void addSach(Sach sach)
        {
            XmlElement s = doc.CreateElement("sach");
            s.SetAttribute("mas", sach.ms);
            s.SetAttribute("nhaxb", sach.nxb);
            XmlElement nxb = doc.CreateElement("nxb");
            nxb.InnerText = sach.nxb;
            XmlElement ms = doc.CreateElement("ms");
            ms.InnerText = sach.ms;
            XmlElement ts = doc.CreateElement("ts");
            ts.InnerText = sach.ts;
            XmlElement gb = doc.CreateElement("gb");
            gb.InnerText = sach.gb;
            XmlElement tg = doc.CreateElement("tg");
            tg.InnerText = sach.tg;
            s.AppendChild(nxb);
            s.AppendChild(ms);
            s.AppendChild(ts);
            s.AppendChild(gb);
            s.AppendChild(tg);
            root.AppendChild(s);
            doc.Save(filename);
        }

        public List<Sach> getSachs()
        {
            XmlNodeList nodes = root.SelectNodes("sach");
            List<Sach> li = new List<Sach>();
            foreach (XmlNode item in nodes)
            {
                Sach s = new Sach();
                s.nxb = item.SelectSingleNode("nxb").InnerText;
                s.ms = item.SelectSingleNode("ms").InnerText;
                s.ts = item.SelectSingleNode("ts").InnerText;
                s.gb = item.SelectSingleNode("gb").InnerText;
                s.tg = item.SelectSingleNode("tg").InnerText;
                li.Add(s);

            }
            return li;
        }

        public bool deleteSach(string ms)
        {
            XmlNode sfind = root.SelectSingleNode("sach[ms='" + ms + "']");
            if (sfind != null)
            {
                root.RemoveChild(sfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }
        public bool updateSach(Sach sach)
        {
            XmlNode sfind = root.SelectSingleNode("sach[ms='" + sach.ms + "']");
            if (sfind != null)
            {
                XmlElement s = doc.CreateElement("sach");
                XmlElement nxb = doc.CreateElement("nxb");
                nxb.InnerText = sach.nxb;
                XmlElement ms = doc.CreateElement("ms");
                ms.InnerText = sach.ms;
                XmlElement ts = doc.CreateElement("ts");
                ts.InnerText = sach.ts;
                XmlElement gb = doc.CreateElement("gb");
                gb.InnerText = sach.gb;
                XmlElement tg = doc.CreateElement("tg");
                tg.InnerText = sach.tg;
                s.AppendChild(nxb);
                s.AppendChild(ms);
                s.AppendChild(ts);
                s.AppendChild(gb);
                s.AppendChild(tg);
                root.ReplaceChild(s, sfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }
    }
}
