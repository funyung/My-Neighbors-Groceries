namespace MyNeighbor
{
	class Bread : Product
	{
		public Bread()
		{
			_id = "bread";
			_image = new Background("gfx/bread.png");
			_response = "I overheard them badmouthing gluten one time, like really screaming about it to a pidgeon. [newline] " +
						"Never thought someone could have such strong opinions on bread before that, so definitely not buying this. [newline] " +
						"Is there anything else they might buy?";
			_textOverlay = "This is bread";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
