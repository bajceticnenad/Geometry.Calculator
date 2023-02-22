using Geometry.Calculator.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.Builder
{
    public interface ISquareBuilder
    {
        void SetSide(double value);
        void SetArea(double value);
        void SetPerimeter(double value);
        void SetDiagonal(double value);
        SquareProduct GetSquare();
    }
}
