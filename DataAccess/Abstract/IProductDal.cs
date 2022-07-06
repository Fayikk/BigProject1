using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
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
    public interface IProductDal:IEntityRepository<Product>
    {
        //ProductDal'a özgü join işlemi yazacağız şimdi.
        List<ProductDetailDto> GetProductDetails();
    }
}


//Code Refactoring