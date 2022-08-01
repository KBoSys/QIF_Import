/*! \file ArrayPointType.cs
    \brief an array of doubles representing a specific number of ordered 3D points.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// The ArrayPointType is an array of doubles representing a specific number of ordered 3D points. 
    /// Each successive group of three entries in the array represents the X, Y, and Z coordinates of a point.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class ArrayPointType : ListDoubleType
    {
        public ArrayPointType() { }
        public ArrayPointType(uint numPoints) : base(3 * numPoints) { }

        /// <summary>
        /// The required count attribute gives the number of points
        /// represented by the array.The number of entries in the array
        /// must be 3*count.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public override uint Count
        {
            get => (uint)Value.Length / 3;
            set { } // => base.Value = new double[3 * value];
        }
    }

    /// <remarks The PolyLineType defines a polyline as an ordered list of points.
    /// The polyline is a continuous path consisting of line segments from
    /// point 1 to point 2, point 2 to point 3, etc.A polyline is not
    /// necessarily closed.To make a closed polyline, the last point
    /// should be the same as the first./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot()]
    public partial class PolyLineType : ArrayPointType
    {
    }
}
