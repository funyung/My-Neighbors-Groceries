/* Description:
 * Holds the text string for a text output to console and manages where new lines need to be placed based on specified length 
 */

namespace MyNeighbor
{
	class TextMessage
	{
		static int MAX_CHARACTERS_PER_LINE = 110;
		private string _message;
		private int _positionX;
		private int _positionY;
		private ConsoleColor _originalBackgroundColor;
		private ConsoleColor _originalForegroundColor;
		
		public int finalCursorPositionLeft;
		public int finalCursorPositionTop;

		public TextMessage( string message, int posX, int posY )
		{
			_message = message;
			_positionX = posX;
			_positionY = posY;
		}

		public void ChangeMessage( string message )
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

			//Find how many lines we have
			for (int i = 1; i < _message.Length; i++)
			{
				if (i == MAX_CHARACTERS_PER_LINE)
					lines++;
			}

			for (int i = 0, j = MAX_CHARACTERS_PER_LINE; i < _message.Length; i++)
			{				
				if( i < j )
					Console.Write(_message[i]);
				else
				{
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
