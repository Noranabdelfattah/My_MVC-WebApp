
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace My_MVC_WebApp.Models
{   public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { set; get; }

        public DbSet<Departments> Departments { get; set; }

    }
}