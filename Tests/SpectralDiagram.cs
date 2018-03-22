using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Sequence_testing.Tests
{
    class SpectralDiagram
    {
        public void SpectralDiagramTest(string sequence, Image spectral)
        {
            // Create the bitmap, with the dimensions of the image placeholder.
            WriteableBitmap wb = new WriteableBitmap((int)spectral.Width, (int)spectral.Height, 0, 0, PixelFormats.Bgra32, null);
            int i =  0;
            for (int x = 0; x < 400; x++)
            {
                for (int y = 0; y < 400; y++)
                {
                    int alpha = 0;
                    int red = 0;
                    int green = 0;
                    int blue = 0;                    
                    // Determine the pixel's color.
                    if ((sequence[i] == '0')) //White
                    {
                        red = 255;
                        green = 255;
                        blue = 255;
                        alpha = 255;
                    }
                    if ((sequence[i] == '1')) //Black
                    {
                        red = 0;
                        green = 0;
                        blue = 0;
                        alpha = 255;
                    }
                    i++;
                    // Set the pixel value.                    
                    byte[] colorData = { (byte)blue, (byte)green, (byte)red, (byte)alpha }; // B G R

                    Int32Rect rect = new Int32Rect(x, y, 1, 1);
                    int stride = (wb.PixelWidth * wb.Format.BitsPerPixel) / 8;
                    wb.WritePixels(rect, colorData, stride, 0);
                }
            }
            // Show the bitmap in an Image element.
            spectral.Source = wb;
        }
    }
}
