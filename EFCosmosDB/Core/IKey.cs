using System;
using System.Collections.Generic;
using System.Text;

namespace EFCosmosDB.Core
{
    public interface IKey<T>
    {
        public T Key { get; set; }
    }
}
