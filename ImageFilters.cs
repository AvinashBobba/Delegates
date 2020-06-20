using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class ImageFilters
    {
        public void ApplyBrightness(Image image)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Image image)
        {
            Console.WriteLine("Apply contrast");
        }
    }
}
