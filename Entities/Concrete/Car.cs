
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;

namespace Entities.Concrete
{
   public class Car:IEntity
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public int ColorID { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string FuelType { get; set; }
        public int Kilometer { get; set; }
        public string Transmission { get; set; }
        public bool AirConditioning { get; set; }
        public short EngineCapacity { get; set; }
        public string BodyStyles { get; set; }
        public bool Navigation { get; set; }
        public short MinDriverAge { get; set; }
        public short MinDrivingLicence { get; set; }
        public short DepositFee { get; set; }
        public string CarModel { get; set; }    

    }
}
