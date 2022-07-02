using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {   //referans tip  
        //projeyi başlatınca otomatik olarak bellekte bir ürün listesi oluşmasını istiyoruz
        //bu ifade için aklımıaza ne geliyor tabiki de constructer gelmektedir.

        List<Product> _products;
       //direk classın ismi yazan bir metod görürsek bilin ki bu o class'ın constructer'ıdır.

        public InMemoryProductDal()
        {  //projeyi çalıştırdığımız zaman otomatik olarak aşağıdaki constructer çalışacaktır.

            _products = new List<Product> { 
            
            new Product{ProductId=1,CategoryId=1,ProductName="Telefon",UnitPrice=50,UnitsInStock=40},
            new Product{ProductId=2,CategoryId=2,ProductName="Elma",UnitPrice=5,UnitsInStock=35},
            new Product{ProductId=3,CategoryId=2,ProductName="Armut",UnitPrice=4,UnitsInStock=60},
            new Product{ProductId=4,CategoryId=2,ProductName="Ayva",UnitPrice=6,UnitsInStock=42},
            new Product{ProductId=5,CategoryId=2,ProductName="Üzüm",UnitPrice=4,UnitsInStock=30},

            };
        }
        public void Add(Product product)
        {
            //yeni bir ürün geldiğinde Listenin içerisine kaydettiğimiz Product'ın constructerına metod oluşturarak
            //ekleme işlemini yapabiliriz.
            _products.Add(product);
        }

        public void Delete(Product product)

        {
            
            //LİNQ yöntemini kullanıyoruz. Language Integrated Query
            //singleordefault fonksiyonu ürünleri tek,tek bulmak için kullanılan bir fonksiyondur.
            //SingleOrDefault bir metoddur.
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
            
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {//Gönderdiğim ürün ıd'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName=product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.UnitsInStock=product.UnitsInStock;
            
        }
    }
}
