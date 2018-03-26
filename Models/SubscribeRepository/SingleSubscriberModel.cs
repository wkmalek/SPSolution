using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SingleSubscriberModel
    {
        public string Category { get; set; }
        public bool AllCategories { get; set; }
        public string UserID { get; set; }
        public DateTime? SubscribeDate { get; set; }

        public SingleSubscriberModel(SubscriberModel model)
        {
            Category = model.Category;
            AllCategories = model.AllCategories;
            UserID = model.Author;
            SubscribeDate = model._DCDateCreated;
        }


    }
}
