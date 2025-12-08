using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeManagment.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("DefaultConnection")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}