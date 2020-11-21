using System;
using System.Collections.Generic;
using System.Text;

namespace EFCosmosDB.Entities
{
    public class Origin
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }
        public String Location { get; set; }
    }
}
