using Geometry.Calculator.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.Builder
{
    public interface ISemicircleBuilder
    {
        void SetRadius(double value);
        void SetArea(double value);
        void SetPerimeter(double value);
        void SetDiameter(double value);
        SemicircleProduct GetSemicircle();
    }
}
