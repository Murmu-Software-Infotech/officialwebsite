using System.ComponentModel.DataAnnotations;

namespace ContactUs_API.DbConext.Entity
{
    public class tblSeo
    {
        [Key]
        public int SeoId { get; set; }
        public string? SeoMetaPage { get; set; }
        public string? SeoData { get; set; }
      
    }
}
