/* Description:
 * Utilizes ImageSharp to processes loaded PNG files into integer arrays and creates an IDrawable element with it
 */
using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace MyNeighbor
{
	//TODO: Refactor to clean up repeated code
	public static class PngLoader
	{
		static int MAX_BACKGROUND_HEIGHT = 44;
		static int MAX_BACKGROUND_WIDTH = 64;
		static int MAX_UI_HEIGHT = 16;
		static int MAX_UI_WIDTH = 64;
		static int MAX_OVERLAY_HEIGHT = 10;
		static int MAX_OVERLAY_WIDTH = 24;

		public static int[,] LoadBackground(string filename)
		{
			int[,] pixelLuminance = new int[MAX_BACKGROUND_HEIGHT, MAX_BACKGROUND_WIDTH];

			if (File.Exists(filename))
			{
				using Image<L8> backgroundImage = Image.Load<L8>(filename);

				if (backgroundImage.Height <= MAX_BACKGROUND_HEIGHT || backgroundImage.Width <= MAX_BACKGROUND_WIDTH)
				{
					//Grab the luminance values of each pixel in our image
					backgroundImage.ProcessPixelRows(accessor =>
					{
						for (int y = 0; y < accessor.Height; y++)
						{
							Span<L8> pixelRow = accessor.GetRowSpan(y);

							for (int x = 0; x < pixelRow.Length; x++)
							{
								ref L8 pixel = ref pixelRow[x];

								pixelLuminance[y, x] = pixel.PackedValue;
							}
						}
					});
				}
				else
				{
					pixelLuminance = UnableToLoadImage.Background();
				}
			}
			else
				pixelLuminance = UnableToLoadImage.Background();

			return pixelLuminance;
		}

		public static int[,] LoadOverlay(string filename)
		{
			int[,] pixelLuminance = new int[MAX_OVERLAY_HEIGHT, MAX_OVERLAY_WIDTH];

			if (File.Exists(filename))
			{
				using Image<L8> backgroundImage = Image.Load<L8>(filename);

				if (backgroundImage.Height <= MAX_OVERLAY_HEIGHT || backgroundImage.Width <= MAX_OVERLAY_WIDTH)
				{
					//Grab the luminance values of each pixel in our image
					backgroundImage.ProcessPixelRows(accessor =>
					{
						for (int y = 0; y < accessor.Height; y++)
						{
							Span<L8> pixelRow = accessor.GetRowSpan(y);

							for (int x = 0; x < pixelRow.Length; x++)
							{
								ref L8 pixel = ref pixelRow[x];

								pixelLuminance[y, x] = pixel.PackedValue;
							}
						}
					});
				}
				else
				{
					pixelLuminance = UnableToLoadImage.Overlay();
				}
			}
			else
				pixelLuminance = UnableToLoadImage.Overlay();

			return pixelLuminance;
		}

		public static int[,] LoadUI(string filename)
		{
			int[,] pixelLuminance = new int[MAX_UI_HEIGHT, MAX_UI_WIDTH];

			if (File.Exists(filename))
			{
				using Image<L8> backgroundImage = Image.Load<L8>(filename);

				if (backgroundImage.Height <= MAX_UI_HEIGHT || backgroundImage.Width <= MAX_UI_WIDTH)
				{
					//Grab the luminance values of each pixel in our image
					backgroundImage.ProcessPixelRows(accessor =>
					{
						for (int y = 0; y < accessor.Height; y++)
						{
							Span<L8> pixelRow = accessor.GetRowSpan(y);

							for (int x = 0; x < pixelRow.Length; x++)
							{
								ref L8 pixel = ref pixelRow[x];

								pixelLuminance[y, x] = pixel.PackedValue;
							}
						}
					});
				}
				else
				{
					pixelLuminance = UnableToLoadImage.Overlay(); //TODO: Make specific error output
				}
			}
			else
				pixelLuminance = UnableToLoadImage.Overlay(); //TODO: Make specific error output

			return pixelLuminance;
		}
	}
}
