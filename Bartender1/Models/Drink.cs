using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bartender1.Models
{
    public class Drink
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public decimal Price { get; set; }
        public int DrinkId { get; set; }
        public int GenreId { get; set; }
        public int MixerId { get; set; }
        public Mixer Mixer { get; set; }
    }
}