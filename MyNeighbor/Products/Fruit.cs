namespace MyNeighbor
{
	class Fruit : Product
	{
		public Fruit()
		{
			_id = "fruit";
			_image = new Background("gfx/fruit.png");
			_response = "One week I saw them trying that all fruit diet that Steve Jobs did back in the day, was in the hospital for a while after that. [newline] " +
						"Now they have a 'BAN FRUIT' sign in their window... [newline] " +
						"Is there anything else they might buy?";
			_textOverlay = "This is fruit";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
