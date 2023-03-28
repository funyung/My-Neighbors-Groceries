/* Description:
 * Static class for building dictionary for specific product strings to generic product classes
 */

namespace MyNeighbor
{
	public static class ProductCatalogue
	{
		private static Dictionary<string, string> _products;

		static ProductCatalogue()
		{
			_products = new Dictionary<string, string>();
		}

		public static Dictionary<string, string> BuildCatalogue()
		{
			_products.Add("eggs", "egg");
			_products.Add("egg", "egg");
			_products.Add("grade a eggs", "egg");
			_products.Add("brown eggs", "egg");
			_products.Add("white eggs", "egg");
			_products.Add("fertalized eggs", "egg");
			_products.Add("jumbo eggs", "egg");
			_products.Add("organic eggs", "egg");

			
			return _products;
		}
	}
}
