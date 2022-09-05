/*! \file CircularArcFeatures.cs
    \brief defines a circular arc constructions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks> The CircularArcExtractType defines a circular arc construction by the extraction of a circular arc from a curve feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcExtractType : ConstructionMethodBaseType
    {
        /// <remarks> The CurveFeature element identifies the curve from which the circular arc is extracted.</remarks>
        public BaseFeatureType? CurveFeature { get; set; }
    }

    /// <remarks> The CircularArcIntersectionType defines the construction of a
    /// circular arc by the intersection of two features, e.g.a
    /// cylindrical segment or conical segment with a plane, two conical
    /// segments of differing angles, or a conical segment with a
    /// cylindrical segment.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcIntersectionType : ConstructionMethodBaseType
    {
        /// <remarks> Each IntersectionFeature element identifies a feature to be used to construct the circle of intersection.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("IntersectionFeature")]
        public SequencedBaseFeatureType[]? IntersectionFeature { get; set; }
    }

    /// <remarks> The CircularArcFromScanType defines a circular arc construction by
    /// the retrieval of a circular arc from a scanned surface feature (point cloud).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcFromScanType : ConstructionMethodBaseType
    {
        /// <remarks> The SurfaceFeature element identifies the scanned surface feature from which the circular arc is retrieved.</remarks>
        public BaseFeatureType? SurfaceFeature { get; set; }

        /// <remarks> The SearchRadius element is the radius around the nominal
        /// feature, wherein the measured feature can be expected.The
        /// SearchRadius is the radius added to and subtracted from the
        /// nominal feature radius to define a cylindrical shell.All
        /// scanned points within this cylindrical shell are used for
        /// the retrieval of the feature.The cylindrical shell's axis
        /// is defined by the feature's direction and the cylindrical
        /// shell's axis passes through the feature's center point.</remarks>
        public LinearValueType? SearchRadius { get; set; }

        /// <remarks> The Depth element is the measuring depth down the circular
        /// arc nominal axis vector at which the circular arc is to be retrieved.</remarks>
        public LinearValueType? Depth { get; set; }
    }

    /// <remarks> The CircularArcTransformType defines a circular arc construction by
    /// the transformation of a circular arc through the specified nominal or actual coordinate system.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcTransformType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseArc element identifies the circular arc to be transformed.</remarks>
        public BaseFeatureType? BaseArc { get; set; }

        /// <remarks> The Transformation element identifies the coordinate system to be used to transform the base circular arc.</remarks>
        public TransformationReferenceType? Transformation { get; set; }
    }

    /// <remarks> The CircularArcCastType defines a circular arc construction by the
    /// casting of another feature type to a circular arc.The location,
    /// vector and size are copied from the base feature.Any information
    /// not available on the base feature will remain at nominal.For
    /// example, a cast sphere will create a circular arc with center and
    /// diameter taken from the sphere but it will retain its nominal
    /// normal vector and start and end angles.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcCastType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseFeature element identifies the feature to be cast to a circular arc.</remarks>
        public BaseFeatureType? BaseFeature { get; set; }
    }

    /// <remarks> The CircularArcCopyType defines a copied circular arc construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcCopyType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseArc element identifies the circular arc to be copied.</remarks>
        public BaseFeatureType? BaseArc { get; set; }
    }

    /// <remarks> The CircularArcProjectionType defines a projected circular arc
    /// construction with the circular arc to be projected and the projection plane.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcProjectionType : ConstructionMethodBaseType
    {
        /// <remarks> The ProjectionArc element identifies the circular arc to be projected.</remarks>
        public BaseFeatureType? ProjectionArc { get; set; }

        /// <remarks> The ProjectionPlane element identifies the plane onto which the circular arc is to be projected.</remarks>
        public BaseFeatureType? ProjectionPlane { get; set; }
    }

    /// <remarks> The CircularArcRecompType defines a list of base feature points for
    /// the construction of a re-compensated-for-probe-size best-fit
    /// circular arc through the measurement points of base features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcRecompType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseFeaturePointList element is a list of points for
        /// the construction of a re-compensated-for-probe-size
        /// best-fit circular arc.The total number of points in the
        /// BaseFeaturePointSets in the list must be 3 or greater.</remarks>
        public BaseFeaturePointListType? BaseFeaturePointList { get; set; }
    }

    /// <remarks> The CircularArcBestFitType defines the information for a best-fit
    /// circular arc which includes a list of point-reducible base
    /// features; the points to which those features reduce are used in the
    /// best-fit construction of the circular arc.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcBestFitType : ConstructionMethodBaseType
    {
        /// <remarks> Each BaseFeature element identifies a base feature to be
        /// used for the construction of a circular arc.The number of
        /// base features must be 3 or greater.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("BaseFeature")]
        public SequencedBaseFeatureType[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => this.Items != null ? (uint)this.Items.Length : 0;
            set { }
        }
    }
}
