using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class BaseModel
    {
        public int ID { get; set; }
        public string ContentType { get; set; }
        public string Author { get; set; }
        public DateTime? _DCDateCreated { get; set; }
        public DateTime? _DateModified { get; set; }
        public string Editor { get; set; }
    }
}
