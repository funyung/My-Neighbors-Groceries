namespace MyNeighbor
{
	class Coffee : Product
	{
		public Coffee()
		{
			_id = "coffee";
			_image = new Background("gfx/coffee.png");
			_response = "If you saw the energy level of this person, you know they haven't had a milligram of caffeine in their life. [newline] " +
						"Sometimes they can seem as bitter as a cup of coffee tho. [newline] " +
						"What's another thing you think they might buy?";
			_textOverlay = "This is coffee";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
