using EFCosmosDB.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace EFCosmosDB.Entities
{
    public class Tenant : BaseEntity<Guid>
    {
        public Tenant()
           : base()
        {

        }

        public String Name { get; set; }

        public String DatabaseName { get; set; }
    }
}
