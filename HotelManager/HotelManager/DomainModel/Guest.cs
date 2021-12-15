using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DomainModel
{
    public class Guest
    {
        public int ID { get; set; }
        public String DocumentType { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String PicturePath { get; set; }

    }
}
