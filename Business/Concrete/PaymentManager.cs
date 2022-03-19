using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class PaymentManager:IPaymentService
    {
        public DataResult<Rental> Pay(Rental rental)
        {
            return new SuccessDataResult<Rental>("İşlem Başarılı");
        }
    }
}
