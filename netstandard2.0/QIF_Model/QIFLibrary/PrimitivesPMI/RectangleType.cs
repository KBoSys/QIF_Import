/*! \file RectangleType.cs
    \brief defines a rectangle

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The RectangleType defines a rectangle to be used as a datum target
    /// or a rectangular zone limit.It is not a feature.ASME Y14.5 - 2009 Section 3.3.3.3, Figure 3-6</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class RectangleType
    {
        /// <remarks> The Length element is the length of the rectangle. One of the
        /// two sides of the rectangle whose length is Length proceeds from
        /// the CornerPoint in the direction of the LengthDirection.</remarks>
        public LinearValueType Length { get; set; }

        /// <remarks> The CornerPoint element is the location of a corner of the rectangle.</remarks>
        public PointType CornerPoint { get; set; }

        /// <remarks> The Width element is the width of the rectangle. One of the two
        /// sides of the rectangle whose length is Width proceeds from the
        /// CornerPoint in the direction of the WidthDirection.</remarks>
        public LinearValueType Width { get; set; }

        /// <remarks> The WidthDirection element is a unit vector that gives the
        /// direction of the width of the rectangle.</remarks>
        public UnitVectorType WidthDirection { get; set; }

        /// <remarks> The LengthDirection element is a unit vector that gives the
        /// direction of the length of the rectangle.</remarks>
        public UnitVectorType LengthDirection { get; set; }
    }
}
