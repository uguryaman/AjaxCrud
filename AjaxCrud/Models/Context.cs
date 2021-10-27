using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCrud.Models
{
    public class Context:DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("");

        //}
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Admin> Admins { get; set; }
    }
}
