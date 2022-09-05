/*! \file MarkingFeatureDefinitionType.cs
	\brief Defines a marking feature definition.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    /// <remarks> The MarkingFeatureDefinitionType defines a marking feature definition.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MarkingFeatureDefinitionType : NonShapeFeatureDefinitionBaseType
    {
        /// <remarks> The Text element is the text of the marking.</remarks>
        public string? Text { get; set; }

        /// <remarks> The MarkingMethod element is the method of the putting the marking on a surface.</remarks>
        public MarkingMethodType? MarkingMethod { get; set; }
    }

    /// <remarks> The MarkingMethodType defines a method of making a marking.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MarkingMethodType
    {
        /// <remarks>
        /// The MarkingMethodEnum element describes an often-used method of marking a marking.
        /// The OtherMarkingMethod element describes the method of making a marking in natural language.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MarkingMethodEnum", typeof(MarkingMethodEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherMarkingMethod", typeof(string))]
        public object? Item { get; set; }
    }

    /// <remarks> The MarkingMethodEnumType enumerates values that describe commonly used methods of making a marking.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum MarkingMethodEnumType
    {
        /// <remarks></remarks>
        PAINT,

        /// <remarks></remarks>
        STAIN,

        /// <remarks></remarks>
        ENSCRIBE,

        /// <remarks></remarks>
        EMBOSS,
    }
}
