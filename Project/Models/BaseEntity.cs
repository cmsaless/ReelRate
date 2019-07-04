using System;
using System.Collections.Generic;
using System.Text;

namespace ReelRate.WebUI.Models
{
    public class BaseEntity
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
