
namespace MyNeighbor
{
	class Product
	{
		internal Background? _image;
		internal string _response;
		internal string _textOverlay;
		public string _id;

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
	}
}
