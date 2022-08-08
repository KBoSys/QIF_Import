/*! \file ElongatedCircleFeatureItemType.cs
    \brief Defines an individual feature-of-size elongated circle feature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Features.Construction;

namespace QIF_Model.QIFLibrary.Features.FeatureItems
{
    /// <remarks The ElongatedCircleFeatureItemType defines an individual
    /// feature-of-size elongated circle feature, located by its center
    /// point.An elongated circle feature can represent a cross section of
    /// the ends of a round-ended slot in the case where the slot has
    /// independent tolerance requirements for its sides and ends. The flat
    /// sides of the elongated circle are not included in the elongated
    /// circle.The ends of the feature are semicircles that meet the sides
    /// tangentially. The width of the feature is the diameter of the ends./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCircleFeatureItemType : CurveFeatureItemBaseType
    {
        /// <remarks/>
        public ElongatedCircleMeasurementDeterminationType DeterminationMode { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCircleMeasurementDeterminationType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Checked", typeof(ElongatedCircleCheckedFeatureType))]
        [System.Xml.Serialization.XmlElementAttribute("Set", typeof(SetFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCircleCheckedFeatureType
    {
        /// <remarks/>
        public ElongatedCircleCheckedType CheckDetails { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCircleCheckedType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constructed", typeof(ElongatedCircleConstructionMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("Measured", typeof(MeasuredFeatureType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElongatedCircleConstructionMethodType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BestFit", typeof(ElongatedCircleBestFitType))]
        [System.Xml.Serialization.XmlElementAttribute("Cast", typeof(ElongatedCircleCastType))]
        [System.Xml.Serialization.XmlElementAttribute("Copy", typeof(ElongatedCircleCopyType))]
        [System.Xml.Serialization.XmlElementAttribute("Recompensated", typeof(ElongatedCircleRecompType))]
        [System.Xml.Serialization.XmlElementAttribute("Transform", typeof(ElongatedCircleTransformType))]
        public ConstructionMethodBaseType Item { get; set; }
    }
}
