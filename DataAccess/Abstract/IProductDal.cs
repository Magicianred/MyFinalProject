using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //GetAll :Hepsini Getir demek.//
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Uptate(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);
    }
}
