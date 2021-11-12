using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;

namespace Entities.DTOs
{
   public class CarDetailDto:IDto
    {

        public int CarID { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }



    }
}
