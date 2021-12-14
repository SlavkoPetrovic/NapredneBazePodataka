﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DomainModel
{
    public class Room
    {
        public int ID { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public int PricePerNight { get; set; }
        public int NumberOfBeds { get; set; }
    }
}
