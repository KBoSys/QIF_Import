/*! \file LineFeatures.cs
    \brief defines a line constructions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks> The LineExtractType defines a line construction by the extraction
    /// of a line from a curve feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineExtractType : ConstructionMethodBaseType
    {
        /// <remarks> The CurveFeature element identifies the curve from which the line is extracted.</remarks>
        public BaseFeatureType? CurveFeature { get; set; }
    }

    /// <remarks> The LineFromScanType defines a line construction by the retrieval of a line from a scanned surface feature(point cloud).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineFromScanType : ConstructionMethodBaseType
    {
        /// <remarks> The SurfaceFeature element identifies the scanned surface feature from which the line is retrieved.</remarks>
        public BaseFeatureType? SurfaceFeature { get; set; }

        /// <remarks> The SearchRadius element is the radius around the nominal
        /// feature, wherein the measured feature can be expected.The
        /// SearchRadius is the radius of a cylinder.All scanned
        /// points within this cylinder are used for the retrieval of
        /// the feature.The cylinder's axis is defined by the
        /// feature's direction and the cylinder's axis passes through
        /// the feature's locating point.</remarks>
        public LinearValueType? SearchRadius { get; set; }
    }

    /// <remarks> The LineTransformType defines a line construction by the
    /// transformation of a line through the specified nominal or actual coordinate system.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineTransformType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseLine element identifies the line feature to be transformed.</remarks>
        public BaseFeatureType? BaseLine { get; set; }

        /// <remarks> The Transformation element identifies the coordinate system
        /// to be used to transform the line.</remarks>
        public TransformationReferenceType? Transformation { get; set; }
    }

    /// <remarks> The LineTangentThroughType defines the construction of a line through a point and tangent to a base feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineTangentThroughType : ConstructionMethodBaseType
    {
        /// <remarks> The TangentFeature element identifies the base feature to which the line is tangent.</remarks>
        public BaseFeatureType? TangentFeature { get; set; }

        /// <remarks> The PointFeature element identifies the point through which the line must pass.</remarks>
        public BaseFeatureType? PointFeature { get; set; }
    }

    /// <remarks> The LineCastType defines the cast of another feature type to a
    /// line.The location and vector are copied from the base feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineCastType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseFeature element identifies the base feature to be cast to a line.</remarks>
        public BaseFeatureType? BaseFeature { get; set; }
    }

    /// <remarks> The LineCopyType defines a copied line construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineCopyType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseLine element identifies the line to be copied.</remarks>
        public BaseFeatureType? BaseLine { get; set; }
    }

    /// <remarks> The LineParallelType defines the construction of a line that is
    /// parallel to a feature and passing through a point.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineParallelType : ConstructionMethodBaseType
    {
        /// <remarks> The ParallelFeature element identifies the feature to which
        /// the constructed line must be parallel.</remarks>
        public BaseFeatureType? ParallelFeature { get; set; }

        /// <remarks> The PointFeature element identifies the point through which
        /// the constructed line must pass.</remarks>
        public BaseFeatureType? PointFeature { get; set; }
    }

    /// <remarks> The LinePerpendicularType defines the construction of a line that
    /// is perpendicular to a feature and passing through a point.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinePerpendicularType : ConstructionMethodBaseType
    {
        /// <remarks> The PerpendicularFeature element identifies the feature to
        /// which the constructed line must be perpendicular.</remarks>
        public BaseFeatureType? PerpendicularFeature { get; set; }

        /// <remarks> The PointFeature element identifies the point through which
        /// the constructed line must pass.</remarks>
        public BaseFeatureType? PointFeature { get; set; }
    }

    /// <remarks> The LineProjectionType defines a projected line construction with
    /// the line to be projected and the projection plane.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineProjectionType : ConstructionMethodBaseType
    {
        /// <remarks> The ProjectionPlane element identifies the plane onto which the line is to be projected.</remarks>
        public BaseFeatureType? ProjectionPlane { get; set; }

        /// <remarks> The ProjectionLine element identifies the line to be projected.</remarks>
        public BaseFeatureType? ProjectionLine { get; set; }
    }

    /// <remarks> The LineIntersectionType defines the construction of a line that is constructed by the intersection of two features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineIntersectionType : ConstructionMethodBaseType
    {
        /// <remarks> Each IntersectionFeature element identifies a feature to be used to construct the line of intersection.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("IntersectionFeature")]
        public SequencedBaseFeatureType[] IntersectionFeature { get; set; }
    }

    /// <remarks> The LineMidlineType defines the construction of a line that is the midline of two base lines.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineMidlineType : ConstructionMethodBaseType
    {
        /// <remarks> Each BaseLine element identifies one of a pair of base lines used to construct a midline.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("BaseLine")]
        public SequencedBaseFeatureType[] BaseLine { get; set; }
    }

    /// <remarks> The LineRecompType defines a list of base feature points for
    /// construction of a re-compensated-for-probe-size best-fit line through the measurement points of base features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineRecompType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseFeaturePointList element gives a list of sets of
        /// points for construction of a re-compensated-for-probe-size best-fit line.
        /// The total number of points in the BaseFeaturePointSets in the list must be 2 or greater.</remarks>
        public BaseFeaturePointListType? BaseFeaturePointList { get; set; }
    }

    /// <remarks> The LineBestFitType defines the information for a best-fit line
    /// which includes a list of point-reducible base features; the points
    /// to which those features reduce are used in the best-fit construction of the line.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineBestFitType : ConstructionMethodBaseType
    {
        /// <remarks> Each BaseFeature element identifies a base feature to be
        /// used for the construction of a line.The number of base features must be 2 or greater.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("BaseFeature")]
        public SequencedBaseFeatureType[]? Items { get; set; }

        /// <remarks> The required n attribute is the number of base features used in the construction.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => this.Items != null ? (uint)this.Items.Length : 0;
            set { }
        }
    }
}
