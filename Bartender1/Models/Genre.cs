using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bartender1.Models
{
    public partial class Genre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int GenreId { get; set;}
        public List<Drink> Drinks { get; set; }
    }
}