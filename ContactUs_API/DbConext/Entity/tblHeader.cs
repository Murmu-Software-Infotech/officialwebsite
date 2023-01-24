using System.ComponentModel.DataAnnotations;

namespace ContactUs_API.DbConext.Entity
{
    public class tblHeader
    {
        [Key]
        public int HeaderId { get; set; }
        public string? HeaderTitle { get; set; }
        public string? HearderLink { get; set; }
        public string? Data_CTA_Link { get; set; }
        public string? HeaderClass { get; set; }
        public bool HeaderChild { get; set; }
        public string? HeaderMenuParent { get; set; }
    }
}
