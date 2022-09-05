/*! \file CylinderFeatureItemType.cs
    \brief Defines an individual cylinder feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The CylinderFeatureItemType defines an individual cylinder feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks> The DeterminationMode element is the means by which the cylinder feature measurement is determined.</remarks>
        public CylinderMeasurementDeterminationType? DeterminationMode { get; set; }
    }

    /// <remarks> The CylinderMeasurementDeterminationType defines how the cylinder
    /// measurement is determined, either by being set or by being checked
    /// (directly measured or constructed).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(CylinderCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks> The CylinderCheckedFeatureType defines that a cylinder feature is checked.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderCheckedFeatureType
    {
        /// <remarks></remarks>
        public CylinderCheckedType? CheckDetails { get; set; }
    }

    /// <remarks> The CylinderCheckedType defines how the cylinder measurement is checked, either by direct measurement or by construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(CylinderConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks> The CylinderConstructionMethodType defines the method for constructing a unique nominal or measured cylinder feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylinderConstructionMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(CylinderBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(CylinderCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(CylinderCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(CylinderFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(CylinderRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(CylinderTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
