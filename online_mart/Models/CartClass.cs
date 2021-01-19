using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace online_mart.Models
{
    public class CartClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Info { get; set; }

        public string Url { get; set; }

        public int Price { get; set; }
        public string User { get; set; }
        
        [Key]
        public int tempId { get; set; }

    }
}
