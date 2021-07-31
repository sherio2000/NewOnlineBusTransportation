using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Models
{
    public class ShowBookingViewModel
    {
        [NotMapped]
        public int BookingID { get; set; }
        [NotMapped]

        public int BusInfoID { get; set; }
        [NotMapped]

        public string Departure { get; set; }
        [NotMapped]

        public string Destination { get; set; }
        [NotMapped]

        public DateTime datetime { get; set; }
        [NotMapped]

        public string Name { get; set; }
       
        public string BusNumber { get; set; }
        [NotMapped]
        public string Seats { get; set; }
        [NotMapped]

        public int price { get; set; }

        [NotMapped]

        public string userid { get; set; }





    }
}
