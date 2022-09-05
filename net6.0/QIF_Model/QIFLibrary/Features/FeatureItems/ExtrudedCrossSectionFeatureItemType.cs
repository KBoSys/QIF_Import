/*! \file ExtrudedCrossSectionFeatureItemType.cs
    \brief Defines an individual extruded cross-section feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The ExtrudedCrossSectionFeatureItemType defines an individual extruded cross-section feature. 
    /// An extruded cross-section feature is formed by extruding a planar curve a distance along a vector
    /// normal to the plane of the curve.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks></remarks>
        public ExtrudedCrossSectionMeasurementDeterminationType? DeterminationMode { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(ExtrudedCrossSectionCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionCheckedFeatureType
    {
        /// <remarks></remarks>
        public ExtrudedCrossSectionCheckedType? CheckDetails { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(ExtrudedCrossSectionConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExtrudedCrossSectionConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(ExtrudedCrossSectionBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(ExtrudedCrossSectionCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(ExtrudedCrossSectionCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(ExtrudedCrossSectionRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(ExtrudedCrossSectionTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
