using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiledb001.Models
{
    public class MobileContext:DbContext
    {
        public MobileContext():base("DefaultConnection")
        {

        }
        public DbSet<Phone> Phones { get; set; }


    }
}
