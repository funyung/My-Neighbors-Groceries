namespace MyNeighbor
{
	class Fish : Product
	{
		public Fish()
		{
			_id = "fish";
			_image = new Background("gfx/fish.png");
			_response = "This person is a huge astrology-head, and constantly goes on and on about mercury being in retrograde... [newline] " +
						"Surely the superstition alone would keep them away from this stuff. [newline] " +
						"What's something else they might buy?";
			_textOverlay = "This is fish";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
