using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class productDbcontext : DbContext
    {
       
        
            public productDbcontext()
                : base("productcontext")
            {

            }
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<company> Companies { get; set; }
            public DbSet<country> Countries { get; set; }
        }
}