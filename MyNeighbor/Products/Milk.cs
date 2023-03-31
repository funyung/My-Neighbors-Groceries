namespace MyNeighbor
{
	class Milk : Product
	{
		public Milk() 
		{
			_id = "milk";
			_image = new Background("gfx/milk.png");
			_response = "They are completely disguisted with dairy milk... [newline] " +
						"And one time they described dairy-free alternatives as 'nut juice', whatever that is supposed to mean. [newline] " +
						"Is there anything else they might buy?";
			_textOverlay = "This is milk";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
