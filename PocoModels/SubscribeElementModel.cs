using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SubscribeElementModel:BaseModel
    {
        public string UserID { get; set; }
        public string NewsID { get; set; }
        public bool Readed { get; set; }
    }
}
