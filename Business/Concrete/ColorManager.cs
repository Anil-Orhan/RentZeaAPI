using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities;
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
            return new SuccessResult(Messages.Added);
        }

        public DataResult<Color> Delete(Color entity)
        {
            _colorDal.Delete(entity);
            Console.WriteLine("{0} Brand is Deleted with EF!", entity.ColorID);
            return new SuccessDataResult<Color>(Messages.Deleted);
        }

        public DataResult<Color> Update(Color entity)
        {
            _colorDal.Update(entity);
            Console.WriteLine("{0} Brand is Updated with EF!", entity.ColorID);
            return new SuccessDataResult<Color>(Messages.Updated);
        }

        public DataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.Listed);
        }

        public DataResult<Color> GetById(int colorID)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.ColorID == colorID));
        }
    }
}
