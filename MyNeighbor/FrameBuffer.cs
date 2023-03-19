/* Description:
 * Takes background and overlay graphics, and outputs it to the console with a UI under it for questions and user input
 */
namespace MyNeighbor
{
    public class FrameBuffer
	{
		static string White		= "  ";
		static string LightGrey	= "░░";
		static string Grey		= "▒▒";
		static string DarkGrey	= "▒▒";
		static string Black		= "██";

		public const int MAX_SCREENSPACE_X = 128;
		public const int MAX_SCREENSPACE_Y = 64;
		public const int MAX_TEXT_OVERLAY_LENGTH = 32;
		public const int USER_INTERFACE_ORIGIN_X = 8;
		public const int USER_INTERFACE_ORIGIN_Y = 48;

		private Background Background;
		private Overlay? Overlay;
		private List<TextMessage> TextOverlays;
		private int[,] userInterfaceBackground;

		private TextMessage currentMessage;
		private int userCursorPosition;

		private int lastCursorX;
		private int lastCursorY;

		public bool needsUpdate;

		public FrameBuffer()
		{
			//Set Title Screen
			Background = new Background("gfx/0bg_title.png");
			userInterfaceBackground = PngLoader.LoadUI("gfx/0bg_ui.png");

			TextOverlays = new List<TextMessage>();

			currentMessage = new TextMessage("Have you seen my neighbor? It seems like they never bring in any groceries... Have you seen my neighbor? It seems like they never bring in any groceries...  Have you seen my neighbor? It seems like they never bring in any groceries...  Have you seen my neighbor? It seems like they never bring in any groceries... ");

			needsUpdate = true;

		}

		public void OutputImage()
		{
			Draw(Background.GetImageData(), true);

			Draw(userInterfaceBackground, true);

			if (Overlay != null)
			{
				Draw(Overlay.GetImageData(), false, Overlay.GetPositionX(), Overlay.GetPositionY());
				Overlay.HasBeenDrawn= true;
			}

			foreach( var text in TextOverlays)
			{
				text.Write();
			}

			currentMessage.Write();
			userCursorPosition = currentMessage.GetCursorPosition() + 2;

			Console.SetCursorPosition( USER_INTERFACE_ORIGIN_X, userCursorPosition );
			needsUpdate = false;
		}

		public void SetBackground(Background background)
		{
			Background = background;
			needsUpdate = true;
		}

		public void SetOverlay(Overlay overlay)
		{
			Overlay = overlay;
			needsUpdate = true;
		}

		public void SetUI(int[,] ui)
		{
			userInterfaceBackground= ui;
			needsUpdate = true;
		}

		public void AddTextOverlay( string text, int x, int y )
		{
			if( text.Length > MAX_TEXT_OVERLAY_LENGTH)
			{
				TextOverlays.Add(new TextMessage($"OVERLAY TEXT LONGER THAN {MAX_TEXT_OVERLAY_LENGTH}:", 2, 2));
				TextOverlays.Add(new TextMessage(text, 2, 3));
			}
			else
			if (( x+ text.Length ) <= MAX_SCREENSPACE_X && y <= MAX_SCREENSPACE_Y)
			{
				TextOverlays.Add(new TextMessage(text, x, y));
			}
			else
			if( (x + text.Length) >= MAX_SCREENSPACE_X && y <= MAX_SCREENSPACE_Y)
			{
				int xOffset = MAX_SCREENSPACE_X - ( text.Length );
				TextOverlays.Add(new TextMessage(text, xOffset, y));
			}
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
				if( h != (imageData.GetLength(0) - 1))
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
