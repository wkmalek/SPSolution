﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public interface ICategoryRepository<T>:IRepository<T> where T:class
    {

    }
}
