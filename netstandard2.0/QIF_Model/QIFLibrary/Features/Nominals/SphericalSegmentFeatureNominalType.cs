/*! \file SphericalSegmentFeatureNominalType.cs
    \brief Defines the spherical segment feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The SphericalSegmentFeatureNominalType defines the spherical
    /// segment feature nominal information for an individual spherical
    /// segment feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalSegmentFeatureNominalType : SurfaceFeatureNominalBaseType
    {
        /// <remarks> The Location element is the nominal center of the spherical segment.</remarks>
        public PointType Location { get; set; }

        /// <remarks> The LatitudeLongitudeSweep element gives the extent of a
        /// spherical segment with angular sweep in two directions
        /// analogous to terrestrial latitude and longitude.</remarks>
        public OrientedLatitudeLongitudeSweepType LatitudeLongitudeSweep { get; set; }

        /// <remarks> The optional Constructed element signifies that the
        /// spherical segment is constructed and provides details of
        /// the construction method.</remarks>
        public SphericalSegmentConstructionMethodType Constructed { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalSegmentConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(SphericalSegmentBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(SphericalSegmentCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(SphericalSegmentCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(SphericalSegmentRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(SphericalSegmentTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
