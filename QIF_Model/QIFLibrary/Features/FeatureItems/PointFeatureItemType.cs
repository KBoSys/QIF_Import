/*! \file PointFeatureItemType.cs
    \brief defines an individual point feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The PointFeatureItemBaseType is the abstract base type for shape feature items for features that are a point.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointFeatureItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class PointFeatureItemBaseType : ShapeFeatureItemBaseType
    {
    }

    /// <remarks> The PointFeatureItemType defines an individual point feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointFeatureItemType : PointFeatureItemBaseType
    {
        /// <remarks> The DeterminationMode element is the means by which the point feature measurement is determined.</remarks>
        public PointMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks> The PointMeasurementDeterminationType defines how the point
    /// measurement is determined, either by being set or by being checked
    /// (directly measured or constructed).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(PointCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks> The PointCheckedFeatureType defines that a point feature is checked.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointCheckedFeatureType
    {
        /// <remarks> The optional CheckDetails element gives details about the point check(measurement or construction).</remarks>
        public PointCheckedType CheckDetails { get; set; }
    }

    /// <remarks> The PointCheckedType defines how the point measurement is checked, either by direct measurement or by construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointCheckedType
    {
        /// <remarks> The Measured element signifies that the point is directly measured.</remarks>
        /// <remarks> The Constructed element signifies that the point is constructed.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(Nominals.PointConstructionMethodType))]
        public object Item { get; set; }
    }
}