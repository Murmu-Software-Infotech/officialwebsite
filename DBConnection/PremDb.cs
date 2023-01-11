using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection
{
    public class PremDb : DbContext
    {
        public PremDb()
        {
        }

        public PremDb(DbContextOptions<PremDb> options)
            : base(options)
        {
        }

       // public virtual DbSet<Cars> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-V253E4L;Database=MurmuSoftwareInfotechDB;Trusted_Connection=True;");// connection string
            }
        }
    }
}
