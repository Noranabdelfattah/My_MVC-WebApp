using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace My_MVC_WebApp.Models
{ [Table("Departments")]
    public class Departments
    { [Key]
        public int ID { get; set; }

        public string Name { get; set;  }

        public List<Employees> Employees { get; set; }
    }
}
