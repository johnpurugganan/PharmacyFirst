using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PharmacyFirst.Models
{
    public class EmployeeProfile
    {
        [Key]
        public int id { get; set; }
        public string FirstName {get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public Boolean Active { get; set; }
        public DateTime UpdateDateTime { get; set; } 
        public string UpdatedBy { get; set; }
        public int Departmentid { get; set; }
        public int Positionid { get; set; }
        public int contactid { get; set; }
        public string userid { get; set; }
        public string phoneNum { get; set; }
        public string phoneExt { get; set; }
    }
}