using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetection
{
    public class PrewittFilter : FilterBase2D
    {
        public override string FilterName
        {
            get { return "PrewittFilter"; }
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

        //horizontal filter matrix for Prewitt edge detection
        private double[,] filterMatrixH =
            new double[,] { { -1, -1, -1, },
                            { 0,  0, 0, },
                            { 1, 1, 1, }, };

        public override double[,] FilterMatrixH
        {
            get { return filterMatrixH; }
        }

        //vertical filter matrix for Prewitt edge detection
        private double[,] filterMatrixV =
           new double[,] { { -1, 0, 1, },
                            { -1, 0, 1, },
                            { -1, 0, 1, }, };

        public override double[,] FilterMatrixV
        {
            get { return filterMatrixV; }
        }
    }
}
