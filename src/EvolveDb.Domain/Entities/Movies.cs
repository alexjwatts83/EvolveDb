using System;

namespace EvolveDb.Domain
{
    public class Movies : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public string Starring { get; set; }

        public DateTime Premiere { get; set; }
    }
}
