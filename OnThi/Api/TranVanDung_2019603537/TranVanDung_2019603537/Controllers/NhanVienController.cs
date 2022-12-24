﻿using System;
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
        QLNVEntities db = new QLNVEntities();

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
            nv.TenNV = tennv;
            nv.MaNV = manv;
            nv.HsLuong = hsluong;
            db.NhanViens.Add(nv);
            db.SaveChanges();
            return nv;
        }

        [HttpGet]
        public NhanVien LayNV(int manv)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == manv);
            if (nv == null)
            {
                return null;
            }
            return nv;
        }

        [HttpDelete]
        public bool XoaNV(int manv)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == manv);
            if (nv == null)
            {
                return false;
            }
            db.NhanViens.Remove(nv);
            db.SaveChanges();
            return true;
        }

        [HttpPut]
        public NhanVien SuaNV(int manv, string tennv, decimal hsluong)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(x => x.MaNV == manv);
            if (nv == null)
            {
                return null;
            }
            nv.TenNV = tennv;
            nv.HsLuong = hsluong;
            db.SaveChanges();
            return nv;
        }
    }

}
