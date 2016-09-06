using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bartender1.Models
{
    public class BarEntities: DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}