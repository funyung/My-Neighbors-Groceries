namespace MyNeighbor
{
	internal class Program
	{
		const int STARTUP_STATE = 0;
		const int ABOUT_STATE = 1;
		const int RUNNING_STATE = 2;
		const int INPUT_STATE = 3;
		const int SHUTDOWN_STATE = 4;
		const int EXIT_STATE = 5;

		static void Main(string[] args)
		{
			FrameBuffer frame = new FrameBuffer();
			int gameState = STARTUP_STATE;

			Console.SetWindowSize(129, 60);

			while (gameState != SHUTDOWN_STATE)
			{
				if (frame.needsUpdate)
					frame.OutputImage();

				switch (gameState)
				{
					case STARTUP_STATE:
						ConsoleKeyInfo userInput = Console.ReadKey();

						if (userInput.Key == ConsoleKey.Escape)
						{
							gameState = SHUTDOWN_STATE;
						}
						else
						if (userInput.Key == ConsoleKey.Spacebar)
						{
							gameState = RUNNING_STATE;
							frame.ClearTextOverlays();
							frame.needsUpdate = true;
						}
						else
						if (userInput.Key == ConsoleKey.F1)
						{
							gameState = ABOUT_STATE;
							frame.ClearTextOverlays();
							frame.needsUpdate = true;
						}


						break;

					case ABOUT_STATE:
						break;

					case RUNNING_STATE:
						frame.SetBackground(new Background("gfx/egg.png"));
						frame.SetMessage( "I'm not sure what to think, I've lived by them for three years and have never seen them bring something back from a grocery trip. It's the oddest thing because I walk my dog at all hours of the day... [newline] " + 
											"If they are buying groceries what do you think they might buy?");

						gameState = INPUT_STATE;

						break;
					case INPUT_STATE:
						Console.BackgroundColor = ConsoleColor.Black;
						Console.ForegroundColor = ConsoleColor.Green;
						Console.ReadLine();
						break;
				}

				Console.Clear();
			}

			Environment.Exit(0);
		}
	}
}