using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TranVanDung_2019603537.Controllers
{
    public class NhanVienController : ApiController
    {
        QLNVDataContext context = new QLNVDataContext();
        [HttpGet]
        public List<NhanVien> Danhsach()
        {
            List<NhanVien> dsNV = context.NhanViens.ToList();
            return dsNV;
        }
        [HttpGet]
        public NhanVien ChitietNV(int manv)
        {
            NhanVien nv = context.NhanViens.FirstOrDefault(x => x.MaNV == manv);
            if (nv == null)
            {
                return null;
            }
            return nv;
        }

        [HttpDelete]
        public bool XoaNV(int manv)
        {
            NhanVien nv = context.NhanViens.FirstOrDefault(x => x.MaNV == manv);
            if (nv == null)
            {
                return false;
            }
            else
            {
                context.NhanViens.DeleteOnSubmit(nv);
                context.SubmitChanges();
                return true;
            }

        }
        [HttpPost]
        public NhanVien ThemNV(int manv, string tennv, decimal hsluong)
        {
            NhanVien nv = new NhanVien();
            nv.TenNV = tennv;
            nv.MaNV = manv;
            nv.HsLuong = hsluong;
            context.NhanViens.InsertOnSubmit(nv);
            context.SubmitChanges();
            return nv;
        }

        [HttpPut]
        public NhanVien SuaNV(int manv, string tennv, decimal hsluong)
        {
            NhanVien nv = context.NhanViens.FirstOrDefault(x => x.MaNV == manv);
            if (nv == null)
            {
                return null;
            }
            else
            {
                nv.TenNV = tennv;
                nv.HsLuong = hsluong;
                context.SubmitChanges();
                return nv;
            }
            
        }
    }
}
