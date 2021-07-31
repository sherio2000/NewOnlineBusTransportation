using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Models
{
    public class SeatBooking
    {
     public List<Row1> Row1 { get; set; }
        public List<Row2> Row2 { get; set; }
        public List<Row3> Row3 { get; set; }
        public List<Row4> Row4 { get; set; }
        public List<Row5> Row5 { get; set; }




    }
    public class Row1
    {
        [NotMapped]
        public string SeatID { get; set; }
        [NotMapped]

        public int SeatNumber { get; set; }

        [NotMapped]

        public string SeatStatus { get; set; }
        [NotMapped]

        public DateTime bookingdatetime { get; set; }


    }
    public class Row2
    {
        [NotMapped]
        public string SeatID { get; set; }
        [NotMapped]

        public int SeatNumber { get; set; }

        [NotMapped]

        public string SeatStatus { get; set; }
        [NotMapped]

        public DateTime bookingdatetime { get; set; }


    }
    public class Row3
    {
        [NotMapped]
        public string SeatID { get; set; }
        [NotMapped]

        public int SeatNumber { get; set; }

        [NotMapped]

        public string SeatStatus { get; set; }
        [NotMapped]

        public DateTime bookingdatetime { get; set; }


    }
    public class Row4
    {
        [NotMapped]
        public string SeatID { get; set; }
        [NotMapped]

        public int SeatNumber { get; set; }

        [NotMapped]

        public string SeatStatus { get; set; }
        [NotMapped]

        public DateTime bookingdatetime { get; set; }


    }
    public class Row5
    {
        [NotMapped]
        public string SeatID { get; set; }
        [NotMapped]

        public int SeatNumber { get; set; }

        [NotMapped]

        public string SeatStatus { get; set; }
        [NotMapped]

        public DateTime bookingdatetime { get; set; }


    }


}
