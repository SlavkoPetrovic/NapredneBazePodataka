using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DomainModel
{
    public class Hotel
    {
        public String Name { get; set; }
        public String Location{ get; set; }
        public String Address { get; set; }
        public List<Person> Recepcionari { get; set; }
    }
}
