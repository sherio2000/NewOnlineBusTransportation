using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBusTransportation.Models
{
    public class StaffViewModel
    {
        public string ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string password { get; set; }

        public string Roles { get; set; }
        public class GroupedUserViewModel
        {
            public List<StaffViewModel> staff { get; set; }
        }

       
    }
}
