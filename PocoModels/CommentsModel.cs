﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocoModels
{
    public class CommentsModel:BaseModel
    { 
        public string CommentBody { get; set; }
        public int NewsLookup { get; set; }
        public string Title { get; set; }
    }
}
