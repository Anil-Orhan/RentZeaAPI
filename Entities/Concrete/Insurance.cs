using Core.Abstract;

namespace Entities.Concrete
{
    public class Insurance : IEntity
    {
        public int InsuranceId { get; set; }
        public string InsuranceName { get; set; }
        public decimal InsuranceDailyPrice { get; set; }
        public string InsuranceDescription{ get; set; }
    }
}