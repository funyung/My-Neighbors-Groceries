namespace MyNeighbor
{
	/// <summary>
	/// Holds the pixel luminance values for a background type image to be written to the console
	/// </summary>
	public class Background
    {
        private int[,] _imageData = new int[44,64];

        public Background(string filename)
        {
            _imageData = PngLoader.LoadBackground(filename);
        }

        public int[,] GetImageData()
        {
            return _imageData;
        }
    }
}
