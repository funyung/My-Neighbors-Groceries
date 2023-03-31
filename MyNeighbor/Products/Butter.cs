using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNeighbor.Products
{
	class Butter : Product
	{
		public Butter()
		{
			_id = "butter";
			_image = new Background("gfx/snack_cake.png");
			_response = "CHANGEME";
			_textOverlay = "This is butter";
			_textOverlayPositionX = DEFAULT_TEXTOVERLAY_X;
			_textOverlayPositionY = DEFAULT_TEXTOVERLAY_Y;
		}
	}
}
