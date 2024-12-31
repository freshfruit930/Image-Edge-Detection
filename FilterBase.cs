using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEdgeDetection
{
    public abstract class FilterBase2D
    {
        public abstract string FilterName
        {
            get;
        }

        public abstract double Factor
        {
            get;
        }

        public abstract double Bias
        {
            get;
        }

        public abstract double[,] FilterMatrixH
        {
            get;
        }

        public abstract double[,] FilterMatrixV
        {
            get;
        }
    }
}
