using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai09_Part2.Controllers
{
    public class DanhMucController : ApiController
    {
        [HttpGet]
        public List<DanhMuc> LayToanBoDanhMuc()
        {
            DBDataContext db = new DBDataContext();
            List<DanhMuc> dsDM = db.DanhMucs.ToList();
            foreach(DanhMuc dm in dsDM)
            {
                dm.SanPhams = null;
            }
            return dsDM;
        }
    }
}
