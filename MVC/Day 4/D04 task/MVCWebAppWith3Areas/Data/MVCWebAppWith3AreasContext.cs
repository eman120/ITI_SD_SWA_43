using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebAppWith3Areas.Data
{
    public class MVCWebAppWith3AreasContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVCWebAppWith3AreasContext() : base("name=MVCWebAppWith3AreasContext")
        {
        }

        public System.Data.Entity.DbSet<MVCWebAppWith3Areas.Models.Employee> Employees { get; set; }
    }
}
