﻿/*! \file PrimitivesPMI.cs
    
    PrimitivesPMI file defines a large number of
    miscellaneous types used in other QIF files.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks The CircularUnitAreaType defines a circular region./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CircularUnitAreaType
    {
        /// <remarks The CircularUnitAreaDiameter element is the length in linear
        /// units of the diameter of the circular region./>
        public LinearValueType CircularUnitAreaDiameter { get; set; }
    }

    /// <summary>
    /// The RectangularUnitAreaType defines a rectangular region.
    /// </summary>
  	[System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot]
    public class RectangularUnitAreaType
    {
        /// <summary>
        /// The RectangularUnitAreaLength element is the length in linear
        /// units of the rectangular region.
        /// </summary>
        [XmlElement]
        public LinearValueType RectangularUnitAreaLength { get; set; }

        /// <summary>
        /// The RectangularUnitAreaWidth element is the width in linear
        /// units of the rectangular region.
        /// </summary>
        [XmlElement]
        public LinearValueType RectangularUnitAreaWidth { get; set; }

        /// <summary>
        /// The optional RectangularUnitAreaOrientation element is the
        /// direction of the rectangle's axis along the length of the rectangle.
        /// </summary>
        [XmlElement]
        public UnitVectorType RectangularUnitAreaOrientation { get; set; }
    }

    /// <remarks The DimensionCountEnumType enumerates values that describe whether
    /// a feature or a characteristic is two dimensional or three dimensional./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DimensionCountEnumType
    {
        TWODIMENSIONAL,
        THREEDIMENSIONAL,
    }

    /// <remarks The ZoneOrientationEnumType enumerates values that describe the
    /// orientation of a tolerance zone with respected to a feature or coordinate system characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ZoneOrientationEnumType
    {
        LENGTH,
        WIDTH,
        RADIAL,
        ANGULAR,
    }
}
