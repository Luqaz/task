namespace test_task.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Ninject;
    using Ninject.Infrastructure;
    using Ninject.Modules;
    using test_task.Models;
    using test_task.Repository;


    public class AppModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IShop>().To<ShopRepository>();
            Bind<IGoods>().To<GoodsRepository>();
        }
    }
}