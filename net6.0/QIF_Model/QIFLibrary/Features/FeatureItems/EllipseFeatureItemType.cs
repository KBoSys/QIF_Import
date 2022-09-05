/*! \file EllipseFeatureItemType.cs
    \brief Defines an individual ellipse feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The EllipseFeatureItemType defines an individual ellipse feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipseFeatureItemType : CurveFeatureItemBaseType
    {
        /// <remarks> The DeterminationMode element is the means by which the ellipse feature measurement is determined.</remarks>
        public EllipseMeasurementDeterminationType? DeterminationMode { get; set; }
    }

    /// <remarks> The EllipseMeasurementDeterminationType defines how the ellipse
    /// measurement is determined, either by being set or by being checked
    /// (directly measured or constructed).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipseMeasurementDeterminationType
    {
        /// <remarks> 
        /// The Checked element signifies that the ellipse is checked from measured data, either directly measured or constructed.
        /// The Set element signifies that the ellipse measurement is set to its nominal value.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(EllipseCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks> The EllipseCheckedFeatureType defines that an ellipse feature is checked.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipseCheckedFeatureType
    {
        /// <remarks> The optional CheckDetails element gives details about the ellipse check(measurement or construction).</remarks>
        public EllipseCheckedType? CheckDetails { get; set; }
    }

    /// <remarks> The EllipseCheckedType defines how the ellipse measurement is
    /// checked, either by direct measurement or by construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipseCheckedType
    {
        /// <remarks> 
        /// The Measured element signifies that the ellipse is directly measured.
        /// The Constructed element signifies that the ellipse is constructed.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(EllipseConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks> The EllipseConstructionMethodType defines the method for constructing a unique nominal or measured ellipse feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipseConstructionMethodType
    {
        /// <remarks> This optional compositor provides a choice of the construction method for the ellipse.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(EllipseBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(EllipseCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(EllipseCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(EllipseFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Intersection", typeof(EllipseIntersectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Projection", typeof(EllipseProjectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(EllipseRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(EllipseTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
