using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnotation.Schema;
using Travel.Enum;

namespace Travel.Entities
{
    public class Tour
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TourStart { get; set; }
        public DateTime? TourEnd { get; set;}
        public int? DaysCount { get; set; }
        public int HumansCount { get; set; }
        public int Price { get; set; }
        public int? Discount { get; set; }
        public int FinalPrice
        {
            get
            {
                return Price - (Price * Discount) / 100;
            }
        }
        public bool? Guide { get; set; }
        public ICollection<Place> Places { get; set; }
        public TourType  TourType { get; set; }
    }

}
