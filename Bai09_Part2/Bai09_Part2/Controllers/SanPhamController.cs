using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai09_Part2.Controllers
{
    public class SanPhamController : ApiController
    {
        [HttpGet]
        public List<SanPham> LayToanBoSanPham()
        {
            DBDataContext db = new DBDataContext();

            List<SanPham> dsSP = db.SanPhams.ToList();
            foreach (SanPham sp in dsSP)
            {
                sp.DanhMuc = null;
            }
            return dsSP;
        }

        [HttpGet]
        public SanPham ChiTietSanPham(int id)
        {

            DBDataContext db =  new DBDataContext();
            SanPham sp = db.SanPhams.First(x => x.Ma == id);
            if(sp != null){
                sp.DanhMuc = null;
            }
            return sp;
        }

        [HttpGet]
        public List<SanPham> LaySanPhamTheoDanhMuc(int madm)
        {
            DBDataContext db = new DBDataContext();
            List<SanPham> dsSP = db.SanPhams.Where(x => x.MaDanhMuc == madm).ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }

        [HttpGet]
        public List<SanPham> LaySanPhamTheoKhoangGia(int from, int to)
        {
            DBDataContext db = new DBDataContext();
            List<SanPham> dsSP = db.SanPhams.Where(x => x.DonGia >= from && x.DonGia <= to).ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }

        [HttpDelete]
        public string XoaSanPham(int masp)
        {
            try
            {
                DBDataContext db = new DBDataContext();
                SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
                if (sp != null)
                {
                    db.SanPhams.DeleteOnSubmit(sp);
                    db.SubmitChanges();
                    return "Xoa san pham thanh cong";
                }
                else
                {
                    return "San pham khong ton tai trong DB";
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return "Xoa san pham that bai";
        }


        [HttpPost]
        public SanPham ThemSanPham(int masp, string ten, int dg, int madm)
        {
            //Ma, Ten, DonGia, MaDanhMuc
            try
            {
                DBDataContext db = new DBDataContext();
                SanPham sp = new SanPham();
                sp.Ma = masp;
                sp.Ten = ten;
                sp.DonGia = dg;

                sp.MaDanhMuc = madm;
                db.SanPhams.InsertOnSubmit(sp);
                db.SubmitChanges();
                sp.DanhMuc = null;
                return sp;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

        [HttpPut]
        public SanPham SuaSanPham(int masp, string ten, int dg, int madm)
        {
            try
            {
                DBDataContext db = new DBDataContext();
                SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
                if(sp != null)
                {
                    sp.Ten = ten;
                    sp.DonGia = dg;
                    sp.MaDanhMuc = madm;
                    db.SubmitChanges();
                    sp.DanhMuc = null;
                    return sp;
                }

            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }
    }
}
