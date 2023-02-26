using Geometry.Calculator.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.Builder
{
    public interface ICircleBuilder
    {
        void SetRadius(double value);
        void SetArea(double value);
        void SetCircumference(double value);
        void SetDiameter(double value);
        CircleProduct GetCircle();
    }
}
