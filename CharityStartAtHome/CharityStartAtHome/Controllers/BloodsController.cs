using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using CharityStartAtHome.Models;

namespace CharityStartAtHome.Controllers
{
    [HandleError]
    public class BloodsController : Controller
    {
        private Donation db = new Donation();

        // GET: Bloods
        public ActionResult List(string searchString, string currentFilter, int page = 1)
        {

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var bloods = from b in db.Bloods
                          select b;
           
                if (!string.IsNullOrEmpty(searchString))
                {

                    bloods = db.Bloods.Where(b => b.Address.ToString().Contains(searchString));

                }
                int pageSize = 5;
                var list = bloods.ToList().ToPagedList(page, pageSize);
                var count = list.Count;
            int var1 = 0;
            if (!string.IsNullOrEmpty(searchString) && searchString.All(char.IsDigit))
            {
                var1 = Convert.ToInt32(searchString);
            }
            else
            {
                var1 = 0;
            }
            if (count == 0)
            {

                if (searchString.Trim().Length == 4 && searchString.All(char.IsDigit))
                {
                    ViewBag.Mystring = "No blood donation centers in " + var1 + " was found";
                    for (int i = 0; i < 100; i++)
                    {

                        var1 = var1 + 1;
                        ViewBag.Mystring2 = "Here is a list of nearby ones.";
                        bloods = db.Bloods.Where(c => c.Address.ToString().Contains(var1.ToString()));
                        list = bloods.ToList().ToPagedList(page, pageSize);
                        count = list.Count;
                        if (count > 0)
                        {
                            break;
                        }
                        //clothes = db.Clothes.Where(c => c.Postcode.ToString().Contains(var0.ToString()) || c.Postcode.ToString().Contains(var2.ToString()) || c.Postcode.ToString().Contains(var3.ToString()) || c.Postcode.ToString().Contains(var0.ToString()));
                        //}
                        //return View(clothes.ToList().ToPagedList(page, pageSize));
                        else
                        {
                            ViewBag.Mystring2 = "Cant find the nearby place";
                        }
                    }
                }
                else
                {
                    ViewBag.Mystring2 = "Please check your input of " + searchString;
                    //return View(clothes.ToList().ToPagedList(page, pageSize));
                }
            }
            else
            {
                return View(bloods.ToList().ToPagedList(page, pageSize));
            }
            return View(bloods.ToList().ToPagedList(page, pageSize));
            
        

        }
        public ActionResult Bloodm()
        {
              return View();
        }
        // GET: Bloods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blood blood = db.Bloods.Find(id);
            if (blood == null)
            {
                return HttpNotFound();
            }
            return View(blood);
        }
        public ActionResult Map(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blood blood = db.Bloods.Find(id);
            if (blood == null)
            {
                return HttpNotFound();
            }
            return View(blood);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
