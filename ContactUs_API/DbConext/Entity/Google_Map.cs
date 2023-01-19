using System.ComponentModel.DataAnnotations;

namespace ContactUs_API.DbConext.Entity
{
    public class Google_Map
    {
        [Key]
        public int Id { get; set; }
        public string? Location { get; set; }
        public string? GoogleLink { get; set; }
        public int CTA_Id { get; set; }
       
    }
}
