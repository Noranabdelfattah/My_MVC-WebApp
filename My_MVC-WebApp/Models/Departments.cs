using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace My_MVC_WebApp.Models
{ [Table("Departments")]
    public class Departments
    {
        public int ID { get; set; }

        public string Name { get; set;  }
    }
}