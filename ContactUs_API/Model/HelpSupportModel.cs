using System.ComponentModel.DataAnnotations;

namespace ContactUs_API.Model
{
    public class HelpSupportModel
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Title_Discription { get; set; }
        public string? Title_Logo { get; set; }
        public int CTA_Id { get; set; }
        public string? Action { get; set; }
    }
}
