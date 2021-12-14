using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DomainModel
{
    public class Person //radnici i recepcionari za menadzera ne mora da se pravi klasa i acc za gosta posebna klasa 
                        // samo vodite racuna da je to ipak node person u bazi
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Job { get; set; }
    }
}
