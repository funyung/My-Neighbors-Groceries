using System.Runtime.InteropServices;

namespace MyNeighbor
{
	internal class Program
	{
		const int STARTUP_STATE = 0;
		const int ABOUT_STATE = 1;
		const int DRAW_STATE = 2;
		const int INPUT_STATE = 3;
		const int SHUTDOWN_STATE = 4;
		const int EXIT_STATE = 5;

		static void Main(string[] args)
		{
			FrameBuffer frame = new FrameBuffer();
			Grocery inventory = new Grocery();

			int programState = STARTUP_STATE;
			int lastState = STARTUP_STATE;

			var isWindows = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
			if(isWindows)
				Console.SetWindowSize(129, 60);

			while (programState != EXIT_STATE)
			{
				if (frame.needsUpdate)
					frame.OutputImage();

				switch (programState)
				{
					case STARTUP_STATE:
						ConsoleKeyInfo userInput = Console.ReadKey();

						if (userInput.Key == ConsoleKey.Q)
						{
							programState = SHUTDOWN_STATE;
							frame.userQuitConfirmation = true;
							frame.needsUpdate = true;
						}
						else
						if (userInput.Key == ConsoleKey.S)
						{
							programState = DRAW_STATE;
							frame.ClearTextOverlays();
							frame.needsUpdate = true;
						}
						else
						if (userInput.Key == ConsoleKey.A)
						{
							/*gameState = ABOUT_STATE;
							frame.ClearTextOverlays();
							frame.needsUpdate = true;*/
						}

						lastState = programState;
						break;

					case ABOUT_STATE:
						break;

					case DRAW_STATE:
						frame.SetBackground(new Background("gfx/egg.png")); //TEST
						frame.SetMessage( "I'm not sure what to think, I've lived by them for three years and have never seen them bring something back from a grocery trip. It's the oddest thing because I walk my dog at all hours of the day... [newline] " + 
											"If they are buying groceries what do you think they might buy?");

						lastState = programState;
						programState = INPUT_STATE;
						break;

					case INPUT_STATE:
						Console.BackgroundColor = ConsoleColor.Black;
						Console.ForegroundColor = ConsoleColor.Green;

						if (inventory.SearchProducts(Console.ReadLine()))
						{
							var product = inventory.GetFoundProduct();
							frame.SetBackground(product.Image);
							frame.SetMessage(product.Response);
							frame.AddTextOverlay(product.TextOverlay, 50, 20);
						}
						else
						{
							frame.ClearTextOverlays();
							programState = DRAW_STATE;
						}

						lastState = programState;
						break;

					case SHUTDOWN_STATE:
						Console.BackgroundColor = ConsoleColor.Black;
						Console.ForegroundColor = ConsoleColor.Red;

						ConsoleKeyInfo exitInput = Console.ReadKey();
						if (exitInput.Key == ConsoleKey.Y)
						{
							Console.Clear();
							programState = EXIT_STATE;
						}
						else
						if (exitInput.Key == ConsoleKey.N)
						{
							programState = lastState;
							frame.userQuitConfirmation = false;
							frame.needsUpdate = true;
						}
						break;
				}
			}

			Environment.Exit(0);
		}
	}
}