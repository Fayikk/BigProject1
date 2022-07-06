using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            //Bu yapı ile constructer injection yapmış olduk.
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //Eğer var ise iş kodlarımızı yazacağız
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            //Aşağıdaki yapı şu anlmaa geliyor benim gönderdiğim kategori ıd,veritabanındaki kategori ıd'ye eşitmidir.
            //Yani 'c' ile bir where koşulu ekleyip veritabanında kontrolümüzü sağlıyoruz.
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
