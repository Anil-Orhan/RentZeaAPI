using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;
using Entities.DTOs;

namespace DataAccess.Abstract
{
   public interface ICarDal:IEntityRepository<Car>
   {
       List<CarDetailDto> GetByCarDetail();
       CarDetailDto GetByCarDetailSingle(int carID);
        List<CarDetailDto> GetByBrand(int brandID);
       public List<CarDetailDto> GetByColor(int colorID);

   }
}
