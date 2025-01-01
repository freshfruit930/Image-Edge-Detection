using ImageEdgeDetection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConvolutionFilter()
        {
            //arrange
            string fileName = "../../../test_easy.png";
            Bitmap originalBitmap = null;
            Bitmap resultBitmap = null;
            StreamReader streamReader = new StreamReader(fileName);
            originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
            streamReader.Close();

            FilterBase2D filter = new SobelFilter();
            resultBitmap = originalBitmap.ConvolutionFilter(filter);

            fileName = "../../../test_esay_sobel.png";
            StreamWriter streamWriter = new StreamWriter(fileName, false);
            resultBitmap.Save(streamWriter.BaseStream, ImageFormat.Png);
            streamWriter.Flush();
            streamWriter.Close();

            filter = new PrewittFilter();
            resultBitmap = originalBitmap.ConvolutionFilter(filter);

            fileName = "../../../test_esay_Prewitt.png";
            streamWriter = new StreamWriter(fileName, false);
            resultBitmap.Save(streamWriter.BaseStream, ImageFormat.Png);
            streamWriter.Flush();
            streamWriter.Close();

        }
    }
}
