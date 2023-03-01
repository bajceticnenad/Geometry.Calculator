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
    public class SemicircleCreator
    {
        #region "PrivateFields"
        private ISemicircleBuilder _semicircleBuilder;
        private readonly double _value;
        #endregion "PrivateFields"

        #region "PublicConstructor"
        public SemicircleCreator(ISemicircleBuilder semicircleBuilder, double value)
        {
            _semicircleBuilder = semicircleBuilder;
            _value = value;
        }
        #endregion "PublicConstructor"

        #region "PublicMethods"
        public void CreateSemicircle()
        {
            _semicircleBuilder.SetRadius(_value);
            _semicircleBuilder.SetArea(_value);
            _semicircleBuilder.SetPerimeter(_value);
            _semicircleBuilder.SetDiameter(_value);
        }
        public SemicircleProduct GetSemicircle()
        {
            return _semicircleBuilder.GetSemicircle();
        }
        #endregion "PublicMethods"
    }
}
