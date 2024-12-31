using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetection
{
    internal class NoFilter : FilterBase2D
    {
        public override string FilterName
        {
            get { return "NoFilter"; }
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

        private double[,] filterMatrixH =
            new double[,] { { 0, 0, 0, },
                            { 0,  1, 0, },
                            { 0, 0, 0, }, };

        public override double[,] FilterMatrixH
        {
            get { return filterMatrixH; }
        }

        private double[,] filterMatrixV =
           new double[,] { { 0, 0, 0, },
                            { 0, 1, 0, },
                            { 0, 0, 0, }, };

        public override double[,] FilterMatrixV
        {
            get { return filterMatrixV; }
        }

    }
}
