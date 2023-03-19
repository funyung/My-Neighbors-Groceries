namespace MyNeighbor
{
	internal class Program
	{

		static void Main(string[] args)
		{
			FrameBuffer frame = new FrameBuffer();
			//int MultiplatHack = Console.CursorTop;
			Console.SetWindowSize( 128, 60);

			string test;

			//TODO: Actual game loop to handle user input
			while (true)
			{
				frame.AddTextOverlay("Test max text overlay position", 128, 32);

				if (frame.needsUpdate)
					frame.OutputImage();

				Console.ResetColor();

				test = Console.ReadLine();
			}
		}
	}
}