using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Models
{
    public class UsersFeedback : TableEntity
    {
        public UsersFeedback() { }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CompanyID { get; set; }

        public string Feedback { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
