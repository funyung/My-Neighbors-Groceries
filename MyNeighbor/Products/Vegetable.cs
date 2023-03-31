namespace MyNeighbor
{
	class Vegetable : Product
	{
		public Vegetable()
		{
			_id = "vegetable";
			_image = new Background("gfx/snack_cake.png");
			_response = "Ever since they started a garden in our courtyard they keep telling me how the vegetables at the store are fake... [newline] " +
						"Honestly everything they grow is minature in size, it doesn't seem like much to cook with. [newline] " +
						"What's something else they might buy?";
			_textOverlay = "This is vegetable";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
