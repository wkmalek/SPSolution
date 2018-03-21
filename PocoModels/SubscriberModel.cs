using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SubscriberModel:BaseModel
    {
        public string Category { get; set; }
        public bool AllCategories { get; set; }
    }
}
