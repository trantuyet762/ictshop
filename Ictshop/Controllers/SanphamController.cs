using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
        Qlbanhang db = new Qlbanhang();

        // GET: Sanpham
        public ActionResult Applepartial()
        {
            var ip = db.Sanphams.Where(n => n.Mahang == 2).Take(4).ToList();
            return PartialView(ip);
        }
        public ActionResult Acerpartial()
        {
            var ss = db.Sanphams.Where(n => n.Mahang == 3).Take(4).ToList();
            return PartialView(ss);
        }
        public ActionResult Dellpartial()
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 4).Take(4).ToList();
            return PartialView(mi);
        }

        public ActionResult Asuspartial()
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 7).Take(4).ToList();
            return PartialView(mi);
        }
        public ActionResult Chuotpartial()
        {
            var mi = db.Sanphams.Where(n => n.maLinhKien == 1).Take(4).ToList();
            return PartialView(mi);
        }
        public ActionResult Phimpartial()
        {
            var mi = db.Sanphams.Where(n => n.maLinhKien == 3).Take(4).ToList();
            return PartialView(mi);
        }
        public ActionResult Rampartial()
        {
            var mi = db.Sanphams.Where(n => n.maLinhKien == 4).Take(4).ToList();
            return PartialView(mi);
        }
        //public ActionResult dttheohang(int Mahang)
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == Mahang).Take(4).ToList();
        //    return PartialView(mi);
        //}
        
        public ActionResult xemchitiet(int Masp=0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }
        public ActionResult sanpham(int MaHang)       
        {
            
            var lstSP = db.Sanphams.Where(n => n.Mahang == MaHang);
            
            return View(lstSP);
        }
        public ActionResult LinhKien(int MaLinhKien)
        {

            var lstSP = db.Sanphams.Where(n => n.maLinhKien == MaLinhKien);
            
            return View(lstSP);
        }
    }

}