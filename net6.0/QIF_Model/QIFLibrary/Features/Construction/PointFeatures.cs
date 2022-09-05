/*! \file PointFeatures.cs
    \brief defines point constructions

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks> The PointFeatureExtremeType defines the construction of the extreme
    /// point on a feature in the specified direction.Except in the case
    /// of Radial, the point is the point at which a plane approaching the
    /// feature from the given direction first touches the feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureExtremeType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseFeature element identifies the feature whose extreme location is to be used in a construction.</remarks>
        public BaseFeatureType? BaseFeature { get; set; }

        /// <remarks> The Minimum element specifies whether the minimum or the
        /// maximum extreme of the base feature is to be used.It is
        /// set to "false" for the maximum extreme point in the
        /// specified direction, or set to "true" for the minimum.</remarks>
        public bool Minimum { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BaseAxisFeature", typeof(BaseFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Radial", typeof(string), DataType = "token")]
        [System.Xml.Serialization.XmlElementAttribute("Vector", typeof(UnitVectorType))]
        [System.Xml.Serialization.XmlElementAttribute("Xaxis", typeof(string), DataType = "token")]
        [System.Xml.Serialization.XmlElementAttribute("Yaxis", typeof(string), DataType = "token")]
        [System.Xml.Serialization.XmlElementAttribute("Zaxis", typeof(string), DataType = "token")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object? Item { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public PointFeatureExtremeChoiceType ItemElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum PointFeatureExtremeChoiceType
    {
        /// <remarks></remarks>
        BaseAxisFeature,

        /// <remarks></remarks>
        Radial,

        /// <remarks></remarks>
        Vector,

        /// <remarks></remarks>
        Xaxis,

        /// <remarks></remarks>
        Yaxis,

        /// <remarks></remarks>
        Zaxis,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureMovePointAxisType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BaseLocationFeature { get; set; }

        /// <remarks></remarks>
        public LinearValueType? Distance { get; set; }

        /// <remarks></remarks>
        public BaseFeatureType? BaseAxisFeature { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureMovePointVectorType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BaseFeature { get; set; }

        /// <remarks></remarks>
        public LinearValueType? Distance { get; set; }

        /// <remarks></remarks>
        public UnitVectorType? Vector { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureMovePointType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BaseFeature { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DirectionalOffset", typeof(DirectionalOffsetType))]
        [System.Xml.Serialization.XmlElementAttribute("Offset", typeof(VectorType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureCastType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BaseFeature { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureMidPointType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BaseFeature")]
        public SequencedBaseFeatureType[]? BaseFeature { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureCenterOfGravityType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BaseFeature")]
        public BaseFeatureType[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => this.Items != null ? (uint)this.Items.Length : 0;
            set { }
        }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureFromScanType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? SurfaceFeature { get; set; }

        /// <remarks></remarks>
        public LinearValueType? SearchRadius { get; set; }

        /// <remarks></remarks>
        public RetrievalMethodEnumType RetrievalMethod { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureTransformType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BasePointFeature { get; set; }

        /// <remarks></remarks>
        public TransformationReferenceType? Transformation { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureCopyType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BasePointFeature { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureFromConeType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BaseCone { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureProjectionType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? ProjectionPlane { get; set; }

        /// <remarks></remarks>
        public BaseFeatureType? ProjectionFeature { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeaturePierceType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? SurfaceFeature { get; set; }

        /// <remarks></remarks>
        public BaseFeatureType? CurveFeature { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureIntersectionType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("IntersectionFeature")]
        public SequencedBaseFeatureType[]? IntersectionFeature { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceExtractType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? SurfaceFeature { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceTransformType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BasePointDefinedSurface { get; set; }

        /// <remarks></remarks>
        public TransformationReferenceType? Transformation { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceCopyType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BasePointDefinedSurface { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceRecompType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeaturePointListType? BaseFeaturePointList { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceBestFitType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
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

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveExtractType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? CurveFeature { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveFromScanType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? SurfaceFeature { get; set; }

        /// <remarks></remarks>
        public LinearValueType? SearchRadius { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveTransformType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BasePointDefinedCurve { get; set; }

        /// <remarks></remarks>
        public TransformationReferenceType? Transformation { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveCopyType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeatureType? BasePointDefinedCurve { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveRecompType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
        public BaseFeaturePointListType? BaseFeaturePointList { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedCurveBestFitType : ConstructionMethodBaseType
    {
        /// <remarks></remarks>
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
