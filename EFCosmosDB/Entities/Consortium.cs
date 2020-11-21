using System;
using System.Collections.Generic;
using System.Text;

namespace EFCosmosDB.Entities
{
    public class Consortium
    {
        public Consortium()
        {
            Ships = new List<Ship>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Ship> Ships { get; set; }
        public Origin Origin { get; set; }
    }
}
