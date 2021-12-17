using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DomainModel
{
    class ReservedRelationship //dodati jos property ako treba nzm kako ce osmislite
                               //U nekim verzijama clienta se veze pravile pomocu relationship klasa, kod nas to nije moguce ja mislim
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
