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
        public bool ThemDonVi(int madv, string tendv)
        {
            try
            {
                DataBaseDataContext dataContext = new DataBaseDataContext();
                DonVi dv = new DonVi();
                dv.MaDonVi = madv;
                dv.TenDonVi = tendv;
                dataContext.DonVis.InsertOnSubmit(dv);
                dataContext.SubmitChanges();
                dv.NhanViens = null;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        [HttpDelete]
        public bool XoaDonVi(int madv)
        {
            try
            {
                DataBaseDataContext dataContext = new DataBaseDataContext();
                DonVi dv = dataContext.DonVis.FirstOrDefault(x => x.MaDonVi == madv);
                if(dv != null)
                {
                    dataContext.DonVis.DeleteOnSubmit(dv);
                    dataContext.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        [HttpPut]
        public bool SuaDonVi(int madv, string tendv)
        {
            try
            {
                DataBaseDataContext dataContext = new DataBaseDataContext();
                DonVi dv = dataContext.DonVis.FirstOrDefault(x => x.MaDonVi == madv);
                if(dv != null)
                {
                    dv.TenDonVi = tendv;
                    dataContext.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

    }
}
