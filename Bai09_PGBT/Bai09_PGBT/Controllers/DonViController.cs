using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai09_PGBT.Controllers
{
    public class DonViController : ApiController
    {
        [HttpGet]
        public List<DonVi> LayDanhSachDonVi()
        {
            DataBaseDataContext dataContext = new DataBaseDataContext();
            List<DonVi> dsDV = dataContext.DonVis.ToList();

            foreach (DonVi d in dsDV)
                d.NhanViens = null;
           
            return dsDV;

        }
        [HttpGet]
        public DonVi LayChiTietDonVi(int madv)
        {
            DataBaseDataContext dataContext = new DataBaseDataContext();
            DonVi dv = dataContext.DonVis.FirstOrDefault(x => x.MaDonVi == madv);
            dv.NhanViens = null;
            return dv;
        }

        [HttpPost]
        public DonVi ThemDonVi(int madv, string tendv)
        {
            try
            {
                DataBaseDataContext dataContext = new DataBaseDataContext();
                DonVi dv = new DonVi();
                dv.MaDonVi = madv;
                dv.TenDonVi = tendv;
                dataContext.DonVis.InsertOnSubmit(dv);
                dataContext.SubmitChanges();
                //dv.NhanViens = null;
                return dv;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }

    }
}
