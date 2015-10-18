using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RS_Kata.Controllers
{
    public class CartController : BaseController
    {
        //
        // GET: /Cart/

        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Scan(string items)
		{

			Cart cart = new Cart();
			char[] skuList = items.ToCharArray();

			foreach (char sku in skuList)
			{
				Item item = Db.GetItemBySKU(sku);
				string strSku = sku.ToString().ToUpper();

				if (cart.CartItems.Any(c => c.Item.SKU == strSku))
				{
					cart.CartItems.First(c => c.Item.SKU == strSku).ItemQty++;
				}
				else
				{
					cart.CartItems.Add(new CartItem
						{
							Item = item,
							ItemQty = 1
						});
				}
				
				cart.UpdateCartTotal();
			}

			return RedirectToAction("Index");
		}

    }
}
