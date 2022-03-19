using Core.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInsuranceDal : EfEntityRepositoryBase<Insurance, CarDbContext>, IInsuranceDal
    {

    }
}