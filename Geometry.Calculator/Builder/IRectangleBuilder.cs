using Geometry.Calculator.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.Builder
{
    public interface IRectangleBuilder
    {
        void SetLength(double side, double otherValue);
        void SetWidth(double side, double otherValue);
        void SetArea(double side, double otherValue);
        void SetPerimeter(double side, double otherValue);
        void SetDiagonal(double side, double otherValue);
        RectangleProduct GetRectangle();
    }
}
