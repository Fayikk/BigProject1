using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{  //NuGet
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {

            //Şimdi bir JOIN yazalım
            using (NorthwindContext context = new NorthwindContext())
            {
                //ürünler ile kategorileri join et demek anlamına gelmektedir.
                var result = from p in context.Products
                             join c in context.Categories
                             //p'deki categoryıd ile c'deki CategoryId eşit ise 
                             //eşitlik ifadesi (=) equals şeklinde yazılmaktadır.
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();

            }
        }
    }
}
