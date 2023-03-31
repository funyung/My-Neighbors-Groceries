using System.Text;
using System.Text.RegularExpressions;

namespace MyNeighbor
{
	/// <summary>
	/// Container class that handles dictionary calls for user input and links to instances of each product class
	/// </summary>
	class Grocery
	{
		private Dictionary<string, string> _productList;
		private List<Product> _products;
		private Product _currentFoundProduct;
		public string lastSearchedProduct;

		public Grocery()
		{
			_productList = ProductCatalog.BuildCatalog();
			_products = new List<Product>();

			_products.Add(new Beans());
			_products.Add(new Bread());
			_products.Add(new Butter());
			_products.Add(new Candy());
			_products.Add(new Cheese());
			_products.Add(new Chocolate());
			_products.Add(new Coffee());
			_products.Add(new Eggs());
			_products.Add(new Fish());
			_products.Add(new Fruit());
			_products.Add(new Juice());
			_products.Add(new Meat());
			_products.Add(new Milk());
			_products.Add(new Pizza());
			_products.Add(new Soda());
			_products.Add(new Vegetable());
		}

		public bool SearchProducts(string input)
		{
			lastSearchedProduct = input;

			var inputNoPunctuation = Regex.Replace(input.ToLower(), @"\p{P}", "");
			var splitInput = inputNoPunctuation.Split(' ');
			string comparedInput = inputNoPunctuation;

			if (splitInput.First() == "a"||
				splitInput.First() == "an" ||
				splitInput.First() == "some" ||
				splitInput.First() == "the")
			{
				StringBuilder removeFirstWord = new StringBuilder();
				foreach (string value in splitInput)
				{
					if (value != splitInput.First())
					{
						removeFirstWord.Append(value);

						if (value != splitInput.Last())
							removeFirstWord.Append(' ');
					}
				}
				comparedInput = removeFirstWord.ToString();
			}

			if (_productList.ContainsKey(comparedInput + "s"))
				comparedInput += "s";

			if (_productList.ContainsKey(comparedInput))
			{
				string productId = _productList[comparedInput];

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
