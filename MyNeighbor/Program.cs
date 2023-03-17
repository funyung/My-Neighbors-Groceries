using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Reflection.Metadata;
using System.Text;
using System.Timers;

namespace MyNeighbor
{
	internal class Program
	{

		static void Main(string[] args)
		{
			Console.SetWindowPosition(0, 0);
			int MultiplatHack = Console.CursorTop;
			Console.SetWindowSize(128, 60);
			FrameBuffer frame = new FrameBuffer();

			//TODO: Actual game loop to handle user input
			while (true)
			{
				if (frame.needsUpdate)
					frame.OutputImage();

				Console.ResetColor();
			}
		}
	}
}