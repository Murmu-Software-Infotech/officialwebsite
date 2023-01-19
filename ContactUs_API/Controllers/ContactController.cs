using ContactUs_API.DbConext.Entity;
using ContactUs_API.DbConext;
using Microsoft.AspNetCore.Mvc;
using ContactUs_API.Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UTILITY.CommanModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ContactUs_API.Controllers
{
    [Route("api/Contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        //static readonly Dictionary<Guid, Footer> footers = new Dictionary<Guid, Footer>();
        ContactDbContext _context;
        public ContactController()
        {
            _context = new ContactDbContext();
        }
        /// <summary>
        ///  get all record from contact form tbl
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// record inser into contact form tbl
        /// </summary>
        /// <param name="contactFormModel"></param>
        /// <returns></returns>
        [HttpPost("Submit")]
        public string Submit(tblContactFormModel contactFormModel)
        {
            try
            {
                if (contactFormModel!= null)
                {
                    tblContactForm tblContact = new tblContactForm();
                    tblContact.FirstName = contactFormModel.FirstName;
                    tblContact.LastName = contactFormModel.LastName;
                    tblContact.EmailId = contactFormModel.EmailId;
                    tblContact.MobileNumber = contactFormModel.MobileNumber;
                    tblContact.Comments = contactFormModel.Comments;
                    _context.Add(tblContact);
                    _context.SaveChanges();
                    return "Record successfully inserted";
                }
                else
                {
                    return "Record not found";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// get all record from google map tbl
        /// </summary>
        /// <param name="mapId"></param>
        /// <returns></returns>

        [HttpGet("GetAllMapRecord")]
        public IEnumerable<Google_Map> GetAllMapRecord()
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
        /// <summary>
        /// get the record form google map tbl by id
        /// </summary>
        /// <param name="mapId"></param>
        /// <returns></returns>
        [HttpGet("GetMapRecordById")]
        public GoogleMapModel GetMapRecordById(int mapId)
        {
            try
            {
                GoogleMapModel google_Map = new GoogleMapModel();
                var data = _context.Google_Map.Find(mapId);
                if (data != null)
                {
                    google_Map.Id = data.Id;
                    google_Map.Id = data.Id;
                    google_Map.Location = data.Location;
                    google_Map.GoogleLink = data.GoogleLink;
                    google_Map.CTA_Id = data.CTA_Id;
                    return google_Map;
                }  
                else
                {
                    return google_Map;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>
        /// update record into google map tbl by id 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("UpdateMapRecordById")]
        public string UpdateMapRecordById(GoogleMapModel model)
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
                    return "Ok";
                }
                else
                {
                    return "Record id not find";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// get all record from help support tbl
        /// </summary>
        /// <returns></returns>

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
        
        /// <summary>
        /// get record from help support tbl by id
        /// </summary>
        /// <param name="helpSupportById"></param>
        /// <returns></returns>
        [HttpGet("GetHelpSupportById")]
        public HelpSupportModel GetHelpSupportById(int helpSupportById)
        {
            try
            {
                HelpSupportModel support = new HelpSupportModel();
                 var data = _context.tblHelp_Support.Find(helpSupportById);
                if (data != null)
                {
                    support.Id = data.Id;
                    support.Title = data.Title;
                    support.Title_Discription = data.Title_Discription;
                    support.Title_Logo = data.Title_Logo;
                    support.CTA_Id = data.CTA_Id;
                    support.Action = data.Action;
                    return support;
                }
                else
                {
                    return support;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// update record into help support tbl by id
        /// </summary>
        /// <param name="helpSupportModel"></param>
        /// <returns></returns>
        [HttpPost("UpdateHelpSupportById")]
        public string UpdateHelpSupportById(HelpSupportModel helpSupportModel)
        {
            try
            {
                tblHelp_Support support = new tblHelp_Support();
                support = _context.tblHelp_Support.Find(helpSupportModel.Id);
                if (support != null)
                {
                    support.Id = helpSupportModel.Id;
                    support.Title = helpSupportModel.Title;
                    support.Title_Discription = helpSupportModel.Title_Discription;
                    support.Title_Logo = helpSupportModel.Title_Logo;
                    support.CTA_Id = helpSupportModel.CTA_Id;
                    support.Action = helpSupportModel.Action;
                    _context.SaveChanges();
                    return "Record Udate successfully";
                }
                else
                {
                    return "Record id not find";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get record from footer tbl by id
        /// </summary>
        /// <param name="footerId"></param>
        /// <returns></returns>
        [HttpGet("GetFooterDataById")]
        public Footer GetFooterDataById(int footerId)
        {
            try
            {
                Footer footer = new Footer();
                 var footerData = _context.tblFooter.Find(footerId);
                if (footer != null)
                {
                    footer.FooterId = footerData.FooterId;
                    footer.FooterTitle = footerData.FooterTitle;
                    footer.FooterDiscription = footerData.FooterDiscription;
                    return footer;
                }
                else
                {
                    return footer;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// update record into footer tbl by id
        /// </summary>
        /// <param name="footers"></param>
        /// <returns></returns>
        [HttpPost("UpdateFooterById")]
        public string UpdateFooterById(Footer footers)
        {
            try
            {
                tblFooter footerObj = new tblFooter();
                footerObj = _context.tblFooter.Find(footers.FooterId);
                if (footerObj != null)
                {
                    footerObj.FooterId = footers.FooterId;
                    footerObj.FooterTitle = footers.FooterTitle;
                    footerObj.FooterDiscription = footers.FooterDiscription;
                    _context.SaveChanges();
                    return "Record Udate successfully";
                }
                else
                {
                    return "Record id not find";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
