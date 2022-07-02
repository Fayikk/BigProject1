using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //bu benim product ile ilgili veritabanında yapacağım operasyanları
    //ayarlayan metodlara sahip interface'tir.
    //interface'in operasyonları publictir.
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetByCategory(int categoryId);



    }
}
