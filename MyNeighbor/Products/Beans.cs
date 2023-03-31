namespace MyNeighbor
{
	class Beans : Product
	{
		public Beans()
		{
			_id = "beans";
			_image = new Background("gfx/beans.png");
			_response = "They don't seem like the type of person to fill their computer with beans... [newline] " +
						"Besides, I've never seen them at the local bean club meetup. [newline] " +
						"What's another thing you think they might buy?";
			_textOverlay = "This is beans";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
