using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //İstersen data ve message ver
        public ErrorDataResult(T data, string message) : base(data, false, message)

        {

        }
        //istersen sadece data ver
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //istersen message ver
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //istersen hiçbirşey verme,kurumsal bir mimaride her olasılık kurum için düşünülmelidir.
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
