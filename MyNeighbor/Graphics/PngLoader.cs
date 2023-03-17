/* Description:
 * Utilizes ImageSharp to processes loaded PNG files into integer arrays and creates an IDrawable element with it
 */
using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace MyNeighbor
{
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
			if (File.Exists(filename))
			{
				using Image<L8> backgroundImage = Image.Load<L8>(filename);

				if (backgroundImage.Height <= MAX_BACKGROUND_HEIGHT || backgroundImage.Width <= MAX_BACKGROUND_WIDTH)
				{
					return GetPixelLuminance(backgroundImage, MAX_BACKGROUND_HEIGHT, MAX_BACKGROUND_WIDTH);
				}
				else
				{
					return UnableToLoadImage.Background();
				}
			}
			else
				return UnableToLoadImage.Background();
		}

		public static int[,] LoadOverlay(string filename)
		{
			int[,] pixelLuminance = new int[MAX_OVERLAY_HEIGHT, MAX_OVERLAY_WIDTH];

			if (File.Exists(filename))
			{
				using Image<L8> overlayImage = Image.Load<L8>(filename);

				if (overlayImage.Height <= MAX_OVERLAY_HEIGHT || overlayImage.Width <= MAX_OVERLAY_WIDTH)
				{
					return GetPixelLuminance(overlayImage, MAX_OVERLAY_WIDTH, MAX_OVERLAY_HEIGHT);
				}
				else
				{
					return UnableToLoadImage.Overlay();
				}
			}
			else
				return UnableToLoadImage.Overlay();
		}

		public static int[,] LoadUI(string filename)
		{
			if (File.Exists(filename))
			{
				using Image<L8> uiImage = Image.Load<L8>(filename);

				if (uiImage.Height <= MAX_UI_HEIGHT || uiImage.Width <= MAX_UI_WIDTH)
				{
					return GetPixelLuminance(uiImage, MAX_UI_HEIGHT, MAX_UI_WIDTH);
				}
				else
				{
					return UnableToLoadImage.Overlay(); //TODO: Make specific error output
				}
			}
			else
				return UnableToLoadImage.Overlay(); //TODO: Make specific error output

		}

		private static int[,] GetPixelLuminance(Image<L8> image, int y, int x)
		{
			int[,] luminance = new int[y,x];

			//Grab the luminance values of each pixel in our image
			image.ProcessPixelRows(accessor =>
			{
				for (int y = 0; y < accessor.Height; y++)
				{
					Span<L8> pixelRow = accessor.GetRowSpan(y);

					for (int x = 0; x < pixelRow.Length; x++)
					{
						ref L8 pixel = ref pixelRow[x];

						luminance[y, x] = pixel.PackedValue;
					}
				}
			});

			return luminance;
		}
	}
}
