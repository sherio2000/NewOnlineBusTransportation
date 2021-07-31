﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Models
{
    public class Buses
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string BusNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }



    }
}
