using PharmacyFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PharmacyFirst.Context
{
    public class EmployeeProfileContext : DbContext
    {
        public DbSet<EmployeeProfile> EmployeeProfile { get; set; }
    }
}