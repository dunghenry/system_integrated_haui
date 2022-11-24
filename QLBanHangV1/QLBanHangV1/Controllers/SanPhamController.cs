using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLBanHangV1.Controllers
{
    public class SanPhamController : ApiController
    {
        [HttpGet] 
        public List<SanPham> LayTatCaSanPham()
        {
            DBDataContext db = new DBDataContext();
            List <SanPham> dsSP = db.SanPhams.ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }

        [HttpGet]
        public SanPham LayChiTietSanPham(int masp)
        {
            DBDataContext dataContext = new DBDataContext();
            SanPham sp = dataContext.SanPhams.FirstOrDefault(x => x.Ma == masp);
            sp.DanhMuc = null;
            return sp;
        }

        [HttpPost]
        public bool ThemSanPham(int masp, string ten, float dongia, int madm)
        {
            try
            {
                SanPham sp = new SanPham();
                sp.Ma = masp;
                sp.Ten = ten;
                sp.DonGia = dongia;
                sp.MaDanhMuc = madm;
                DBDataContext dataContext = new DBDataContext();
                dataContext.SanPhams.InsertOnSubmit(sp);
                dataContext.SubmitChanges();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        [HttpDelete]
        public bool XoaSanPham(int masp)
        {
            try
            {
                DBDataContext dataContext = new DBDataContext();
                SanPham sp = dataContext.SanPhams.First(x => x.Ma == masp);
                if(sp != null)
                {
                    dataContext.SanPhams.DeleteOnSubmit(sp);
                    dataContext.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        [HttpPut]

        public bool SuaSanPham(int masp, string ten, float dongia, int madm)
        {
            try
            {
                
                DBDataContext dataContext = new DBDataContext();
                SanPham sp = dataContext.SanPhams.FirstOrDefault(x => x.Ma == masp);
                if(sp != null)
                {
                    sp.Ten = ten;
                    sp.DonGia = dongia;
                    sp.MaDanhMuc = madm;
                    dataContext.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

    }
}
