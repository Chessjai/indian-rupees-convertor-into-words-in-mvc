using MVC_rupees_converter.DAL;
using MVC_rupees_converter.Logic;
using MVC_rupees_converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_rupees_converter.Controllers
{
    public class HomeController : Controller
    {
        Question2DbEntities2 db =new Question2DbEntities2();

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbl_Currencys obj)
        {
            string strinput=obj.Input.ToString();
            decimal input;
            if (decimal.TryParse(strinput,out input))
            {
                LogicClass lg = new LogicClass();
                string datainword = lg.FirstMthod(obj.Input.ToString());
                if (datainword=="Invaild amount rupees in format")
                {
                    ViewBag.Message1 = "data not inserted";
                    ViewBag.ShowData1 = datainword;
                }
                else
                {
                    ViewBag.Message2 = "data inserted";
                    ViewBag.Showdata2=datainword;
                    db.sp_Insertdata(strinput, datainword);
                  
                }
            }
            else
            {
                ViewBag.ShowData1 = "please enter valid amount";
            }
            return View();
           

        }


    }
}