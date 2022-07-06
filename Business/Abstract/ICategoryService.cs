using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //Category ile ilgili dış dünyay neyi servis etmek istiyorsam onları yazıyorum.
        List<Category> GetAll();
        Category GetById(int categoryId);
     }
}
