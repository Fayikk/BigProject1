using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        //benim veritabanım tam olarak şurada demem gerekiyor
        //onconfiguring ile benim projem hangi veritabanı ile ilişkili onu belirtmemize yarayan bir metodtur.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sql servera nasıl bağlanacağımı belirtmem yeterlidir.
            //connection string giriyoruz.
            //string ifadeler içerisine sql serverımızın nerede olduğunu söyleyelim.
           
           
        }
        public int MyProperty { get; set; }
    }
}
