using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
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

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public ProductManager(IProductDal productDal)
            {
                _productDal = productDal;
            }
        
    }
}
