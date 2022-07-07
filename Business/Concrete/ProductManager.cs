using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Product product)
        {
            //business codes buaraya yazılır.
            if (product.ProductName.Length < 2)
            {                         //Antipattern kodlarımızda string ifadelirin içerisinde profesyonel stringler yazmalıyız.
                return new ErrorResult("Ürün ismi en az 2 karakter olmalıdır.")

            }
            _productDal.Add(product);
            //artık void olamdığı için döndürmemiz gerekecektir dolayısıyla return ile Resul() döndürmesi yapmış olduk.
            

            return new SuccessResult("Ürün eklendi");
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductId == productId);
        }

        public ProductManager(IProductDal productDal)
            {
                _productDal = productDal;
            }
        
    }
}
