using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class bookStoreController : Controller
    {
        dataBookStoreDataContext choThuan = new dataBookStoreDataContext();
        private List<SACH> laySachMoi(int count)
        {
            return choThuan.SACHes.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
        }
        public ActionResult Index()
        {
            var sachmoi = laySachMoi(5);
            return View(sachmoi);
        }
    }
}