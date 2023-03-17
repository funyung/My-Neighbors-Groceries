/* Description:
 * Holds the integer values for an background type image to be written to the console and has a maximum resolution for the drawing area
 */

namespace MyNeighbor
{
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
