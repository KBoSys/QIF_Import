/*! \file SurfaceOfRevolutionFeatureItemType.cs
    \brief Defines an individual surface of revolution feature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The SurfaceOfRevolutionFeatureItemType defines an individual surface of revolution feature.
    /// A surface of revolution feature is
    /// defined by sweeping a planar curve through an angle about an axis.
    /// The angle may be a full circle.The axis has a start point. The
    /// surface has a length that is measured along the axis. The curve
    /// being swept must lie in a plane that contains the axis of the
    /// surface of revolution.The line which is perpendicular to the axis
    /// at the start point of the axis and lies in the plane of the curve
    /// must intersect or be tangent to the curve.The surface that is
    /// formed consists of those points that lie on the surface formed by
    /// sweeping the curve and also lie between (1) the plane perpendicular
    /// to the axis at the start point and(2) the plane perpendicular to
    /// the axis a distance length from the start point in the direction of the axis.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceOfRevolutionFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks></remarks>
        public SurfaceOfRevolutionMeasurementDeterminationType? DeterminationMode { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceOfRevolutionMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(SurfaceOfRevolutionCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceOfRevolutionCheckedFeatureType
    {
        /// <remarks></remarks>
        public SurfaceOfRevolutionCheckedType? CheckDetails { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceOfRevolutionCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(SurfaceOfRevolutionConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceOfRevolutionConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(SurfaceOfRevolutionBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(SurfaceOfRevolutionCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(SurfaceOfRevolutionCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(SurfaceOfRevolutionRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(SurfaceOfRevolutionTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
