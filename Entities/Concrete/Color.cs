﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;


namespace Entities.Concrete
{
   public class Color:IEntity
    {
        public int ColorID { get; set; }
        public string ColorName { get; set; }
    }
}
