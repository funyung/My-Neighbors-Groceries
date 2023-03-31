namespace MyNeighbor
{
	/// <summary>
	/// Static class for building a dictionary for specific product strings to generic product classes
	/// </summary>
	public static class ProductCatalog
	{
		private static Dictionary<string, string> _products;

		static ProductCatalog()
		{
			_products = new Dictionary<string, string>();
		}

		public static Dictionary<string, string> BuildCatalog()
		{
			//Beans
			_products.Add("beans", "beans");
			_products.Add("baked beans", "beans");
			_products.Add("black beans", "beans");
			_products.Add("pinto beans", "beans");
			_products.Add("chickpeas", "beans");
			_products.Add("garbonzo beans", "beans");
			_products.Add("black eyed peas", "beans");
			_products.Add("blackeyed peas", "beans");
			_products.Add("cannellini beans", "beans");
			_products.Add("lima beans", "beans");
			_products.Add("kidney beans", "beans");
			_products.Add("navy beans", "beans");
			_products.Add("edamame", "beans");
			_products.Add("mung beans", "beans");

			//Bread
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

			//Butter
			_products.Add("butter", "butter");
			_products.Add("dairy free butter", "butter");
			_products.Add("vegan butter", "butter");
			_products.Add("margarine", "butter");

			//Candy
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
			_products.Add("pez despensers", "candy");
			_products.Add("payday", "candy");
			_products.Add("airheads", "candy");
			_products.Add("tootsie pops", "candy");

			//Cheese
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

			//Chocolate
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

			//Coffee
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

			//Egg
			_products.Add("eggs", "egg");
			_products.Add("grade a eggs", "egg");
			_products.Add("brown eggs", "egg");
			_products.Add("white eggs", "egg");
			_products.Add("fertalized eggs", "egg");
			_products.Add("jumbo eggs", "egg");
			_products.Add("organic eggs", "egg");

			//Fish
			_products.Add("salmon", "fish");
			_products.Add("tuna", "fish");
			_products.Add("canned tuna", "fish");
			_products.Add("ahi tuna", "fish");
			_products.Add("tuna steaks", "fish");
			_products.Add("swordfish", "fish");
			_products.Add("oysters", "fish");
			_products.Add("crabs", "fish");
			_products.Add("lobsters", "fish");

			//Fruit
			_products.Add("fruits", "fruit");
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

			//Juice
			_products.Add("apple juice", "juice");
			_products.Add("orange juice", "juice");
			_products.Add("pineapple juice", "juice");
			_products.Add("cranberry juice", "juice");
			_products.Add("lemonade", "juice");
			_products.Add("limeade", "juice");
			_products.Add("minute maid", "juice");

			//Meat
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

			//Milk
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

			//Pizza
			_products.Add("pizza", "pizza");
			_products.Add("frozen pizzas", "pizza");
			_products.Add("tombstone pizzas", "pizza");
			_products.Add("digiornos pizzas", "pizza");
			_products.Add("red barron pizzas", "pizza");
			_products.Add("california pizza kitchen", "pizza");
			_products.Add("pizza rolls", "pizza");
			_products.Add("totinos pizza rolls", "pizza");
			_products.Add("pizza hot pockets", "pizza");

			//Soda
			_products.Add("sodas", "soda");
			_products.Add("pops", "pop");
			_products.Add("soda pops", "soda");
			_products.Add("cokes", "soda");
			_products.Add("diet cokes", "soda");
			_products.Add("pepsi", "soda");
			_products.Add("diet pepsi", "soda");
			_products.Add("mountain dews", "soda");
			_products.Add("baja blast", "soda");
			_products.Add("big reds", "soda");
			_products.Add("root beers", "soda");
			_products.Add("aw root beers", "soda");
			_products.Add("ale 8", "soda");
			_products.Add("7up", "soda");
			_products.Add("rc", "soda");
			_products.Add("dr peppers", "soda");
			_products.Add("sprites", "soda");
			_products.Add("fantas", "soda");
			_products.Add("sunkists", "soda");
			_products.Add("red bulls", "soda");
			_products.Add("monsters", "soda");
			_products.Add("monster energy drinks", "soda");
			_products.Add("jarritos", "soda");
			_products.Add("seltzers", "soda");
			_products.Add("seltzer waters", "soda");
			_products.Add("lemon seltzers", "soda");
			_products.Add("lime seltzers", "soda");
			_products.Add("club sodas", "soda");

			//Vegetable
			_products.Add("vegetables", "vegetable");
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

			return _products;
		}
	}
}
