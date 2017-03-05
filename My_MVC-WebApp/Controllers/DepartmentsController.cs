using My_MVC_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_MVC_WebApp.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult Index()
        {
            EmployeeContext employeecontext = new EmployeeContext();
            List<Departments> departments = employeecontext.Departments.ToList();

            return View(departments);
        }
    }
}