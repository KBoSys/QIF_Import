/*! \file CoordinateSystemSetType.cs
	\brief A container for storing all coordinate systems

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using QIF_Model.QIFLibrary.Visualization;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Auxiliary
{
    /// <remarks> The CoordinateSystemSetType represents a container for storing all	coordinate systems present in the CAD scene.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CoordinateSystemSetType : ArrayBaseType<CADCoordinateSystemType>
    {
        /// <remarks> Each CoordinateSystem element is a coordinate system..</remarks>
        [XmlElement(ElementName = "CoordinateSystem", Type = typeof(CADCoordinateSystemType))]
        public CADCoordinateSystemType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The CADCoordinateSystemType defines the Cartesian 3D coordinate system in the model space.</remarks>
    public class CADCoordinateSystemType : DrawableBaseType
    {
        /// <remarks> The CoordinateSystemCore element defines the mathematical core of the coordinate system.</remarks>
        public Primitives.CoordinateSystemCoreType CoordinateSystemCore { get; set; } = new Primitives.CoordinateSystemCoreType();
    }
}
