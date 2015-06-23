using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_task.Models;
using test_task.Repository;

namespace test_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShop shopRepository;
        private readonly IGoods goodsRepository;

        public HomeController()
        {
        }

        public HomeController(IShop shop, IGoods goods)
        {
            this.shopRepository = shop;
            this.goodsRepository = goods;
        }

        public ActionResult Index()
        {
            return View(shopRepository.GetAll());
        }
        public ActionResult GetGoods(int id)
        {
            ViewBag.ID = id;
            return PartialView(goodsRepository.FindAllBy(m => m.ShopID == id));
        }
        public ActionResult AddShop()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddShop(Shop shop)
        {
            shopRepository.Create(shop);
            shopRepository.Save();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AddGoods(int id)
        {
            ViewBag.ID = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddGoods(Goods goods)
        {
            goodsRepository.Create(goods);
            goodsRepository.Save();
            return RedirectToAction("Index", "Home");
        }
    }
}
