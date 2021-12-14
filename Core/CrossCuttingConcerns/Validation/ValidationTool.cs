using Core.Utilities.Results.Abstract;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
       public static void Validate(IValidator validator,object entity)  //Parametre olarak bir entity ve bir IValidator alır
        {
            var context = new ValidationContext<object>(entity); //Verilen Entity'nin tipinde ve verilen entity ile çalışan bir Validasyon Context'i oluşturur.
            
            var result = validator.Validate(context);//Verilen içeriği validate işleminden geçirir ve sonucu verir.

            if (!result.IsValid) //is valid yani doğrulandı ise ancak bu koşulda ! kullanıldığı için doğrulanmadı ise
            {
                throw new ValidationException(result.Errors);
          
            }
        }

    }
}
