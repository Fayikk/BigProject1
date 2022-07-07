using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{//Çıplak class kalmamalı bunu asla unutmayın nesnellik zaafiyeti yaratabilir.
    public class Result : IResult
    {
     

       
        public Result(bool success, string message):this(success) 
        {   //getter read only'dir ancak constructer içerisinde set edilebilir.
            Message = message; 
        }
        //Overload etme işlemi aşağıda gösterildiği şekilde yapılandırılır.
        public Result(bool success)
        {   //getter read only'dir ancak constructer içerisinde set edilebilir.

            Success = success;
        }
        public Result(string message)
        {   //getter read only'dir ancak constructer içerisinde set edilebilir.
            Message = message;

        }

        //IResult ınterfaceinde sadece getter kapsülü kullanıldığı için => lambda işareti kullanımı aşağıdaki şekilde kullanılmaktadır.
        public bool Success { get; }

        public string Message { get; }
    }
}
