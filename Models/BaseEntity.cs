using System;

namespace MVC.Models
{
    public abstract class BaseEntity
    {
        public string ID { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public BaseEntity()
        {
            ID = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
        }
    }
}
