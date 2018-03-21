using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Images
{
    public class ImagesModel:BaseModel
    {
        public string NewsLookup { get; set; }
        public string Url { get; set; }
        public bool IsThumb { get; set; }
    }
}
