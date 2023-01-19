using ContactUs_API.DbConext.Entity;
using ContactUs_API.DbConext;
using Microsoft.AspNetCore.Mvc;
using ContactUs_API.Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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


        [HttpGet("GetAllGooleRecord")]
        public IEnumerable<Google_Map> GetAllGooleRecord()
        {
            try
            {
                return _context.Google_Map.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("UpdateGooleRecordById")]
        public string UpdateGooleRecordById(GoogleMapModel model)
        {
            try
            {
                Google_Map google_Map = new Google_Map();
                google_Map = _context.Google_Map.Find(model.Id);
                if (google_Map != null)
                {
                    google_Map.Id = model.Id;
                    google_Map.Location = model.Location;
                    google_Map.GoogleLink = model.GoogleLink;
                    google_Map.CTA_Id = model.CTA_Id;
                    _context.SaveChanges();
                }
                return "Ok";
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet("GetAllHelpSupportRecord")]
        public IEnumerable<tblHelp_Support> GetAllHelpSupportRecord()
        {
            try
            {
                return _context.tblHelp_Support.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("UpdateHelpSupportById")]
        public string UpdateHelpSupport(HelpSupportModel helpSupportModel)
        {
            try
            {
                tblHelp_Support support = new tblHelp_Support();
                support = _context.tblHelp_Support.Find(helpSupportModel.Id);
                if (support != null) {
                    support.Id = helpSupportModel.Id;
                    support.Title = helpSupportModel.Title;
                    support.Title_Discription = helpSupportModel.Title_Discription;
                    support.Title_Logo = helpSupportModel.Title_Logo;
                    support.CTA_Id = helpSupportModel.CTA_Id;
                    support.Action = helpSupportModel.Action;
                    _context.SaveChanges();
                    return "Ok";
                }
                else
                {
                    return "Record not find";
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
