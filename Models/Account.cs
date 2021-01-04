using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebEntityFw.Models
{
    public class Account
    {
        [Key]
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string Branch { get; set; }
        public DateTime JoiningDate { get; set; }

        
    }
}
