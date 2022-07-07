using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
       //İstersen data ve message ver
        public SuccessDataResult(T data,string message) : base(data, true, message)
       
        {

        }
        //istersen sadece data ver
        public SuccessDataResult(T data):base(data,true)
        {

        }
        //istersen message ver
        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        //istersen hiçbirşey verme,kurumsal bir mimaride her olasılık kurum için düşünülmelidir.
        public SuccessDataResult() : base(default,true)
        {

        }
    }  
}
