using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeighbor.Products
{
	class Juice : Product
	{
		public Juice()
		{
			_id = "juice";
			_image = new Background("gfx/snack_cake.png");
			_response = "CHANGEME";
			_textOverlay = "This is juice";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
