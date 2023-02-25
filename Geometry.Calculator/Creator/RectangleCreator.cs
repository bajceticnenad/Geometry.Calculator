using Geometry.Calculator.Builder;
using Geometry.Calculator.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Calculator.Creator
{
    public class RectangleCreator
    {
        #region "PrivateFields"
        private IRectangleBuilder _rectangleBuilder;
        private readonly double _otherValue;
        private readonly double _side;
        #endregion "PrivateFields"

        #region "PublicConstructor"
        public RectangleCreator(IRectangleBuilder rectangleBuilder, double side, double otherValue)
        {
            _rectangleBuilder = rectangleBuilder;
            _otherValue = otherValue;
            _side = side;
        }
        #endregion "PublicConstructor"

        #region "PublicMethods"
        public void CreateRectangle()
        {
            _rectangleBuilder.SetWidth(_side, _otherValue);
            _rectangleBuilder.SetLength(_side, _otherValue);
            _rectangleBuilder.SetArea(_side, _otherValue);
            _rectangleBuilder.SetDiagonal(_side, _otherValue);
            _rectangleBuilder.SetPerimeter(_side, _otherValue);
        }
        public RectangleProduct GetRectangle()
        {
            return _rectangleBuilder.GetRectangle();
        }
        #endregion "PublicMethods"
    }
}
