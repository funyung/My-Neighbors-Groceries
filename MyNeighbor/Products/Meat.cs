namespace MyNeighbor
{
	class Meat : Product
	{
		public Meat()
		{
			_id = "meat";
			_image = new Background("gfx/meat.png");
			_response = "This person is staunchly vegetarian, once told me I might as well be eating a person when I got a chicken sandwich delivered. [newline] " +
						"What's another thing you think they might buy?";
			_textOverlay = "This is meat";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
