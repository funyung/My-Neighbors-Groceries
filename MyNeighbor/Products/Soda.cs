namespace MyNeighbor
{
	class Soda : Product
	{
		public Soda()
		{
			_id = "soda";
			_image = new Background("gfx/soda.png");
			_response = "To them all liquid in aluminum or plastic is nutritionally compromized? [newline] " + 
						"They don't trust mixed drinks like cocktails and the like, describing them as 'unpure' [newline] " +
						"What's another thing you think they might buy?";
			_textOverlay = "This is soda";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
