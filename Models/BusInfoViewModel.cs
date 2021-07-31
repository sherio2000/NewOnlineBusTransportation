using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Models
{
    public class BusInfoViewModel
    {
        [NotMapped]
        public int ID { get; set; }
        [NotMapped]

        public int BusID { get; set; }
        [NotMapped]

        public string Departure { get; set; }
        [NotMapped]

        public string Destination { get; set; }
        [NotMapped]

        public DateTime datetime { get; set; }
        [NotMapped]

        public string Name { get; set; }
        [NotMapped]

        public string Type { get; set; }
        [NotMapped]

        public string BusCapacity { get; set; }
        [NotMapped]

        public string BusNumber { get; set; }
        [NotMapped]

        public int AvailableSeats { get; set; }
        [NotMapped]

        public int BookedSeats { get; set; }



    }
}
