﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Delete(Brand brand);
    }
}
