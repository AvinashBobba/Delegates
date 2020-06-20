using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class ImageProcessor
    {
        //Custom Delegate replaced with Action
        //public delegate void ImageFilterHandler(Image image);
        public void Process(string path, Action<Image> imageFilterHandler)
        {
            var image = Image.Load(path);
            imageFilterHandler(image);
            image.Save();
        }
    }
}
