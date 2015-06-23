using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test_task.Models;

namespace test_task.Repository
{
    public class GoodsRepository : Repository<Goods>, IGoods
    {
    }
}