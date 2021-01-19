using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_mart.Models
{
    public class OrderClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string User { get; set; }
        
        [Key]
        public int tempId { get; set; }


    }
}
