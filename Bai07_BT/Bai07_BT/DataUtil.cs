using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai07_BT
{
    internal class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string filename;
        public DataUtil()
        {
            filename = "Nganhang.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement nganhang = doc.CreateElement("nganhang");
                doc.AppendChild(nganhang);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public void addTaiKhoan(TaiKhoan taikhoan)
        {
            XmlElement tk = doc.CreateElement("taikhoan");
            XmlElement sotaikhoan = doc.CreateElement("sotaikhoan");
            sotaikhoan.InnerText = taikhoan.sotaikhoan;
            XmlElement tentaikhoan = doc.CreateElement("tentaikhoan");
            tentaikhoan.InnerText = taikhoan.tentaikhoan;
            XmlElement diachi = doc.CreateElement("diachi");
            diachi.InnerText = taikhoan.diachi;
            XmlElement dienthoai = doc.CreateElement("dienthoai");
            dienthoai.InnerText = taikhoan.dienthoai;
            XmlElement sotien = doc.CreateElement("sotien");
            sotien.InnerText = taikhoan.sotien;
            tk.AppendChild(sotaikhoan);
            tk.AppendChild(tentaikhoan);
            tk.AppendChild(diachi);
            tk.AppendChild(dienthoai);
            tk.AppendChild(sotien);
            root.AppendChild(tk);
            doc.Save(filename);

        }

        public List<TaiKhoan> getAllTaiKhoan()
        {
            XmlNodeList nodes = root.SelectNodes("taikhoan");
            List<TaiKhoan> li = new List<TaiKhoan>();
            foreach(XmlNode item in nodes)
            {
                TaiKhoan taikhoan = new TaiKhoan();
                taikhoan.sotaikhoan = item.SelectSingleNode("sotaikhoan").InnerText;
                taikhoan.tentaikhoan = item.SelectSingleNode("tentaikhoan").InnerText;
                taikhoan.diachi = item.SelectSingleNode("diachi").InnerText;
                taikhoan.dienthoai = item.SelectSingleNode("dienthoai").InnerText;
                taikhoan.sotien = item.SelectSingleNode("sotien").InnerText;
                li.Add(taikhoan);

            }
            return li;
        }

        public TaiKhoan findBySTK(string stk)
        {
            XmlNode tkfind = root.SelectSingleNode("taikhoan[sotaikhoan='" + stk + "']");
            TaiKhoan tk = null;
             if(tkfind != null){
                tk = new TaiKhoan();
                tk.sotaikhoan = tkfind.SelectSingleNode("sotaikhoan").InnerText;
                tk.tentaikhoan = tkfind.SelectSingleNode("tentaikhoan").InnerText;
                tk.diachi = tkfind.SelectSingleNode("diachi").InnerText;
                tk.dienthoai = tkfind.SelectSingleNode("dienthoai").InnerText;
                tk.sotien = tkfind.SelectSingleNode("sotien").InnerText;
             }
            return tk;
        }
        public bool deleteTaiKhoan(string stk)
        {
            XmlNode tkfind = root.SelectSingleNode("taikhoan[sotaikhoan='" + stk + "']");

            if (tkfind != null)
            {
                root.RemoveChild(tkfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }
        public bool updateTaiKhoan(TaiKhoan tk)
        {
            XmlNode tkfind = root.SelectSingleNode("taikhoan[sotaikhoan='" + tk.sotaikhoan + "']");
            if(tkfind != null)
            {
                XmlElement tkUpdate = doc.CreateElement("taikhoan");
                XmlElement sotaikhoan = doc.CreateElement("sotaikhoan");
                sotaikhoan.InnerText = tk.sotaikhoan;
                XmlElement tentaikhoan = doc.CreateElement("tentaikhoan");
                tentaikhoan.InnerText = tk.tentaikhoan;
                XmlElement diachi = doc.CreateElement("diachi");
                diachi.InnerText = tk.diachi;
                XmlElement dienthoai = doc.CreateElement("dienthoai");
                dienthoai.InnerText = tk.dienthoai;
                XmlElement sotien = doc.CreateElement("sotien");
                sotien.InnerText = tk.sotien;
                tkUpdate.AppendChild(sotaikhoan);
                tkUpdate.AppendChild(tentaikhoan);
                tkUpdate.AppendChild(diachi);
                tkUpdate.AppendChild(dienthoai);
                tkUpdate.AppendChild(sotien);
                root.ReplaceChild(tkUpdate, tkfind);
                doc.Save(filename);
                return true;
            }
            return false;
        }
    }
}
