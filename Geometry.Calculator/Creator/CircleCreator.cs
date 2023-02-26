﻿using Geometry.Calculator.Builder;
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
    public class CircleCreator
    {
        #region "PrivateFields"
        private ICircleBuilder _circleBuilder;
        private readonly double _value;
        #endregion "PrivateFields"

        #region "PublicConstructor"
        public CircleCreator(ICircleBuilder circleBuilder, double value)
        {
            _circleBuilder = circleBuilder;
            _value = value;
        }
        #endregion "PublicConstructor"

        #region "PublicMethods"
        public void CreateCircle()
        {
            _circleBuilder.SetRadius(_value);
            _circleBuilder.SetArea(_value);
            _circleBuilder.SetCircumference(_value);
            _circleBuilder.SetDiameter(_value);
        }
        public CircleProduct GetCircle()
        {
            return _circleBuilder.GetCircle();
        }
        #endregion "PublicMethods"
    }
}
