using System.ComponentModel.DataAnnotations;

namespace ContactUs_API.Model
{
    public class tblContactFormModel
    {
        [Key]
        public int CF_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public string Comments { get; set; }
    }
}
