using Bai09_Part3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai09_Part3.Controllers
{
    public class DanhMucController : ApiController
    {
        DBEntities db = new DBEntities();
        [HttpGet]
        public IEnumerable<DanhMuc> LayDanhSachDanhMuc()
        {
            IEnumerable<DanhMuc> dsDM = db.DanhMucs;
            return dsDM;
        }
    }
}
