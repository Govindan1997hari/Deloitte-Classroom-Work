using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCProjects.Models;
using System.Web.Mvc;

namespace MVCProjects.Controllers
{
    public class RegisterShoppingCRUDController : Controller
    {
        TrainingDBEntities db = new TrainingDBEntities();
        // GET: RegisterShoppingCRUD
        [HttpGet]
        public ActionResult InsertRegisterShopping()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertRegisterShopping(RegisterShopping rs)
        {
            rs.name = Request.Form["txtname"].ToString();
            rs.gender = Request.Form["gender"].ToString();
            rs.membership = Request.Form["ddlmember"].ToString();
            rs.shoppingpreference = Request.Form["shop"].ToString();
            var res =Request.Form["cbcod"].ToString();
            if (res=="false")
                rs.COD = "No";
            else
                rs.COD = "Yes";
            rs.passw = Request.Form["txtpass"].ToString();
            db.RegisterShoppings.Add(rs);
            var result = db.SaveChanges();
            if (result > 0)
                ModelState.AddModelError("", "Data Inserted");
            return View();
        }
        public ActionResult SelectAllRegisterShopping()
        {
            var data = db.RegisterShoppings.ToList();
            return View(data);

        }
        [HttpGet]
        public ActionResult SelectByID()
        {
            var data = new SelectList(db.RegisterShoppings, "Id", "name");
            Session["rsdata"] = data;
            return View();
        }
        [HttpPost]
        public ActionResult SelectByID(string Command)
        {
            int id = int.Parse(Request.Form["ddlid"].ToString());
            if (Command == "SelectByID")
            {
                var data = (db.RegisterShoppings.Where(x => x.Id == id)).SingleOrDefault();
                ViewData["userdata"] = data;
                return View(data);
                
            }
            if(Command=="Update")
            {
                int oldid = int.Parse(Request.Form["txtid"].ToString());
                var olddata = (db.RegisterShoppings.Where(x => x.Id == oldid)).SingleOrDefault();
                olddata.membership = Request.Form["txtmem"].ToString();
                olddata.shoppingpreference = Request.Form["txtshop"].ToString();
                olddata.COD = Request.Form["txtcod"].ToString();
                olddata.passw = Request.Form["txtpass"].ToString();
                var res = db.SaveChanges();
                if (res > 0)
                    ModelState.AddModelError("", "Data Updated");
                return View();
            }
            if(Command=="Delete")
            {
                int oldid = int.Parse(Request.Form["txtid"].ToString());
                var olddata = (db.RegisterShoppings.Where(x => x.Id == oldid)).SingleOrDefault();
                db.RegisterShoppings.Remove(olddata);
                var res = db.SaveChanges();
                if (res > 0)
                    ModelState.AddModelError("", "Data Deleted");
                return View();

            }
            return View();
        }
        [HttpGet]
        public ActionResult SelectAndEdit()
        {
            var data = db.RegisterShoppings.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var data = (db.RegisterShoppings.Where(x => x.Id == id)).SingleOrDefault();
            Session["rsdata"] = data;
            return View();
        }
        [HttpPost]
        public ActionResult Update()
        {
            int id = int.Parse(Request.Form["txtid"].ToString());
            var olddata = db.RegisterShoppings.Where(x => x.Id == id).SingleOrDefault();
            olddata.membership = Request.Form["txtmem"].ToString();
            olddata.shoppingpreference = Request.Form["txtshop"].ToString();
            olddata.COD = Request.Form["txtcod"].ToString();
            olddata.passw = Request.Form["txtpass"].ToString();
            var res = db.SaveChanges();
            if (res > 0)
            {
                //Response.Write("Data Updated");
                return RedirectToAction("SelectAndEdit");//redirectiing from controller
            }
            //v that is to redirect after the data is updated
            return View();
        }
    }
}