using Ninject.Modules;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolves.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            BusinessModule businessModule = this;
            businessModule.Bind<IProductService>().To<ProductManager>().InSingletonScope();
            businessModule.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            businessModule.Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            businessModule.Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }
    }
}
