namespace MyNeighbor
{
	class Eggs : Product
	{
		public Eggs()
		{
			_id = "egg";
			_image = new Background("gfx/egg.png");
			_response = "Eggs suck";
			_textOverlay = "This is Eggs";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
