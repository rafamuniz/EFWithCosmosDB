using EFCosmosDB.Core;
using System;

namespace EFCosmosDB.Entities
{
    public abstract class BaseEntity<TKey> : IKey<TKey>
    {
        public BaseEntity()
        {
            //Type listType = typeof(TKey);
            //if (listType == typeof(Guid))
            //{

            //    Key = new Guid();
            //}
        }

        public TKey Key { get; set; }
    }
}
