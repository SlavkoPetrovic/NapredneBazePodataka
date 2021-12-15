using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DomainModel
{
    class NeedsRelationship //dodati jos property ako treba nzm kako ce osmislite
    {
        public int ID { get; set; }
        public int DamagePrice { get; set; }
        public String ToDo { get; set; }
        public String Done { get; set; }
    }
}
