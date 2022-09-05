/*! \file ToleranceDefinitionsType.cs
    \brief defines a list of tolerance definitions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <remarks> The ToleranceDefinitionsType defines a list of tolerance definitions.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ToleranceDefinitionsType : ArrayBaseType<object>
    {
        /// <remarks> This compositor provides a choice between a linear tolerance and an angular tolerance.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AngularTolerance", typeof(AngularToleranceDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearTolerance", typeof(LinearToleranceDefinitionType))]
        public object[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The LinearToleranceDefinitionType defines a tolerance on a length
    /// that can be referenced by its QIF id.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinearToleranceDefinitionType
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public Primitives.AttributesType? Attributes { get; set; }

        /// <remarks> The choice is among (1) MaxValue, (2) MinValue, (3) both (with MaxValue coming first).</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MaxValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public Units.LinearValueType[]? Items { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ToleranceChoiceType[]? ItemsElementName { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; } = new QIFApplications.QIFIdType();

        [System.Xml.Serialization.XmlAttribute]
        public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ToleranceChoiceType
    {
        /// <summary>
        /// The MaxValue element is the maximum specification limit or upper tolerance.
        /// </summary>
        MaxValue,
        /// <summary>
        /// The MinValue element is the minimum specification limit or lower tolerance..
        /// </summary>
        MinValue, 
    }

    /// <remarks> The AngularToleranceDefinitionType defines a tolerance on an angle that can be referenced by its QIF id.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularToleranceDefinitionType
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public Primitives.AttributesType? Attributes { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("MaxValue", typeof(Units.AngularValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValue", typeof(Units.AngularValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public AngularValueType[]? Items { get; set; }

        /// <remarks> The choice is among (1) MaxValue, (2) MinValue, (3) both (with MaxValue coming first). </remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ToleranceChoiceType[]? ItemsElementName { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFIdType QIFID { get; set; } = new QIFIdType();

        [System.Xml.Serialization.XmlAttribute]
        public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
    }
}
