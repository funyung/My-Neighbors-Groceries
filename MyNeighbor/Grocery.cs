/* Description:
 * Container class that handles dictionary calls for user input and links to instances of each product class
 */

namespace MyNeighbor
{
	class Grocery
	{
		private Dictionary<string, string> _productList;
		private List<Product> _products;
		private Product _currentFoundProduct;
		public string lastSearchedProduct;

		public Grocery()
		{
			_productList = ProductCatalogue.BuildCatalogue();
			_products = new List<Product>();

			_products.Add(new Eggs());
		}

		public bool SearchProducts( string input)
		{
			lastSearchedProduct = input;

			if( _productList.ContainsKey(input.ToLower()) )
			{
				string productId = _productList[input.ToLower()];

				foreach( var product in _products )
				{
					if ( product.ID == productId )
					{
						_currentFoundProduct = product;
						return true;
					}
				}
			}
			
			return false; 
		}

		public Product GetFoundProduct()
		{
			return _currentFoundProduct;
		}
	}
}
