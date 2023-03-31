namespace MyNeighbor
{
	class Pizza : Product
	{
		public Pizza()
		{
			_id = "pizza";
			_image = new Background("gfx/pizza.png");
			_response = "I saw them running off my pizza delivery guy with a broom one time yelling 'PEPPERONI IS THE PASSWORD!!'... [newline] " +
						"Maybe they know an italian secret of some sort? This is definitely off the menu. [newline] " +
						"Is there anything else they might buy?";
			_textOverlay = "This is pizza";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
