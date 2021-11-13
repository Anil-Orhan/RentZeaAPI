using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class ColorManager:IColorManager
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color entity)
        {
            _colorDal.Add(entity);
            Console.WriteLine("{0} Color is Added with EF!", entity.ColorID);
            return new SuccessResult();
        }

        public IDataResult<Color> Delete(Color entity)
        {
            _colorDal.Delete(entity);
            Console.WriteLine("{0} Brand is Deleted with EF!", entity.ColorID);
            return new SuccessDataResult<Color>();
        }

        public IResult Update(Color entity)
        {
            _colorDal.Update(entity);
            Console.WriteLine("{0} Brand is Updated with EF!", entity.ColorID);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorID)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.ColorID == colorID));
        }
    }
}
