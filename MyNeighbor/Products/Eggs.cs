namespace MyNeighbor
{
	class Eggs : Product
	{
		public Eggs()
		{
			_id = "egg";
			_image = new Background("gfx/egg.png");
			_response = "These things have double the cholesterol of a Big Mac, and I've seen them eat two of those back to back... [newline] " +
						"Maybe they're waiting around for a genetically engineered yolk-less ones, for some reason they avoid yellow foods for health concerns [newline] " +
						"Anything else they could be buying?";
			_textOverlay = "This is eggs";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
