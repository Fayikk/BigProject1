using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{   //T ile hangi tipi döndüreceğini bana söyle demektedir.
    public interface IDataResult<T>:IResult
    {  //T veri tipinden Data isimli bir değişken oluşturuyoruz.
        //T generic ifadelerimdir.Hangi tiple çalışacağımı belirtmem gerekecektir.
        //T de herhangi bir kısıtlama yoktur,yazamayız.
        T Data { get; }
   
    }
}
