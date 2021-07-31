using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Models
{
    public class UsersBooking
    {
        [Key]
        public int BookingID { get; set; }
        public string UserID { get; set; }
        public int BusInfoID { get; set; }
        public string Seats { get; set; }
        public int price { get; set; }
    }
}
