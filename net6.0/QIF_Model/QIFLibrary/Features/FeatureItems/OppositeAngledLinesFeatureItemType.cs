/*! \file OppositeAngledLinesFeatureItemType.cs
    \brief Defines an individual non-feature-of-size opposite angled lines feature located by its centerline.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The OppositeAngledLinesFeatureItemType defines an individual
    /// non-feature-of-size opposite angled lines feature located by its centerline.
    /// This feature can be used to describe a tapered slot or groove(internal feature) or a tapered rib, web, or block(external feature).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledLinesFeatureItemType : CurveFeatureItemBaseType
    {
        /// <remarks></remarks>
        public OppositeAngledLinesMeasurementDeterminationType? DeterminationMode { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledLinesMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(OppositeAngledLinesCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledLinesCheckedFeatureType
    {
        /// <remarks></remarks>
        public OppositeAngledLinesCheckedType? CheckDetails { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledLinesCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(OppositeAngledLinesConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledLinesConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(OppositeAngledLinesBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(OppositeAngledLinesCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(OppositeAngledLinesCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(OppositeAngledLinesFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Intersection", typeof(OppositeAngledLinesIntersectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Projection", typeof(OppositeAngledLinesProjectionType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(OppositeAngledLinesRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(OppositeAngledLinesTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
