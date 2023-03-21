﻿/* Description:
 * Takes background graphic,overlay graphics, and UI background graphic. 
 * Also stores a message for asking or telling the user something.
 */
using System.Runtime.InteropServices;

namespace MyNeighbor
{
    public class FrameBuffer
	{
		static string _white		= "  ";
		static string _lightGray	= "░░";
		static string _gray			= "▒▒";
		static string _darkGray		= "▒▒";
		static string _black		= "██";

		public const int MAX_SCREENSPACE_X = 128;
		public const int MAX_SCREENSPACE_Y = 64;
		public const int MAX_TEXT_OVERLAY_LENGTH = 32;
		public const int USER_INTERFACE_ORIGIN_X = 8;
		public const int USER_INTERFACE_ORIGIN_Y = 48;

		private Background _background;
		private Overlay? _overlay;
		private List<TextMessage> _textOverlays;
		private int[,] _userInterfaceBackground;

		private TextMessage _currentMessage;
		private int _userCursorPosition;

		private int _lastCursorX;
		private int _lastCursorY;

		public bool needsUpdate;
		private bool _initialStart;

		public FrameBuffer()
		{
			//Set Title Screen
			_background = new Background("gfx/0bg_title.png");
			_userInterfaceBackground = PngLoader.LoadUI("gfx/0bg_ui.png");

			_textOverlays = new List<TextMessage>();

			_currentMessage = new TextMessage("Have you seen my neighbor? [newline] " +
											"It seems like they never bring in any groceries...  [newline] " +
											"Do they even eat? What could they possibly be buying?");

			AddTextOverlay("[Space]: Start", 28, 53);
			AddTextOverlay("[Esc]: Quit", 56, 53);
			AddTextOverlay("[F1]: About", 80, 53);

			needsUpdate = true;
			_initialStart = true;
		}

		public void OutputImage()
		{
			Console.SetCursorPosition(0, 0);

			Draw(_background.GetImageData(), true);
			Draw(_userInterfaceBackground, true);

			if (_overlay != null)
			{
				Draw(_overlay.ImageData, false, _overlay.PositionX, _overlay.PositionY);
				_overlay.HasBeenDrawn= true;
			}

			foreach(var text in _textOverlays)
			{
				text.Write();
			}

			_currentMessage.Write();
			_userCursorPosition = _currentMessage.CursorPosition + 2;

			if(_initialStart)
			{
				Console.SetCursorPosition(0, 0);
				_initialStart = false;
			}
			else
				Console.SetCursorPosition(USER_INTERFACE_ORIGIN_X, _userCursorPosition);

			needsUpdate = false;
		}

		public void SetBackground(Background background)
		{ 
			_background = background;
			needsUpdate = true;
		}

		public void SetOverlay(Overlay overlay)
		{
			_overlay = overlay;
			needsUpdate = true;
		}

		public void SetUI(int[,] ui)
		{
			_userInterfaceBackground= ui;
			needsUpdate = true;
		}

		public void AddTextOverlay( string text, int x, int y )
		{
			var positionInBounds = (x + text.Length) <= MAX_SCREENSPACE_X && y <= MAX_SCREENSPACE_Y;
			var positionOutOfBounds = (x + text.Length) >= MAX_SCREENSPACE_X && y <= MAX_SCREENSPACE_Y;

			if( text.Length > MAX_TEXT_OVERLAY_LENGTH)
			{
				_textOverlays.Add(new TextMessage($"OVERLAY TEXT LONGER THAN {MAX_TEXT_OVERLAY_LENGTH}:", 2, 2));
				_textOverlays.Add(new TextMessage(text, 2, 3));
			}
			else
			if(positionInBounds)
			{
				_textOverlays.Add(new TextMessage(text, x, y));
			}
			else
			if(positionOutOfBounds)
			{
				int xOffset = MAX_SCREENSPACE_X - ( text.Length );
				_textOverlays.Add(new TextMessage(text, xOffset, y));
			}
		}

		public void ClearTextOverlays()
		{
			_textOverlays.Clear();
		}

		public void SetMessage(string message)
		{
			_currentMessage.ChangeMessage(message);
			needsUpdate = true;
		}

		public void Draw(int[,] imageData, bool consecutiveOutput, int x = 0, int y = 0)
		{
			Console.BackgroundColor = ConsoleColor.Gray;
			Console.ForegroundColor = ConsoleColor.Black;

			for (int h = 0; h < imageData.GetLength(0); h++)
			{
				if (!consecutiveOutput)
				{
					Console.SetCursorPosition(x, y + h);
				}
					
				for (int w = 0; w < imageData.GetLength(1); w++)
				{
					switch(imageData[h,w])
					{
						case 255:
							Console.Write(_white);
							break;
						case 205:
							Console.Write(_lightGray);
							break;
						case 153:
							Console.Write(_gray);
							break;
						case 101:
							Console.Write(_darkGray);
							break;
						case 50:
							Console.BackgroundColor = ConsoleColor.DarkGray;
							Console.ForegroundColor = ConsoleColor.Black;
							Console.Write(_darkGray);
							Console.BackgroundColor = ConsoleColor.Gray;
							Console.ForegroundColor = ConsoleColor.Black;
							break;
						case 0:
							Console.Write(_black); 
							break;
					}

					if (w == (imageData.GetLength(1) - 1) && h < (imageData.GetLength(0) - 1))
						Console.Write('\n');
				}
			}

			if(!consecutiveOutput)
					Console.SetCursorPosition(_lastCursorX, _lastCursorY);
			else
			{ 
				_lastCursorX = Console.GetCursorPosition().Left;
				_lastCursorY = Console.GetCursorPosition().Top;
			}
		}
	}
}