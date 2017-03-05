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

        public ActionResult Index0()                              // View All 
        {
            EmployeeContext employeecontext = new EmployeeContext();
            List<Employee> employeesList = employeecontext.Employees.ToList();

            return View(employeesList);
        }


        public ActionResult Index( int departmentId)                     // Employees of a specific Departments
        {
            EmployeeContext employeecontext = new EmployeeContext();
            List<Employee> employeesList = employeecontext.Employees.Where(emp=>emp.DepartementId== departmentId).ToList();

            return View(employeesList);
        }

        // GET: Employees
        public ActionResult Details(string id )

        { 
           EmployeeContext employeecontext = new EmployeeContext();
           Employee employee = employeecontext.Employees.Single(emp => emp.EmployeeId.Equals(id));

            return View(employee);
      
        }
    }
}