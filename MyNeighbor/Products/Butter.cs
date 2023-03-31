namespace MyNeighbor
{
	class Butter : Product
	{
		public Butter()
		{
			_id = "butter";
			_image = new Background("gfx/butter.png");
			_response = "I know butter is back in vogue, but they once trapped me in conversation about the negative health effects of yellow foods... [newline] " +
						"I wasn't buying it, and they certainly aren't buying this stuff. [newline] " +
						"What's something else they might buy?";
			_textOverlay = "This is butter";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
