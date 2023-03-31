namespace MyNeighbor
{
	class Product
	{
		internal const int DEFAULT_TEXTOVERLAY_X = 110;
		internal const int DEFAULT_TEXTOVERLAY_Y = 42;

		public string _id;
		internal Background? _image;
		internal string _response;
		internal string _textOverlay;
		internal int _textOverlayPositionX;
		internal int _textOverlayPositionY;

		public string ID
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public Background Image
		{
			get
			{
				return _image;
			}
			set
			{
				_image = value;
			}
		}

		public string Response
		{
			get
			{
				return _response;
			}
			set
			{
				_response = value;
			}
		}

		public string TextOverlay
		{
			get
			{
				return _textOverlay;
			}
			set 
			{ 
				_textOverlay = value; 
			}
		}

		public int TextPositionX
		{
			get
			{
				return _textOverlayPositionX;
			}
			set
			{
				_textOverlayPositionX = value;
			}
		}

		public int TextPositionY
		{
			get
			{
				return _textOverlayPositionY;
			}
			set
			{
				_textOverlayPositionY = value;
			}
		}
	}
}
