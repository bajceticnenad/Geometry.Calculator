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
    public class SquareCreator
    {
        private ISquareBuilder _squareBuilder;
        private readonly double _value;
        public SquareCreator(ISquareBuilder squareBuilder, double value)
        {
            _squareBuilder = squareBuilder;
            _value = value;
        }
        public void CreateSquare()
        {
            _squareBuilder.SetArea(_value);
            _squareBuilder.SetDiagonal(_value);
            _squareBuilder.SetSide(_value);
            _squareBuilder.SetPerimeter(_value);
        }
        public SquareProduct GetSquare()
        {
            return _squareBuilder.GetSquare();
        }
    }
}
