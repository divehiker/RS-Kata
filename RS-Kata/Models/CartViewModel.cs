using System.Collections.Generic;

namespace RS_Kata.Models
{
	public class CartViewModel
	{
		public double Total { get; set; }
		public List<CartItemViewModel> CartItems { get; set; }

		public CartViewModel()
		{
			CartItems = new List<CartItemViewModel>();
		}

		public CartViewModel(Cart cart)
		{
			Total = cart.TotalCost;
			CartItems = new List<CartItemViewModel>();

			foreach (CartItem cartItem in cart.CartItems)
			{
				CartItems.Add(
					new CartItemViewModel
					{
						Price = cartItem.GetExtendedPrice(),
						Qty = cartItem.ItemQty,
						SKU = cartItem.Item.SKU
					}
				);
			}

		}

	}
}