using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {   //Constructer 
        public SuccessResult(string message) : base(true, message)
        {

        }
        //default değer tavsiye edilmez.API de kullanan kişi defaılt değeri görünce karar vermekte zorlanabilir.
        //mesaj vermek istemiyor olabilirdi
       //parametresiz olmasına rağmen true değerini defaıl olarak atamasını yaptık.
        public SuccessResult() : base(true)
        {

        }
    }
}
