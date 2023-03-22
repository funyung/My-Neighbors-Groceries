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
			int programState = STARTUP_STATE;
			int lastState = STARTUP_STATE;

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
							lastState = programState;
							programState = SHUTDOWN_STATE;
							frame.userQuit = true;
							frame.needsUpdate = true;
						}
						else
						if (userInput.Key == ConsoleKey.S)
						{
							programState = RUNNING_STATE;
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
						break;

					case ABOUT_STATE:
						break;

					case RUNNING_STATE:
						frame.SetBackground(new Background("gfx/egg.png")); //TEST
						frame.SetMessage( "I'm not sure what to think, I've lived by them for three years and have never seen them bring something back from a grocery trip. It's the oddest thing because I walk my dog at all hours of the day... [newline] " + 
											"If they are buying groceries what do you think they might buy?");

						lastState = programState;
						programState = INPUT_STATE;
						break;

					case INPUT_STATE:
						Console.BackgroundColor = ConsoleColor.Black;
						Console.ForegroundColor = ConsoleColor.Green;
						Console.ReadLine();
						//TODO: Interact with Grocery class to search for user input for keys in it's dictionary of products.

						lastState = programState;
						break;

					case SHUTDOWN_STATE:
						ConsoleKeyInfo exitInput = Console.ReadKey();

						if (exitInput.Key == ConsoleKey.Y)
							programState = EXIT_STATE;
						else
						if (exitInput.Key == ConsoleKey.N)
						{
							programState = lastState;
							frame.userQuit = false;
							frame.needsUpdate = true;
						}
						break;
				}
			}

			Environment.Exit(0);
		}
	}
}