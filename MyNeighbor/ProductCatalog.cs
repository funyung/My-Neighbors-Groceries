namespace MyNeighbor
{
	/// <summary>
	/// Static class for building dictionary for specific product strings to generic product classes
	/// </summary>
	public static class ProductCatalogue
	{
		private static Dictionary<string, string> _products;

		static ProductCatalogue()
		{
			_products = new Dictionary<string, string>();
		}

		public static Dictionary<string, string> BuildCatalogue()
		{
			//_products.Add("", "egg");
			_products.Add("eggs", "egg");
			_products.Add("grade a eggs", "egg");
			_products.Add("brown eggs", "egg");
			_products.Add("white eggs", "egg");
			_products.Add("fertalized eggs", "egg");
			_products.Add("jumbo eggs", "egg");
			_products.Add("organic eggs", "egg");

			//_products.Add("", "milk");
			_products.Add("milk", "milk");
			_products.Add("2 milk", "milk");
			_products.Add("vitamin d milk", "milk");
			_products.Add("milk gallon", "milk");
			_products.Add("chocolate milk", "milk");
			_products.Add("strawberry milk", "milk");
			_products.Add("almond milk", "milk");
			_products.Add("oat milk", "milk");
			_products.Add("soy milk", "milk");
			_products.Add("cashew milk", "milk");
			_products.Add("buttermilk", "milk");

			//_products.Add("", "butter");
			_products.Add("butter", "butter");
			_products.Add("dairy free butter", "butter");
			_products.Add("vegan butter", "butter");
			_products.Add("margarine", "butter");

			//_products.Add("", "cheese");
			_products.Add("cheese", "cheese");
			_products.Add("sprinkle cheese", "cheese");
			_products.Add("sliced cheese", "cheese");
			_products.Add("kraft cheese", "cheese");
			_products.Add("kraft cheese singles", "cheese");
			_products.Add("gouda cheese", "cheese");
			_products.Add("harvati cheese", "cheese");
			_products.Add("muenster cheese", "cheese");
			_products.Add("mozzarella", "cheese");
			_products.Add("mozzarella sticks", "cheese");
			_products.Add("brie", "cheese");
			_products.Add("cream cheese", "cheese");
			_products.Add("philadelphia cream cheese", "cheese");
			_products.Add("vegan cheese", "cheese");
			_products.Add("cheese whiz", "cheese");
			_products.Add("spray cheese", "cheese");
			_products.Add("easy cheese", "cheese");

			//_products.Add("", "bread");
			_products.Add("bread", "bread");
			_products.Add("sourdough", "bread");
			_products.Add("rolls", "bread");
			_products.Add("dinner rolls", "bread");
			_products.Add("kings hawaiian rolls", "bread");
			_products.Add("buns", "bread");
			_products.Add("hamburger buns", "bread");
			_products.Add("hotdog buns", "bread");
			_products.Add("challah", "bread");
			_products.Add("pan de muerto", "bread");
			_products.Add("bagels", "bread");
			_products.Add("english muffins", "bread");

			//_products.Add("", "fruit");
			_products.Add("apples", "fruit");
			_products.Add("oranges", "fruit");
			_products.Add("bananas", "fruit");
			_products.Add("watermelons", "fruit");
			_products.Add("melons", "fruit");
			_products.Add("honeydew", "fruit");
			_products.Add("honeydew melons", "fruit");
			_products.Add("grapes", "fruit");
			_products.Add("white grapes", "fruit");
			_products.Add("red grapes", "fruit");
			_products.Add("strawberries", "fruit");
			_products.Add("blueberries", "fruit");
			_products.Add("pears", "fruit");
			_products.Add("plums", "fruit");
			_products.Add("starfruits", "fruit");
			_products.Add("dragonfruits", "fruit");

			//_products.Add("", "vegetable");
			_products.Add("spinach", "vegetable");
			_products.Add("lettuce", "vegetable");
			_products.Add("kale", "vegetable");
			_products.Add("spring mix", "vegetable");
			_products.Add("collard greens", "vegetable");
			_products.Add("broccoli", "vegetable");
			_products.Add("cauliflower", "vegetable");
			_products.Add("asparagus", "vegetable");
			_products.Add("tomato", "vegetable");
			_products.Add("tomatoes", "vegetable");
			_products.Add("bell peppers", "vegetable");
			_products.Add("poblano peppers", "vegetable");
			_products.Add("jalopeno peppers", "vegetable");
			_products.Add("cherry peppers", "vegetable");
			_products.Add("red peppers", "vegetable");
			_products.Add("green peppers", "vegetable");
			_products.Add("yellow peppers", "vegetable");
			_products.Add("orange pepper", "vegetable");
			_products.Add("onions", "vegetable");
			_products.Add("green onions", "vegetable");
			_products.Add("carrots", "vegetable");
			_products.Add("baby carrots", "vegetable");
			_products.Add("radishes", "vegetable");

			//_products.Add("", "meat");
			_products.Add("turkey", "meat");
			_products.Add("sliced turkey", "meat");
			_products.Add("ham", "meat");
			_products.Add("sliced ham", "meat");
			_products.Add("ground beef", "meat");
			_products.Add("steak", "meat");
			_products.Add("ribeye", "meat");
			_products.Add("chuck roast", "meat");
			_products.Add("salami", "meat");
			_products.Add("chorizo", "meat");
			_products.Add("impossible meat", "meat");
			_products.Add("beyond beef", "meat");

			//_products.Add("", "juice");
			_products.Add("apple juice", "juice");
			_products.Add("orange juice", "juice");
			_products.Add("pineapple juice", "juice");
			_products.Add("cranberry juice", "juice");
			_products.Add("lemonade", "juice");
			_products.Add("limeade", "juice");
			_products.Add("minute maid", "juice");

			//_products.Add("", "soda");
			_products.Add("soda", "soda");
			_products.Add("pop", "pop");
			_products.Add("soda pop", "soda");
			_products.Add("coke", "soda");
			_products.Add("diet coke", "soda");
			_products.Add("pepsi", "soda");
			_products.Add("diet pepsi", "soda");
			_products.Add("mountain dew", "soda");
			_products.Add("baja blast", "soda");
			_products.Add("big red", "soda");
			_products.Add("root beer", "soda");
			_products.Add("aw root beer", "soda");
			_products.Add("ale 8", "soda");
			_products.Add("7up", "soda");
			_products.Add("rc", "soda");
			_products.Add("dr pepper", "soda");
			_products.Add("sprite", "soda");
			_products.Add("fanta", "soda");
			_products.Add("sunkist", "soda");
			_products.Add("red bull", "soda");
			_products.Add("monster", "soda");
			_products.Add("monster energy drink", "soda");
			_products.Add("jarritos", "soda");
			_products.Add("seltzer", "soda");
			_products.Add("seltzer water", "soda");
			_products.Add("lemon seltzer", "soda");
			_products.Add("lime seltzer", "soda");
			_products.Add("club soda", "soda");

			//_products.Add("", "coffee");
			_products.Add("coffee", "coffee");
			_products.Add("ground coffee", "coffee");
			_products.Add("whole bean coffee", "coffee");
			_products.Add("instant coffee", "coffee");
			_products.Add("chock full o nuts", "coffee");
			_products.Add("starbucks", "coffee");
			_products.Add("starbucks coffee", "coffee");
			_products.Add("starbucks frappuccino", "coffee");
			_products.Add("cafe bustelo", "coffee");
			_products.Add("cafe bustelo instant coffee", "coffee");


			//_products.Add("", "pizza");
			_products.Add("pizza", "pizza");
			_products.Add("frozen pizza", "pizza");
			_products.Add("tombstone pizza", "pizza");
			_products.Add("digiornos pizza", "pizza");
			_products.Add("red barron pizza", "pizza");
			_products.Add("california pizza kitchen", "pizza");
			_products.Add("pizza rolls", "pizza");
			_products.Add("totinos pizza rolls", "pizza");
			_products.Add("pizza hot pockets", "pizza");

			//_products.Add("", "chocolate");
			_products.Add("chocolates", "chocolate");
			_products.Add("white chocolates", "chocolate");
			_products.Add("dark chocolates", "chocolate");
			_products.Add("hershey bars", "chocolate");
			_products.Add("hersheys", "chocolate");
			_products.Add("hersheys chocolate", "chocolate");
			_products.Add("reeses", "chocolate");
			_products.Add("reeses cups", "chocolate");
			_products.Add("reeses pieces", "chocolate");
			_products.Add("kitkats", "chocolate");
			_products.Add("kitkat bars", "chocolate");
			_products.Add("twix", "chocolate");
			_products.Add("3musketeers", "chocolate");
			_products.Add("3 musketeers", "chocolate");
			_products.Add("kisses", "chocolate");
			_products.Add("bueno", "chocolate");
			_products.Add("almond joy", "chocolate");
			_products.Add("mounds", "chocolate");
			_products.Add("mounds bars", "chocolate");
			_products.Add("crunch bars", "chocolate");
			_products.Add("mms", "chocolate");
			_products.Add("peanut mms", "chocolate");
			_products.Add("sno caps", "chocolate");


			//_products.Add("", "candy");
			_products.Add("nerds", "candy");
			_products.Add("nerds rope", "candy");
			_products.Add("twizzlers", "candy");
			_products.Add("swedish fish", "candy");
			_products.Add("dots", "candy");
			_products.Add("gushers", "candy");
			_products.Add("skittles", "candy");
			_products.Add("sour patch kids", "candy");
			_products.Add("starbursts", "candy");
			_products.Add("hot tamales", "candy");
			_products.Add("sweetarts", "candy");
			_products.Add("sweet tarts", "candy");
			_products.Add("goodplenty", "candy");
			_products.Add("good plenty", "candy");
			_products.Add("good and plenty", "candy");
			_products.Add("mike and ike", "candy");
			_products.Add("mike and ikes", "candy");
			_products.Add("pez despenser", "candy");
			_products.Add("payday", "candy");
			_products.Add("airheads", "candy");
			_products.Add("tootsie pop", "candy");


			return _products;
		}
	}
}
