/*! \file EdgePointFeatureItemType.cs
    \brief Defines an individual edge-point feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.Construction;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <summary>
    /// The EdgePointFeatureItemType defines an individual edge-point
    /// feature. An edge-point feature is a point on the intersection curve of two faces.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    [XmlRoot]
    public class EdgePointFeatureItemType : FeatureItemBaseType
    {
        /// <remarks> The DeterminationMode element is the means by which the edge-point feature measurement is determined.</remarks>
        [XmlElement]
        public EdgePointMeasurementDeterminationType? DeterminationMode { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class EdgePointMeasurementDeterminationType
    {
        /// <summary>
        /// The EdgePointMeasurementDeterminationType defines how the edge-point
        /// measurement is determined, either by being set or by being checked (directly measured or constructed).
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(EdgePointCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object? Item { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    /// <remarks> The EdgePointCheckedFeatureType defines that an edge-point feature is checked.</remarks>
    public class EdgePointCheckedFeatureType
    {
        /// <remarks> The optional CheckDetails element gives details about the edge-point check(measurement or construction).</remarks>
        public EdgePointCheckedType? CheckDetails { get; set; }
    }

    /// <summary>
    /// The EdgePointCheckedType defines how the edge-point measurement is
    /// checked, either by direct measurement or by construction.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EdgePointCheckedType
    {
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(EdgePointConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object? Item { get; set; }
    }
}
