using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TranVanDung_2019603537.Models;

namespace TranVanDung_2019603537.Controllers
{
    public class NhanVienController : ApiController
    {
        CSDL db = new CSDL();
        [HttpGet]
        public IEnumerable<NhanVien> Danhsach()
        {
            IEnumerable<NhanVien> dsNV = db.NhanViens;
            return dsNV;
        }

        [HttpPost]
        public NhanVien ThemNV(int manv, string tennv, decimal hsluong)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = manv;
            nv.TenNV = tennv;
            nv.HsLuong = hsluong;
            db.NhanViens.Add(nv);
            db.SaveChanges();
            return nv;
        }


        [HttpDelete]
        public bool XoaNV(int manv)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == manv);
            if(nv == null)
            {
                return false;
            }
            else
            {
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                return true;
            }
           
        }

        [HttpPut]
        public NhanVien SuaNV(int manv, string tennv, decimal hsluong)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == manv);
            if (nv == null)
            {
                return null;
            }
            else
            {
                nv.HsLuong = hsluong;
                nv.TenNV = tennv;
                db.SaveChanges();
                return nv;
            }
        }

    }
}
