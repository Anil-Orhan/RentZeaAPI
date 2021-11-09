using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
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
        public void Add(Color entity)
        {
            _colorDal.Add(entity);
            Console.WriteLine("{0} Color is Added with EF!", entity.ColorID);
        }

        public void Delete(Color entity)
        {
            _colorDal.Delete(entity);
            Console.WriteLine("{0} Brand is Deleted with EF!", entity.ColorID);
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
            Console.WriteLine("{0} Brand is Updated with EF!", entity.ColorID);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorID)
        {
            return _colorDal.Get(p => p.ColorID == colorID);
        }
    }
}
