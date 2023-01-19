using ContactUs_API.DbConext.Entity;
using Microsoft.EntityFrameworkCore;

namespace ContactUs_API.DbConext
{
    public class ContactDbContext:DbContext
    {
        public ContactDbContext()
        {
        }

        public ContactDbContext(DbContextOptions<ContactDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tblContactForm> tblContactForm { get; set; }
        public virtual DbSet<Google_Map> Google_Map { get; set; }
        public virtual DbSet<tblHelp_Support> tblHelp_Support { get; set; }
        public virtual DbSet<tblFooter> tblFooter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-JGOIDB5\\MSSQLSERVER03;Initial Catalog=MurmuSoftwareInfotechDB;Persist Security Info=true;Trusted_Connection=true;TrustServerCertificate=true;");// connection string
            }
        }
       
    }
}
