/*! \file ConicalSegmentFeatureItemType.cs
    \brief Defines an individual conical segment feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks> The ConicalSegmentFeatureItemType defines an individual conical segment feature.
    /// A conical segment feature is a portion of a cone, for example, the surface of a rounded corner of a pocket with draft.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalSegmentFeatureItemType : SurfaceFeatureItemBaseType
    {
        /// <remarks></remarks>
        public ConicalSegmentMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks> The ConicalSegmentMeasurementDeterminationType defines how the
    /// conical segment feature measurement is determined, either by being
    /// set or by being checked (directly measured or constructed).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalSegmentMeasurementDeterminationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(ConicalSegmentCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks> The ConicalSegmentCheckedFeatureType defines that a conical segment feature is checked.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalSegmentCheckedFeatureType
    {
        /// <remarks></remarks>
        public ConicalSegmentCheckedType CheckDetails { get; set; }
    }

    /// <remarks> The ConicalSegmentCheckedType defines how the conical segment
    /// feature measurement is checked, either by direct measurement or by
    /// construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalSegmentCheckedType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(ConicalSegmentConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks> The ConicalSegmentConstructionMethodType defines the method for constructing a unique nominal or measured conical segment feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalSegmentConstructionMethodType
    {
        /// <remarks> This optional compositor provides a choice of the construction method for the conical section.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(ConicalSegmentBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(ConicalSegmentCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(ConicalSegmentCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(ConicalSegmentRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(ConicalSegmentTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
