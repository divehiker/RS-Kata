using System.Linq;

namespace RS_Kata.DAL
{
	public class Repository
	{
		private readonly DataEntitiesContainer context;


		public Repository()
		{
			context = new DataEntitiesContainer();
		}

		public Item GetItemBySKU(char sku)
		{
			string skuStr = sku.ToString();
			return context.Items.Where(i => i.SKU == skuStr).First();
		}

	}
}