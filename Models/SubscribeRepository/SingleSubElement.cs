using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SingleSubElement
    {
        public string UserID { get; set; }
        public int NewsID { get; set; }
        public bool Readed { get; set; }

        public SingleSubElement(SubscribeElementModel model)
        {
            UserID = model.Author;
            NewsID = model.NewsID;
            Readed = model.Readed;
        }

    }
}
