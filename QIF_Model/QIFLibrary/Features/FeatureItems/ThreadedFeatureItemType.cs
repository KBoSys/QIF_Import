/*! \file ThreadedFeatureItemType.cs
    \brief Defines an individual threaded feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks The SpecifiedFeatureItemBaseType is the abstract base type for
    /// shape feature items for features that are defined indirectly by a
    /// specification rather than by a direct shape description./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class SpecifiedFeatureItemBaseType : ShapeFeatureItemBaseType
    {
    }

    /// <remarks The ThreadedFeatureItemType defines an individual threaded feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadedFeatureItemType : SpecifiedFeatureItemBaseType
    {
        /// <remarks/>
        public ThreadedFeatureMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadedFeatureMeasurementDeterminationType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(ThreadedFeatureCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadedFeatureCheckedFeatureType
    {
        /// <remarks/>
        public ThreadedFeatureCheckedType CheckDetails { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadedFeatureCheckedType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(ThreadedFeatureConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadedFeatureConstructionMethodType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(ThreadedFeatureBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(ThreadedFeatureCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(ThreadedFeatureCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("FromCylinder", typeof(ThreadedFeatureFromCylinderType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(ThreadedFeatureRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(ThreadedFeatureTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
