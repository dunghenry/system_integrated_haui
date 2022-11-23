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
    }
}
