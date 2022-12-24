using System.Web.Http.Cors;
using QLBanHangV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLBanHangV2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
    [RoutePrefix("")]
    public class SanPhamController : ApiController
    {

        HANGEntities db = new HANGEntities();

        [HttpGet]
        public IEnumerable<SanPham> LayTatCaSanPham()
        {
            IEnumerable<SanPham> dsSP = db.SanPhams;
            return dsSP;
        }
        [HttpGet]
        public SanPham LayChiTietSanPham(int masp)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            return sp;
        }

        [HttpPost]
        public bool ThemSanPham(int masp, string ten, float dongia, int madm)
        {
            SanPham sp = new SanPham();
            sp.Ma = masp;
            sp.Ten = ten;
            sp.DonGia = dongia;
            sp.MaDanhMuc = madm;
            db.SanPhams.Add(sp);
            db.SaveChanges();
            return true;
        }
        [HttpDelete]
        public bool XoaSanPham(int masp)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            if(sp != null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpPut]
        public bool SuaSanPham(int masp, string ten, float dongia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            if (sp != null)
            {
                sp.Ma = masp;
                sp.Ten = ten;
                sp.DonGia = dongia;
                sp.MaDanhMuc = madm;
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

