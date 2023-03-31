namespace MyNeighbor
{
	class Beans : Product
	{
		public Beans()
		{
			_id = "beans";
			_image = new Background("gfx/snack_cake.png");
			_response = "He doesn't seem like the type of person to fill their computer with beans... [newline] "
						+ "Besides, I've never seen him at the local bean club meetup.";
			_textOverlay = "This is beans";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
