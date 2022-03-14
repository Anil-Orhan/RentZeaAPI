using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
   public interface ICarManager:IManagerService<Car>
   {
       public DataResult<List<CarDetailDto>> GetByCarDetails();
       public DataResult<CarDetailDto> GetByCarDetail(int carID);
        public DataResult<List<CarDetailDto>> GetByBrand(int brandID);
       public DataResult<List<CarDetailDto>> GetByColor(int colorID);

    }
}
