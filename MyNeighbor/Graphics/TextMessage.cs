/* Description:
 * Holds the text string for a text output to console and manages where new lines need to be placed based on specified length 
 */

namespace MyNeighbor
{
	public class TextMessage
	{
		static int MAX_CHARACTERS_PER_LINE = 110;

		private string _message;
		private string[] _words;

		private int _originX;
		private int _originY;

		private ConsoleColor _originalBackgroundColor;
		private ConsoleColor _originalForegroundColor;
		public int finalCursorPositionY;

		public TextMessage(string message, int posX = FrameBuffer.USER_INTERFACE_ORIGIN_X, int posY = FrameBuffer.USER_INTERFACE_ORIGIN_Y)
		{
			_message = message;
			_words = _message.Split(' ');
			_originY = posY;
			_originX = posX;
		}

		public void ChangeMessage(string message)
		{
			_message = message;
			_words = _message.Split(" ");
		}

		public int CursorPosition => finalCursorPositionY;

		public void Write()
		{
			SetColors();
			Console.SetCursorPosition(_originX, _originY);

			int lines = 0;
			int lineLength = 0;

			foreach(var word in _words)
			{
				if(word != "[newline]")
					lineLength += word.Length + 1;

				if ( lineLength < MAX_CHARACTERS_PER_LINE )
				{
					if (word == "[newline]")
					{
						++lines;
						Console.SetCursorPosition(_originX, _originY + lines);
						lineLength= 0;
					}
					else
					{
						Console.Write(word);

						if (word != _words.Last())
							Console.Write(" ");
					}
				}
				else
				{
					++lines;
					Console.SetCursorPosition(_originX, _originY + lines);
					Console.Write(word);

					if (word != _words.Last())
						Console.Write(" ");

					lineLength = word.Length;
				}
			}

			finalCursorPositionY = _originY + lines;

			ResetColors();
		}

		private void SetColors()
		{
			_originalBackgroundColor = Console.BackgroundColor;
			_originalForegroundColor = Console.ForegroundColor;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
		}

		private void ResetColors()
		{
			Console.BackgroundColor = _originalBackgroundColor;
			Console.ForegroundColor = _originalForegroundColor;
		}
	}
}
