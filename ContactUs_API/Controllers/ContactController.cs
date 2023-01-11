using ContactUs_API.DbConext.Entity;
using ContactUs_API.DbConext;
using Microsoft.AspNetCore.Mvc;
using ContactUs_API.Model;
using System.Collections.Generic;

namespace ContactUs_API.Controllers
{
    [Route("api/Contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        ContactDbContext _context;
        public ContactController()
        {
            _context = new ContactDbContext();
        }
            
        [HttpGet("GetAllRecord")]
        public IEnumerable<tblContactForm> GetAllRecord()
        {
            try
            {
                return _context.tblContactForm.ToList();
            }
            catch (Exception ex)
            {
                throw ex; 
            } 
        }

        
        [HttpPost("Submit")]
        public string Submit(tblContactFormModel contactFormModel)
        {
            try
            {
                tblContactForm tblContact = new tblContactForm();
                tblContact.FirstName = contactFormModel.FirstName;
                tblContact.LastName = contactFormModel.LastName;
                tblContact.EmailId = contactFormModel.EmailId;
                tblContact.MobileNumber = contactFormModel.MobileNumber;
                tblContact.Comments = contactFormModel.Comments;
                _context.Add(tblContact);
                _context.SaveChanges();
                return "Ok";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
