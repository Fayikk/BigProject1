using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{ //Order'ı ilgilendiren bütün sql operasyonlarım artık kullanıma hazırdır.
    public class EfOrderDal: EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {

    }
}
