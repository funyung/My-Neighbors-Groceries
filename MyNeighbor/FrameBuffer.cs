/* Description:
 * Takes background and overlay graphics, and outputs it to the console with a UI under it for questions and user input
 */
using System;

namespace MyNeighbor
{
    public class FrameBuffer
	{
		static string White		= "  ";
		static string LightGrey	= "░░";
		static string Grey		= "▒▒";
		static string DarkGrey	= "▒▒";
		static string Black		= "██";

		private Background currentBackground;
		private ImageOverlay? currentOverlay;
		private int[,] userInterfaceBackground;

		private TextMessage currentMessage;

		private int lastCursorX;
		private int lastCursorY;

		public bool needsUpdate;

		public FrameBuffer()
		{
			//Set Title Screen
			currentBackground = new Background("gfx/0bg_title.png");
			userInterfaceBackground = PngLoader.LoadUI("gfx/0bg_ui.png");

			//Testing TextMessage line length
			currentMessage = new TextMessage("Have you seen my neighbor? It seems like they never bring in any groceries...1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111");

			needsUpdate = true;

		}

		public void OutputImage()
		{
			Draw(currentBackground.GetImageData(), true);

			Draw(userInterfaceBackground, true);

			if (currentOverlay != null)
			{
				Draw(currentOverlay.GetImageData(), false, currentOverlay.GetPositionX(), currentOverlay.GetPositionY());
				currentOverlay.HasBeenDrawn= true; //TODO: Will not work on multiple draws of the same frame
			}

			currentMessage.Write();

			//TODO: Remove when actually handling user input
			Console.SetCursorPosition(0, 0);

			needsUpdate = false;
		}

		public void SetBackground(Background background)
		{
			currentBackground = background;
			needsUpdate = true;
		}

		public void SetOverlay(ImageOverlay overlay)
		{
			currentOverlay = overlay;
			needsUpdate = true;
		}

		public void SetUI(int[,] ui)
		{
			userInterfaceBackground= ui;
			needsUpdate = true;
		}

		public void SetMessage(string message)
		{
			currentMessage.ChangeMessage(message);
		}

		public void Draw(int[,] imageData, bool consecutiveOutput, int x = 0, int y = 0)
		{
			for (int h = 0; h < imageData.GetLength(0); h++)
			{
				if (!consecutiveOutput)
				{
					Console.SetCursorPosition(x, y + h);
				}
					
				for (int w = 0; w < imageData.GetLength(1); w++)
				{
					Console.BackgroundColor = ConsoleColor.Gray;
					Console.ForegroundColor = ConsoleColor.Black;

					if (imageData[h, w] == 255)
						Console.Write(White);
					else
					if (imageData[h, w] == 205)
						Console.Write(LightGrey);
					else
					if (imageData[h, w] == 153)
						Console.Write(Grey);
					else
					if (imageData[h, w] == 101)
						Console.Write(DarkGrey);
					else
					if (imageData[h, w] == 50)
					{
						Console.BackgroundColor = ConsoleColor.DarkGray;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.Write(DarkGrey);
					}
					else
					if (imageData[h, w] == 0)
						Console.Write(Black);
				}
				Console.Write('\n');
			}

			if(!consecutiveOutput)
					Console.SetCursorPosition(lastCursorX, lastCursorY);
			else
			{ 
				lastCursorX = Console.GetCursorPosition().Left;
				lastCursorY = Console.GetCursorPosition().Top;
			}
		}
	}
}
