using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new ImageProcessor();
            var filters = new ImageFilters();
            Action<Image> imageFilterHandler = filters.ApplyBrightness;
            imageFilterHandler += filters.ApplyContrast;
            imageFilterHandler += ResizeImage;
            processor.Process("C:/Photos/sample.jpg",imageFilterHandler);
        }

        static void ResizeImage(Image image)
        {
            Console.WriteLine("Resize Photo");
        }
    }
}
