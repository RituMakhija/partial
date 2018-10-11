using PartialProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialProject.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        UsersEntities db = new UsersEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }
       // [HttpPost]
        public ActionResult Form(string EmailId)
        {
            tbl_Users u = new tbl_Users() { SlNo=1,UserName="sajal",EmailId="sajal@gmail",ConfirmPassword="123",Password="123"};

            if(ModelState.IsValid)
            {
                db.tbl_Users.Add(u);
                db.SaveChanges();
                return RedirectToAction("Display");
            }
            return PartialView();
        }
       
        public ActionResult Display( string id)
        {
            var data = (from i in db.tbl_Users
                        where i.EmailId == id
                        select i).FirstOrDefault();
            return PartialView(data);
        }

        //[HttpPost]
        //public ActionResult Display(tbl_Users tu)
        //{
        //    //tbl_Users tu = new tbl_Users();

        //    return PartialView(db.tbl_Users.ToList());
        //}
        public ActionResult Save()
        {
            ViewBag.Message = "save as pdf...";
            // PdfPTable Layout = new PdfPTable();
            // doc.SetMargins(0 f, 0 f, 0 f, 0 f);
           
            return View();
        }
        //public ActionResult PrintInvoice(int invoiceId)
        //{
        //    return new ActionAsPdf(
        //                   "Invoice",
        //                   new { invoiceId = invoiceId })
        //    { FileName = "Save.pdf" };
        //}


    }
}