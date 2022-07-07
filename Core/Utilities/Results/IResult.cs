using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{//Temel voidler için başlangıç
    public interface IResult
    {  //get demek okumak için kullanılacaktır.
       //Yapmaya çalıştığın işlem başarılı ise true,başarısız ise false değerini döndürecektir.
        bool Success { get; }
        //Burada ise bool'dan farklı olarak mesaj iletimi yapacaktır.
        string  Message { get; }
    }
}
