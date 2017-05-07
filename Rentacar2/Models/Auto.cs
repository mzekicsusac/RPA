using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace Rentacar2.Models
{
    public class Auto
    {
        public int AutoID { get; set; }
        public string NazivAuta { get; set; }
        public int GodinaProizvodnje { get; set; }
        public decimal NabavnaCijena { get; set; }

    }
    public class AutoDBContext : DbContext
    {
        public DbSet<Auto> Autos { get; set; }
    }

}