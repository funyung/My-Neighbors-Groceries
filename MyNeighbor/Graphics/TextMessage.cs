/* Description:
 * Holds the text string for a text output to console and manages where new lines need to be placed based on specified length 
 */

namespace MyNeighbor
{
	class TextMessage
	{
		static int MAX_CHARACTERS_PER_LINE = 110;
		const int USER_INTERFACE_AREA_X = 8;
		const int USER_INTERFACE_AREA_Y = 48;

		private string _message;
		private int _positionX;
		private int _positionY;
		private ConsoleColor _originalBackgroundColor;
		private ConsoleColor _originalForegroundColor;
		
		public int finalCursorPositionLeft;
		public int finalCursorPositionTop;

		public TextMessage(string message, int posX = USER_INTERFACE_AREA_X, int posY = USER_INTERFACE_AREA_Y)
		{
			_message = message;
			_positionX = posX;
			_positionY = posY;
		}

		public void ChangeMessage(string message)
		{
			_message = message;
		}

		public void Write()
		{
			_originalBackgroundColor = Console.BackgroundColor;
			_originalForegroundColor = Console.ForegroundColor;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(_positionX, _positionY);
			int lines = 0;

			for (int i = 0, j = MAX_CHARACTERS_PER_LINE; i < _message.Length; i++)
			{				
				if( i < j )
					Console.Write(_message[i]);
				else
				{
					++lines;

					Console.Write("\n");
					Console.SetCursorPosition( _positionX, _positionY + lines);
					j += MAX_CHARACTERS_PER_LINE;
				}
			}

			Console.BackgroundColor = _originalBackgroundColor;
			Console.ForegroundColor = _originalForegroundColor;
		}
	}
}
