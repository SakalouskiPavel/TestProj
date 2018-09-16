using System;

namespace TestProj.Common.Models
{
    public class Entity
    {
        public long Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public long CreatorId { get; set; }

        public DateTime? LastUpdated { get; set; }

        public long? UpdaterId { get; set; }
    }
}