using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Geometry.Calculator.Enums
{
    /// <summary>
    /// Shape - All shapes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Shape
    {
        /// <summary>
        /// Square
        /// </summary>
        Square,
        /// <summary>
        /// Rectangle
        /// </summary>
        Rectangle,
        /// <summary>
        /// Triangle
        /// </summary>
        Triangle,
        /// <summary>
        /// Circle
        /// </summary>
        Circle,
        /// <summary>
        /// Smicircle
        /// </summary>
        Semicircle,
        /// <summary>
        /// Sector
        /// </summary>
        Sector,
        /// <summary>
        /// Ellipse
        /// </summary>
        Ellipse,
        /// <summary>
        /// Trapezoid
        /// </summary>
        Trapezoid,
        /// <summary>
        /// Parallelogram
        /// </summary>
        Parallelogram,
        /// <summary>
        /// Rhombus
        /// </summary>
        Rhombus,
        /// <summary>
        /// Kite
        /// </summary>
        Kite,
        /// <summary>
        /// Pentagon
        /// </summary>
        Pentagon,
        /// <summary>
        /// Octagon
        /// </summary>
        Octagon,
        /// <summary>
        /// Hexagon
        /// </summary>
        Hexagon,
        /// <summary>
        /// Ring
        /// </summary>
        Ring,
        /// <summary>
        /// IrregularQuadrilateral
        /// </summary>
        IrregularQuadrilateral,
        /// <summary>
        /// RegularPolygon
        /// </summary>
        RegularPolygon
    }
}
