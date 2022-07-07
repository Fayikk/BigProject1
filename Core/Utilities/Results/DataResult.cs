using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{  //Result'ı inherit ediyoruz.Fakat IDataResult ise bir interface olduğundan 
    //implemente edilmesi gerekmektedir.
    public class DataResult<T> : Result, IDataResult<T>
    {
        //ctor yazıp iki kere ard arda tab tuşuna basarsak eğer constructer crate etmek içinkısayol oluşturmuş olacağız.

        public DataResult(T data,bool success,string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
