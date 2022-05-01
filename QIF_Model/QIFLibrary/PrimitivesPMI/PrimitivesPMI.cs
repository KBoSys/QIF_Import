/*! \file PrimitivesPMI.cs
    
    PrimitivesPMI file defines a large number of
    miscellaneous types used in other QIF files.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <summary>
    /// The RectangularUnitAreaType defines a rectangular region.
    /// </summary>
  	[System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class RectangularUnitAreaType
    {
        /// <summary>
        /// The RectangularUnitAreaLength element is the length in linear
        /// units of the rectangular region.
        /// </summary>
        [XmlElement]
        LinearValueType RectangularUnitAreaLength { get; set; }

        /// <summary>
        /// The RectangularUnitAreaWidth element is the width in linear
        /// units of the rectangular region.
        /// </summary>
        [XmlElement]
        LinearValueType RectangularUnitAreaWidth { get; set; }

        /// <summary>
        /// The optional RectangularUnitAreaOrientation element is the
        /// direction of the rectangle's axis along the length of the rectangle.
        /// </summary>
        [XmlElement]
        UnitVectorType RectangularUnitAreaOrientation { get; set; }
    }
}
