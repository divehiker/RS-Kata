using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RS_Kata.Models;

namespace RS_Kata.Controllers
{
    public class CartController : BaseController
    {
        //
        // GET: /Cart/

        public ActionResult Index(CartViewModel model)
        {
            return View(model);
        }

		public ActionResult Scan(string items)
		{
			//create our cart
			Cart cart = new Cart();

			//items sku's are single chars - split the input string into them
			char[] skuList = items.ToCharArray();

			//loop through each sku and find it's item from the db
			foreach (char sku in skuList)
			{
				string strSku = sku.ToString().ToUpper();
				Item item = Db.GetItemBySKU(sku);

				//only process the item if it exists in the database
				if (item != null)
				{
					//if the sku is already in the cart - increase the qty
					if (cart.CartItems.Any(c => c.Item.SKU == strSku))
					{
						cart.CartItems.First(c => c.Item.SKU == strSku).ItemQty++;
					}
					else
					{
						//new sku for the cart - add it
						cart.CartItems.Add(new CartItem
							{
								Item = item,
								ItemQty = 1
							});
					}
				}
				//this is our helper method to apply the discounts to each item and update the cart total
				cart.UpdateCartTotal();
			}

			CartViewModel cartViewModel = new CartViewModel(cart);

			//send the user back to the cart index page where we can display the cart details.
			return View("Index", cartViewModel);
		}

    }
}
