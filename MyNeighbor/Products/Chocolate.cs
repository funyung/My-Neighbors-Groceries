namespace MyNeighbor
{
	class Chocolate : Product
	{
		public Chocolate()
		{
			_id = "chocolate";
			_image = new Background("gfx/chocolate.png");
			_response = "Love chocolate";
			_textOverlay = "This is chocolate";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
