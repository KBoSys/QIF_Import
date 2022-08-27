/*! \file TypeOfCoordinatesType.cs
    \brief defines a coordinate system type.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The CoordinateEnumType enumerates values that describe a coordinate system.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CoordinateEnumType
    {
        /// <remarks> CARTESIAN_2D is a two dimensional Cartesian coordinate system with orthogonal X and Y axes.</remarks>
        CARTESIAN_2D,

        /// <remarks> POLAR_2D is a two dimensional polar coordinate system with a radius from the origin and an angle from a starting direction.</remarks>
        POLAR_2D,

        /// <remarks> CARTESIAN_3D is a three dimensional right handed Cartesian coordinate system with orthogonal X, Y, and Z axes.</remarks>
        CARTESIAN_3D,

        /// <remarks> CYLINDRICAL_3D is a three dimensional cylindrical coordinate system with a polar coordinate system where the XY Cartesian plane would be plus height.</remarks>
        CYLINDRICAL_3D,

        /// <remarks> SPHERICAL_3D is a three dimensional spherical coordinate system
        /// with an axis perpendicular to a plane at the origin. It has a
        /// radius extending from the origin, an angle that is the angle
        /// between the radius and the axis, and an angle that is the angle
        /// between a starting direction in the plane and the projection of the radius on the plane.</remarks>
        SPHERICAL_3D,

        /// <remarks>Undefined</remarks>
        UNDEFINED,
    }

    /// <remarks> The TypeOfCoordinatesType defines a coordinate system type.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TypeOfCoordinatesType
    {
        /// <remarks> The CoordinateEnum element describes an often-used coordinate system type.</remarks>
        /// <remarks> The OtherCoordinate element describes a coordinate system type in natural language.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CoordinateEnum", typeof(CoordinateEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCoordinate", typeof(string))]
        public object Item { get; set; }
    }
}
