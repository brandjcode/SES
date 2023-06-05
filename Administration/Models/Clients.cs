using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Models
{
    public class Clients
    {
        public string ClientName { get; set; }

        //Must be unique
        //3 to 5 letter abbreviation for each client
        //[Unique]
        public string ClientID { get; set; }

        //grab from contacts list
        public string[] ClientContacts { get; set; }

    }
}
