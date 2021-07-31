using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Models
{
    public class BusInfo
    {
        [Key]
        public int ID { get; set; }
        public int BusID { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime datetime { get; set; }
        public int availableSeats { get; set; }
        public int BookedSeats { get; set; }


    }
}
