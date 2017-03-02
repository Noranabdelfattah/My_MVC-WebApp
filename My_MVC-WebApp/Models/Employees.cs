using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace My_MVC_WebApp.Models
{
    [Table("tblEmployee")]
    public class Employees
    {
        [Key]
        public string EmployeeId { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public string City { set; get; }
  
        public int DepartementId { set; get; }
       
    }
}