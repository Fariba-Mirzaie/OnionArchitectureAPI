using Microsoft.EntityFrameworkCore;
using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Domain.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> Options) :base(Options)
        {
        }

        public DbSet<Product> products { get; set; }

    }
}
