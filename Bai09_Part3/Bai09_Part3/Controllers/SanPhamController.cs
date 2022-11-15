using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Bai09_Part3.Models;
namespace Bai09_Part3.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
    [RoutePrefix("")]
    public class SanPhamController : ApiController
    {
        DBEntities db = new DBEntities();
        [HttpGet]
        public IEnumerable<SanPham> LayDanhSachSanPham()
        {
            IEnumerable<SanPham> dsSP = db.SanPhams;
            return dsSP;
        }

        [HttpGet] 
        public SanPham ChiTietSanPham(int masp)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            if(sp == null)
            {
                return null;
            }
            return sp;
        }

        [HttpPost]
        public SanPham ThemSanPham([FromBody] SanPham item)
        {
            db.SanPhams.Add(item);
            db.SaveChanges();
            return item;
        }

        [HttpDelete]
        public string XoaSanPham(int masp)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            db.SanPhams.Remove(sp);
            db.SaveChanges();
            return "Xoa san pham thanh cong";
        }
        [HttpPut]
        public SanPham SuaSanPham(int masp, [FromBody] SanPham sp)
        {
           
            SanPham sanpham = db.SanPhams.FirstOrDefault(x => x.Ma == masp);
            sanpham.Ma = masp;
            sanpham.Ten = sp.Ten;
            sanpham.DonGia = sp.DonGia;
            sanpham.MaDanhMuc = sp.MaDanhMuc;
            db.SaveChanges();
            return sanpham;
        }
    }

}
