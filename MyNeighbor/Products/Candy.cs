namespace MyNeighbor
{
	class Candy : Product
	{
		public Candy()
		{
			_id = "candy";
			_image = new Background("gfx/candy.png");
			_response = "Tho they rarely smile, their chompers look a little too pristine to be involved with this kind of sweet stuff. [newline] " +
						"What's another thing you think they might buy?";
			_textOverlay = "This is candy";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
