using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{  //Entityframework kullanarak bir repository base oluştur demek
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        //Buraya yazacağın objenin kuralları şöyle olabilir.
       //yani hertürli class açmamız engellenmiş olacaktır.
       //Özellikleri belli olan classlar ile işlem görmemiz sağlanacaktır.
        where TEntity:class,IEntity,new()
        where TContext : DbContext,new()
    
    {
        public void Add(TEntity entity)
        {   //bu yapı ne demektir?
            //bir claası newlediğimizde o bellketen garbage collector belli zamanda gelir ve onu atar.
            //ancak using e yazınca iş bitince garbage collectore götürülür ve atılması sağlanır.
            //IDispossable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        //default olarak null bir filtre değeri ataması yaptık.
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //arka planda aşağıdaki kod bize select * from product değerini döndürecektir.
                //Burada filtre null'mı diye kontrol ediyoruz değilse==
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
                //eğer değil null değişlse aşağıdaki kodun geçerli olmasını istiyoruz.
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
