using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{ //Order clasıımızın interface'ini oluşturduk.
    //IEntityReposityory ile içerisinde barındırdığı metodların kullanımını yapacaktır.

    public interface IOrderDal:IEntityRepository<Order>
    {

    }
}
