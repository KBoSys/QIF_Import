/*! \file GroupFeatureDefinitionType.cs
	\brief Defines the group feature nominal

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks The GroupFeatureDefinitionType defines the group feature nominal
    /// information that can be common to one or more group features./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircleDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircularArcDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureParallelogramDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureLinearDefinitionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class GroupFeatureDefinitionType : ShapeFeatureDefinitionBaseType
    {
        /// <remarks The optional IsProfileGroup element, if present and set to
        /// true, indicates that the group feature is a profile group feature.
        /// A profile group feature is a complex feature
        /// defined by a set of simple features grouped together (e.g.,
        /// all sides of an inner pocket), to which a common profile tolerance may be applied./>
        public bool IsProfileGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsProfileGroupSpecified { get; set; }

        /// <remarks The optional IsRunoutGroup element, if present and set to
        /// true, indicates that the group feature is a runout group feature.
        /// A runout group feature is a complex feature
        /// defined by a set of simple features grouped together (e.g.,
        /// all entities that rotate about or at right angle to a
        /// single axis) to which a common runout tolerance may be applied./>
        public bool IsRunoutGroup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsRunoutGroupSpecified { get; set; }

        /// <remarks This optional compositor provides a choice among countersunk, counterbored and spotface feature groups./>
        [System.Xml.Serialization.XmlElementAttribute("IsCounterboredHole", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("IsCountersunkHole", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("IsSpotface", typeof(bool))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public bool Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public GroupItemChoiceType ItemElementName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum GroupItemChoiceType
    {
        /// <remarks/>
        IsCounterboredHole,

        /// <remarks/>
        IsCountersunkHole,

        /// <remarks/>
        IsSpotface,
    }
}
