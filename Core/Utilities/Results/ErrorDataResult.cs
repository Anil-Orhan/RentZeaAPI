using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        //Data ve mesaj girilirse
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }

        //Sadece data girilirse
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //sadece mesaj girilirse
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //hiçbir bilgi girilmezse
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
