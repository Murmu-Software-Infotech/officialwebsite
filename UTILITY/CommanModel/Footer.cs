using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILITY.CommanModel
{
    public class Footer
    {
        [Key]
        public int FooterId { get; set; }
        public string? FooterTitle { get; set; }
        public string? FooterDiscription { get; set; }
    }
}
