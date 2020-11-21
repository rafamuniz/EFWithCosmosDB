using System;
using System.Collections.Generic;
using System.Text;

namespace EFCosmosDB.Entities
{
    public class Ship
    {
        public Guid Id { get; set; }
        public string ShipName { get; set; }
        public Planet Planet { get; set; }
        public Origin Origin { get; set; }
    }
}
