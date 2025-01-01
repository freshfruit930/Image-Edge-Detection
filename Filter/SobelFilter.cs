using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetection
{
    public class SobelFilter : FilterBase2D
    {
        public override string FilterName
        {
            get { return "SobelFilter"; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
        }

        //horizontal filter matrix for Sobel edge detection
        private double[,] filterMatrixH =
            new double[,] { { -1, -2, -1, },
                            { 0,  0, 0, },
                            { 1, 2, 1, }, };

        public override double[,] FilterMatrixH
        {
            get { return filterMatrixH; }
        }

        //vertical filter matrix for Sobel edge detection
        private double[,] filterMatrixV =
           new double[,] { { -1, 0, 1, },
                            { -2, 0, 2, },
                            { -1, 0, 1, }, };

        public override double[,] FilterMatrixV
        {
            get { return filterMatrixV; }
        }
    }
}
