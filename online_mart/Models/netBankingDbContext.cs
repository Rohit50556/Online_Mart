using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace online_mart.Models
{
    public class netBankingDbContext:DbContext
    {
        public netBankingDbContext(DbContextOptions<netBankingDbContext> options) : base(options)
        {

        }
        public DbSet<netBankingClass> CreditCard { get;set;}
    }
}
