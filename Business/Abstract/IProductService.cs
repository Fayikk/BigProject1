using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {  //mETODLARI VERİTABANINA otomatik işlem yapmasını sağlayacak şekilde bağladığımıza göre
        //artık istediğim metdoları şekillendirebilirim.
        List<Product> GetAll();
        //kategori ıd'sine göre getiren operasyonu yazıyoruz.
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min,decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId);
        IResult Add(Product product);
    }
}
