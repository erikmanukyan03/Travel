using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Entities
{
    public class Place
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string PlaceFileImage { get; set; }
        public ICollection<Tour> Tours { get; set; }
    }
}
