using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace online_mart.Models
{
    public class netBankingClass
    {
        [Key]
        [Required(ErrorMessage = "Enter Account Number")]
        [Display(Name = "Account Number")]
        public string CardNo { get; set; }

        [Required(ErrorMessage = "Enter Expiration Date")]
        [Display(Name = "Expiration")]
        public string Expiration { get; set; }

        [Required(ErrorMessage = "Enter CVV")]
        [Display(Name = "CVV")]
        public int CVV { get; set; }
        public int Balance { get; set; }
    }
}
