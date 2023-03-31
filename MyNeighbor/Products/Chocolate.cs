namespace MyNeighbor
{
	class Chocolate : Product
	{
		public Chocolate()
		{
			_id = "chocolate";
			_image = new Background("gfx/chocolate.png");
			_response = "Love chocolate personally, live for it. [newline] " +
						"They told me about a dream they had one time where they ate 7,084 kisses and died and haven't touched the stuff since [newline] " +
						"What's another thing you think they might buy?";
			_textOverlay = "This is chocolate";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
