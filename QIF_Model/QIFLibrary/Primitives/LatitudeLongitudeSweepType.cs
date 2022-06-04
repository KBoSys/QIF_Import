/*! \file LatitudeLongitudeSweepType.cs
    \brief defines an angular sweep in two directions analogous to terrestrial latitude and longitude.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <remarks The LatitudeLongitudeSweepType defines an angular sweep in two
    /// directions analogous to terrestrial latitude and longitude.
    /// For a sphere, latitude angles are +90 degrees at the north pole to -90
    /// degrees at the south pole with 0 degrees at the equator.For a
    /// torus, latitude angles are 0 degrees at the equator farthest from
    /// the feature center and 180 or -180 degrees at the equator closest
    /// to the feature center, and the positive direction is towards the
    /// north pole vector from the equator farthest from the feature
    /// center. The positive direction in the longitude direction is
    /// counterclockwise(east) as viewed from the direction in which the
    /// north pole vector points. To use the LatitudeLongitudeSweepType, a
    /// north pole must be identified. For a torus, that is the north pole
    /// of the torus. For a sphere, the derived type
    /// OrientedLatitudeLongitudeSweepType must be used; it includes a north pole./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientedLatitudeLongitudeSweepType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LatitudeLongitudeSweepType
    {
        /// <remarks The DirMeridianPrime element is the direction of the prime
        /// meridian vector.The longitude is 0 on the PrimeMeridianVector.
        /// This vector must be perpendicular to the north pole vector./>
        public UnitVectorType DirMeridianPrime { get; set; }

        /// <remarks The DomainLatitude element is the latitude domain. The unit
        /// type is angular unit.For a sphere, the latitude end angle must
        /// be greater than the latitude start angle. For a torus, either
        /// angle may be greater, but the sweep is always in the positive direction./>
        public AngleRangeType DomainLatitude { get; set; }

        /// <remarks The DomainLongitude element is the longitude domain. The unit
        /// type is angular unit.Regardless of the values of the
        /// DomainLongitude, the longitude sweep is in the positive direction./>
        public AngleRangeType DomainLongitude { get; set; }
    }

    /// <remarks The OrientedLatitudeLongitudeSweepType defines a LatitudeLongitudeSweepType with a north pole added./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OrientedLatitudeLongitudeSweepType : LatitudeLongitudeSweepType
    {
        /// <remarks The DirNorthPole element is the direction of the north pole
        /// vector.For a torus this vector must be parallel or anti-parallel to the feature axis./>
        public UnitVectorType DirNorthPole { get; set; }
    }
}
