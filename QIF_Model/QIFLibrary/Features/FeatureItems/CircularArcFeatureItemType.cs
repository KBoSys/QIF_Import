/*! \file CircularArcFeatureItemType.cs
    \brief Defines an individual circular arc feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The CircularArcFeatureItemType defines an individual circular arc feature.
    /// A circular arc feature is a two dimensional circular segment.</remarks>
    public partial class CircularArcFeatureItemType : CurveFeatureItemBaseType
    {
        /// <remarks> The DeterminationMode element is the means by which the circular arc feature measurement is determined.</remarks>
        public CircularArcMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks> The CircularArcMeasurementDeterminationType defines how the
    /// circular arc measurement is determined, either by being set or by
    /// being checked (directly measured or constructed).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcMeasurementDeterminationType
    {
        /// <remarks>
        /// The Checked element signifies that the circular arc is checked from measured data, either directly measured or constructed.
        /// The Set element signifies that the circular arc measurement is set to its nominal value.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(CircularArcCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks> The CircularArcCheckedFeatureType defines that a circular arc feature is checked.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcCheckedFeatureType
    {
        /// <remarks> The optional CheckDetails element gives details about the
        /// circular arc check(measurement or construction).</remarks>
        public CircularArcCheckedType CheckDetails { get; set; }
    }

    /// <remarks> The CircularArcCheckedType defines how the circular arc measurement
    /// is checked, either by direct measurement or by construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcCheckedType
    {
        /// <remarks>
        /// The Measured element signifies that the circular arc is directly measured.
        /// The Constructed element signifies that the circular arc is constructed.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(CircularArcConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object Item { get; set; }
    }
}
