/*! \file AxisType.cs
    \brief Defines a feature axis

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <remarks> The AxisType defines a feature axis.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AxisType
    {
        /// <remarks> The AxisPoint element is the location of a point on the axis.</remarks>
        [XmlElement]
        public PointType AxisPoint { get; set; }

        /// <remarks> The Direction element is the unit vector direction of the axis.</remarks>
        [XmlElement]
        public UnitVectorType Direction { get; set; }
    }
}
