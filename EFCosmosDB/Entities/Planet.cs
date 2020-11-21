using System;
using System.Collections.Generic;
using System.Text;

namespace EFCosmosDB.Entities
{
    public class Planet
    {
        public Guid Id { get; set; }
        public string PlanetName { get; set; }
    }
}
