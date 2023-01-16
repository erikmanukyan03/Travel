using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnotation.Schema;

namespace Travel.Entities
{
    public class TourPlace
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        [ForeignKey("TourId")]
        public Tour Tour { get; set; }
        public int PlaceId { get; set; }
        [ForeignKey("PlaceId")]
        public Place Place { get; set; }

    }
}
