/*! \file OppositeAngledPlanesFeatureItemType.cs
    \brief Defines an individual, three dimensional non-feature-of-size opposite angled planes feature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The OppositeAngledPlanesFeatureItemType defines an individual,
    /// three dimensional non-feature-of-size opposite angled planes
    /// feature, located by its center plane.This feature can be used to
    /// describe a tapered or drafted slot or groove(internal feature) or
    /// a tapered or drafted rib, web, or block(external feature).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledPlanesFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks></remarks>
        public OppositeAngledPlanesMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledPlanesMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(OppositeAngledPlanesCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledPlanesCheckedFeatureType
    {
        /// <remarks></remarks>
        public OppositeAngledPlanesCheckedType CheckDetails { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledPlanesCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(OppositeAngledPlanesConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OppositeAngledPlanesConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(OppositeAngledPlanesBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(OppositeAngledPlanesCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(OppositeAngledPlanesCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(OppositeAngledPlanesFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(OppositeAngledPlanesRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(OppositeAngledPlanesTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
