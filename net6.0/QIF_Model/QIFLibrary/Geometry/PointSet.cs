/*! \file PointSet.cs
	\brief The PointSetType represents a container for storing all
        instances of PointEntityType present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks> The PointSetType represents a container for storing all instances of PointEntityType present in the CAD scene.</remarks>
    public class PointSetType : ListBaseType<PointEntityType>
    {
        /// <remarks> Each Point element is an instance of PointEntityType. Point
        /// elements are normally used as the underlying geometry for vertices. </remarks>
        [XmlElement("Point", Type = typeof(PointEntityType))]
        public List<PointEntityType> Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The PointEntityType is a geometric entity that is a 3D point. 
    /// It is normally used as underlying geometry for vertices.</remarks>
    public class PointEntityType : GeometryBaseType
    {
        /// <remarks> The XYZ element is the Cartesian three-dimensional coordinates of the 3D point.</remarks>
        [XmlElement]
        public Primitives.PointSimpleType? XYZ { get; set; }
    }
}
