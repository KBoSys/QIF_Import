/*! \file ConeFeatureItemType.cs
    \brief Defines an individual cone feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Nominals;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The ConeFeatureItemType defines an individual cone feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks> The DeterminationMode element is the means by which the cone feature measurement is determined.</remarks>
        public ConeMeasurementDeterminationType? DeterminationMode { get; set; }
    }

    /// <remarks> The ConeMeasurementDeterminationType defines how the cone
    /// measurement is determined, either by being set or by being checked
    /// (directly measured or constructed).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeMeasurementDeterminationType
    {
        /// <remarks>
        /// The Checked element signifies that the cone is checked from measured data, either directly measured or constructed.
        /// The Set element signifies that the cone measurement is set to its nominal value.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(ConeCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    /// <remarks> The ConeCheckedFeatureType defines that a cone feature is checked.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeCheckedFeatureType
    {
        /// <remarks> The optional CheckDetails element gives details about the cone check(measurement or construction).</remarks>
        public ConeCheckedType? CheckDetails { get; set; }
    }

    /// <remarks> The ConeCheckedType defines how the cone measurement is checked, either by direct measurement or by construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConeCheckedType
    {
        /// <remarks>
        /// The Measured element signifies that the cone is directly measured.
        /// The Constructed element signifies that the cone is constructed.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(ConeConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }
}
