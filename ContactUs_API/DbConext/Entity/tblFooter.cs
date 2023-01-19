using System.ComponentModel.DataAnnotations;

namespace ContactUs_API.DbConext.Entity
{
    public class tblFooter
    {
        [Key]
        public int FooterId { get; set; }
        public string? FooterTitle { get; set; }
        public string? FooterDiscription { get; set; }
    }
}
