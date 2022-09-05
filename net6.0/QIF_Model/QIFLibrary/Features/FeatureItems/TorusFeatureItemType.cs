/*! \file TorusFeatureItemType.cs
    \brief Defines an individual torus feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The TorusFeatureItemType defines an individual torus feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TorusFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks> The DeterminationMode element is the means by which the torus feature measurement is determined.</remarks>
        public TorusMeasurementDeterminationType? DeterminationMode { get; set; }
    }

    /// <remarks> The TorusMeasurementDeterminationType defines how the torus
    /// measurement is determined, either by being set or by being checked (directly measured or constructed).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TorusMeasurementDeterminationType
    {
        /// <remarks>
        /// The Checked element signifies that the torus is checked from measured data, either directly measured or constructed.
        /// The Set element signifies that the torus measurement is set to its nominal value.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(TorusCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks> The TorusCheckedFeatureType defines that a torus feature is checked.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TorusCheckedFeatureType
    {

        /// <remarks> The optional CheckDetails element gives details about the torus check(measurement or construction).</remarks>
        public TorusCheckedType? CheckDetails { get; set; }
    }

    /// <remarks> The TorusCheckedType defines how the torus measurement is checked, either by direct measurement or by construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TorusCheckedType
    {
        /// <remarks>
        /// The Measured element signifies that the torus is directly measured.
        /// The Constructed element signifies that the torus is constructed.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(TorusConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks> The TorusConstructionMethodType defines the method for constructing a unique nominal or measured torus feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TorusConstructionMethodType
    {
        /// <remarks> This optional compositor provides a choice of the construction method for the torus.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(TorusBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(TorusCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(TorusCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromScan", typeof(TorusFromScanType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(TorusRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(TorusTransformType))]
        public ConstructionMethodBaseType? Item { get; set; }
    }
}
