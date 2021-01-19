using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace online_mart.Models
{
    public class CartDbContext :DbContext
    {
        public CartDbContext(DbContextOptions<CartDbContext> options) : base(options)
        {

        }
        public DbSet<CartClass> Cart { get; set; }
    }
}
