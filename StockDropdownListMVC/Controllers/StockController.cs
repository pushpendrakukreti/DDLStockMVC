using StockDropdownListMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockDropdownListMVC.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult AddOrEdit(int id=0)
        {
            Stock stockModel = new Stock();

            using (dataModels dbModel = new dataModels())
            {
                if (id != 0)
                    stockModel = dbModel.Stocks.Where(x => x.Id==id).FirstOrDefault();
                stockModel.ProductCollection = dbModel.Products.ToList<Product>();
            }

            return View(stockModel);

            //stockModel.ProductCollection = new List<Product>()
            //{
            //    new Product()
            //    {
            //        ProductId=1,ProductName="Computer"
            //    },
            //    new Product()
            //    {
            //        ProductId=2,ProductName="Mobile"
            //    },
            //};
        }

        [HttpPost]
        public ActionResult AddOrEdit(Stock stock)
        {
            return View();
        }
    }
}