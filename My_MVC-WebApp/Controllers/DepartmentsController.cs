using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using My_MVC_WebApp.Models;

namespace My_MVC_WebApp.Controllers
{
    public class DepartmentsController : Controller
    {
       
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Departments> departments = employeeContext.Departements.ToList();
            return View(departments);
        }
    }
}