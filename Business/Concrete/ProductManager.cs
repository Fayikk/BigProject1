using Business.Abstract;
using Business.Constants;
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
        public IDataResult<List<Product>> GetAll()
        {
            //varsa iş kodları yazılacaktır 
            //yetkisi var mı?
           if (DateTime.Now.Hour == 22)
            {//Maintenance time=Bakım zamanı anlamına gelmektedir.
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);

            //bir iş sınıfı başka iş sınıflarını new'lemez.
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p=>p.CategoryId==id));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails()) ;
        }

        public IResult Add(Product product)
        {
            //business codes buaraya yazılır.
            if (product.ProductName.Length < 2)
            {   //Magic strings            //Antipattern kodlarımızda string ifadelirin içerisinde profesyonel stringler yazmalıyız.
               
                return new ErrorResult(Messages.ProductNameInvalid);

            }
            _productDal.Add(product);
            //artık void olamdığı için döndürmemiz gerekecektir dolayısıyla return ile Resul() döndürmesi yapmış olduk.
            

            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public ProductManager(IProductDal productDal)
            {
                _productDal = productDal;
            }
        
    }
}
