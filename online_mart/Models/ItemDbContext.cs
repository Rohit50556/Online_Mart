using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace online_mart.Models
{
    public class ItemDbContext:DbContext
    {
         public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
        {

        }
        public DbSet<ItemClass> Items { get; set; }

    }
}
