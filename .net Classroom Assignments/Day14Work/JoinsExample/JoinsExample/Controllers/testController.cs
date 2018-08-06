using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JoinsExample.Models;
namespace JoinsExample.Controllers
{
    public class testController : Controller
    {
        TrainingDBEntities db = new TrainingDBEntities();
        // GET: test
        public ActionResult ShowProduct()
        {
            var data = new SelectList(db.products, "prodid", "pname");
            Session["pdata"] = data;
            return View();
        }
        [HttpPost]
        public ActionResult ShowProduct(int id=0)
        {
            id = int.Parse(Request.Form["ddlprod"].ToString());
            var join = (from t in db.products
                        join m in db.models
                        on t.prodid equals m.prodid
                        where m.prodid == id
                        select m).ToList();
            Session["mdata"] = new SelectList(join, "modelid", "modelname");
            return View();
        }
    }
}