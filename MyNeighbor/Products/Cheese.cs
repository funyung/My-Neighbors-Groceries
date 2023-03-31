namespace MyNeighbor
{
	class Cheese : Product
	{
		public Cheese()
		{
			_id = "cheese";
			_image = new Background("gfx/cheese.png");
			_response = "Not to be rude, but I'm not sure they even know how to pronounce charcuterie... [newline] " +
						"And based on the smell coming from their appartment, possibly lactose intolerant. [newline] " +
						"Is there anything else they might buy?";
			_textOverlay = "This is cheese";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
