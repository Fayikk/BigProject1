using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{  //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {   //bu yapı ne demektir?
            //bir claası newlediğimizde o bellketen garbage collector belli zamanda gelir ve onu atar.
            //ancak using e yazınca iş bitince garbage collectore götürülür ve atılması sağlanır.
            //IDispossable pattern implementation of c#
            using (NorthwindContext context=new NorthwindContext())
            {
                var addedEntity =context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        
        public Product Get(Expression<Func<Product, bool>> filter )
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }
        //default olarak null bir filtre değeri ataması yaptık.
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //arka planda aşağıdaki kod bize select * from product değerini döndürecektir.
                //Burada filtre null'mı diye kontrol ediyoruz değilse==
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
                //eğer değil null değişlse aşağıdaki kodun geçerli olmasını istiyoruz.
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
