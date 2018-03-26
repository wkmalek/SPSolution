using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SubscribeElementModel:BaseModel
    {
        public string UserID { get; set; }
        public int NewsID { get; set; }
        public bool Readed { get; set; }
    }
}
