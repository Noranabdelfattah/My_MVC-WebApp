using My_MVC_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_MVC_WebApp.Controllers
{
    public class EmployeesController : Controller
    {

        public ActionResult Index( int departementid)
        {
            EmployeeContext employeecontext = new EmployeeContext();
            List<Employees> employeesList = employeecontext.Employees.Where(emp=>emp.DepartementId== departementid).ToList();

            return View(employeesList);
        }

        // GET: Employees
        public ActionResult Details(string id )

        { 
           EmployeeContext employeecontext = new EmployeeContext();
           Employees employee = employeecontext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
      
        }
    }
}