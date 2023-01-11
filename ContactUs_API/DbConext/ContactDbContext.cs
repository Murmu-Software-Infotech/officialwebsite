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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-V253E4L;Initial Catalog=MurmuSoftwareInfotechDB;Persist Security Info=true;Trusted_Connection=true;TrustServerCertificate=true;");// connection string
            }
        }
       
    }
}
