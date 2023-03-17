/* Description:
 * Holds the integer values for an overlay type image with a limited resolution to be drawn over top of the background after it is displayed
 */

namespace MyNeighbor
{
	public class ImageOverlay
	{
		private int[,] _imageData = new int[24, 10];
		private int _positionX;
		private int _positionY;

		public bool HasBeenDrawn;

		public ImageOverlay(string filename, int posX, int posY)
		{
			_imageData = PngLoader.LoadOverlay(filename);
			_positionX = posX;
			_positionY = posY;
			HasBeenDrawn = false;
		}

		public int[,] GetImageData()
		{
			return _imageData;
		}

		public int GetPositionX()
		{
			return _positionX;
		}

		public int GetPositionY()
		{
			return _positionY;
		}

		public void SetPosition(int x, int y)
		{
			_positionX = x;
			_positionY = y;
		}
	}
}
