namespace MyNeighbor
{
	class Juice : Product
	{
		public Juice()
		{
			_id = "juice";
			_image = new Background("gfx/juice.png");
			_response = "Definitely not buying this stuff based off of the whole fruit incident they had... [newline] " +
						"Besides that they once described juices and smoothies to me as 'unnatural forms of eating' [newline] " +
						"What's something else they might buy?";
			_textOverlay = "This is juice";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
