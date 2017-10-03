using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentRest
{
    public class Apartment
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public int PostalCode { get; set; }
        public int Size { get; set; }
        public int NoRoom { get; set; }
        public bool WashingMachine { get; set; }
        public bool Dishwasher { get; set; }

        public Apartment()
        {
            
        }

        public Apartment(int id, int price, string location, int postalCode, int size, int noRoom, bool washingMachine, bool dishwasher)
        {
            Id = id;
            Price = price;
            Location = location;
            PostalCode = postalCode;
            Size = size;
            NoRoom = noRoom;
            WashingMachine = washingMachine;
            Dishwasher = dishwasher;
        }
    }
}