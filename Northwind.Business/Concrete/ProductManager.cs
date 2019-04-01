using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private EfProductDal _productDal;

        public ProductManager(EfProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            //Hata Yogurma islemi kesinlikle arayüze verilmez, business layerda yapilir,
            //Aksi kullanim SOLIDìn s sine aykiridir.
            //Business layerda DAL' hata mesajlari barindirilamaz
            //Ön Yüzde sadece hata kullanicinin anlayicagi sekilde gösterilr
            try
            {
                _productDal.Delete(product);
            }
            catch (Exception ex)
            {
                bool rethrow = false;
                //rethrow = BusinessLogicExceptionHandler.HandleExcetion(ref ex);
                if (rethrow)
                {
                    throw ex;
                }
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductByProductName(string productName)
        {
            //Dependies Programming: ToLower()
            //SQL Server is caseinsentive but, other not this
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
