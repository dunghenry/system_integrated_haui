using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Web.Http;

namespace Bai09.Controllers
{
    public class SanPhamController : ApiController
    {
        [HttpGet]
        public List<SanPham> LayToanBoSanPham()
        {
            CSDLTESTDataContext context = new CSDLTESTDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }
        [HttpGet]
        public SanPham chiTietSanPham(string id)

        {
            CSDLTESTDataContext context = new CSDLTESTDataContext();
            SanPham sp = context.SanPhams.First(x => x.Ma == id);
            if(sp != null)
                sp.DanhMuc = null;
            return sp;
            
        }
        [HttpGet]

        public List<SanPham> danhSachSanPhamTheoDanhMuc(string madm)
        {
            CSDLTESTDataContext context = new CSDLTESTDataContext();
            List<SanPham> dsSP = context.SanPhams.Where(x => x.MaDanhMuc == madm).ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }

        [HttpGet]
        public List<SanPham> timDanhSachSPCoGTTrongKhoang(string a, string b)
        {

            CSDLTESTDataContext context = new CSDLTESTDataContext();
            List<SanPham> dsSP = context.SanPhams.Where(x => x.DonGia == a || x.DonGia == b).ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }
       
    }
}
