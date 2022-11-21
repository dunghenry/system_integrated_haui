using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai09_PGBT.Controllers
{
    public class NhanVienController : ApiController
    {
        [HttpGet]
        public List<NhanVien> LayDanhSachNhanVien()
        {
            DataBaseDataContext dataContext = new DataBaseDataContext();

            List<NhanVien> dsNV = dataContext.NhanViens.ToList();

            foreach(NhanVien nv in dsNV)
            {
                nv.DonVi = null;
            }

            return dsNV;
        }
        [HttpGet]
        public NhanVien LayChiTietNhanVien(int manv)
        {
            DataBaseDataContext dataContext = new DataBaseDataContext();
            NhanVien nv = dataContext.NhanViens.FirstOrDefault(x => x.Ma == manv);
            nv.DonVi = null;
            return nv;
        }
        [HttpGet]
        public List<NhanVien> LayNhanVienTheoDonVi(int mdv)
        {
            DataBaseDataContext dataContext = new DataBaseDataContext();
            List<NhanVien> dsNV = dataContext.NhanViens.Where(x => x.MaDonVi == mdv).ToList();
            foreach( NhanVien nv in dsNV)
            {
                nv.DonVi = null;
            }

            return dsNV;
        }

        [HttpGet]
        public List<NhanVien> LayNhaVienTheoGioiTinh(string gt)
        {
            DataBaseDataContext dataContext = new DataBaseDataContext();
            List<NhanVien> dsNV = dataContext.NhanViens.Where(x => x.GioiTinh == gt).ToList();
               foreach(NhanVien nv in dsNV){
                    nv.DonVi=null;
               }
            return dsNV;
        }
        [HttpGet]
        public List<NhanVien> LayNhanVienTheoKhoangHeSoLuong(int from, int to)
        {
            DataBaseDataContext dataContext = new DataBaseDataContext();
            List<NhanVien> dsNV = dataContext.NhanViens.Where(x => x.Hesluong >= from && x.Hesluong <= to).ToList();
            foreach (NhanVien nv in dsNV)
                nv.DonVi = null;
            return dsNV;
        }

        [HttpPost]
        public NhanVien ThemNhanVien(int manv, string hoten, string ns, string gt, double hsl, int madv)
        {
            try
            {
                DataBaseDataContext dataContext = new DataBaseDataContext();
                NhanVien nv = new NhanVien();
                nv.Ma = manv;
                nv.HoTen = hoten;
                nv.NgaySinh = DateTime.Parse(ns);
                nv.GioiTinh = gt;
                nv.Hesluong = (decimal) hsl;
                nv.MaDonVi = madv;
                dataContext.NhanViens.InsertOnSubmit(nv);
                dataContext.SubmitChanges();
                nv.DonVi = null;
                return nv;
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }
        [HttpDelete]

        public bool XoaNhanVien(int manv)
        {
            try
            {
                DataBaseDataContext db = new DataBaseDataContext();
                NhanVien nv = db.NhanViens.FirstOrDefault(x => x.Ma == manv);
                db.NhanViens.DeleteOnSubmit(nv);
                db.SubmitChanges();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        public bool SuaNhanVien(int manv, string hoten, string ns, string gt, double hsl, int madv)
        {
            try
            {
                DataBaseDataContext dataContext = new DataBaseDataContext();
                NhanVien nv = dataContext.NhanViens.FirstOrDefault(x => x.Ma == manv);
                if(nv != null)
                {
                    nv.HoTen = hoten;
                    nv.NgaySinh = DateTime.Parse(ns);
                    nv.GioiTinh = gt;
                    nv.Hesluong = (decimal)hsl;
                    nv.MaDonVi = madv;
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

            }
            return false;
        }
    }
}
