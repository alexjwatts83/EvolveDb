﻿namespace EvolveDb.Domain
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
