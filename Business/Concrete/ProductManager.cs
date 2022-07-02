using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public List<Product> GetAll()
        {
            //varsa iş kodları yazılacaktır 
            //yetkisi var mı?
            return _productDal.GetAll();

            //bir iş sınıfı başka iş sınıflarını new'lemez.
        }
            public ProductManager(IProductDal productDal)
            {
                _productDal = productDal;
            }
        
    }
}
