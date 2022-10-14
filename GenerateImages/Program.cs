// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Drawing.Imaging;

Console.WriteLine("Hello, World!");

var files = Directory.GetFiles("C:\\Users\\calvi\\source\\repos\\Stalvin\\Stalvin\\Client\\wwwroot\\images");
foreach(string file in files)
{
    if (file.EndsWith(".png"))
    {
        Bitmap bmp = new Bitmap(file);
        int width = bmp.Width;
        int height = bmp.Height;
        if (height > width)
        {
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            height = bmp.Height;
            width = bmp.Width;
        }
        int divWidth = width / 3;
        int divHeight = height / 2;
        string saveDirectory = file.Replace(".png", "");
        saveDirectory = saveDirectory.Remove(saveDirectory.Length - 2);

        string saveFileName = Path.GetFileName(file).Replace(".png", "");

        Directory.CreateDirectory(saveDirectory);
        for (int i = 0; i < 3; i++)
        {
            Rectangle rect1 = new Rectangle(i * divWidth, 0, divWidth, divHeight);
            Rectangle rect2 = new Rectangle(i * divWidth, divHeight, divWidth, divHeight);
            Bitmap newBmp1 = bmp.Clone(rect1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Bitmap newBmp2 = bmp.Clone(rect2, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            newBmp1.Save($"{saveDirectory}\\{saveFileName}-{i}.png", ImageFormat.Png);
            newBmp2.Save($"{saveDirectory}\\{saveFileName}-{i + 3}.png", ImageFormat.Png);
        }
    }
   
}
