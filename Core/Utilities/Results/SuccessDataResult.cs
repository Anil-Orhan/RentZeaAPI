using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
   public class SuccessDataResult<T>:DataResult<T>
    {
        //Data ve mesaj girilirse
        public SuccessDataResult(T data,  string message) : base(data, true, message)
        {
        }

        //Sadece data girilirse
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        //sadece mesaj girilirse
        public SuccessDataResult(string message):base(default,true,message)
        {
            
        }
        //hiçbir bilgi girilmezse
        public SuccessDataResult():base(default,true)
        {
            
        }


    }
}
