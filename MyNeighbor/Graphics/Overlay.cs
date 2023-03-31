namespace MyNeighbor
{
	/// <summary>
	/// Holds the pixel luminance values for an overlay type image requiring a limited resolution to be drawn over top of the background after that is displayed
	/// </summary>
	public class Overlay
	{
		private int[,] _imageData = new int[24, 10];
		private int _positionX;
		private int _positionY;

		public bool HasBeenDrawn;

		public Overlay(string filename, int posX, int posY)
		{
			_imageData = PngLoader.LoadOverlay(filename);
			_positionX = posX;
			_positionY = posY;
			HasBeenDrawn = false;
		}

		public int[,] ImageData => _imageData;
		public int PositionX => _positionX;
		public int PositionY => _positionY;


		public void SetPosition(int x, int y)
		{
			_positionX = x;
			_positionY = y;
		}
	}
}
