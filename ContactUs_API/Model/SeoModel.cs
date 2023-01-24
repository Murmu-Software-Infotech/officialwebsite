using System.ComponentModel.DataAnnotations;

namespace ContactUs_API.Model
{
    public class SeoModel
    {
        [Key]
        public int SeoId { get; set; }
        public string? SeoMetaPage { get; set; }
        public string? SeoData { get; set; }
    }
}
