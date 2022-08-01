/*! \file ToleranceDefinitionsType.cs
    \brief defines a list of tolerance definitions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <remarks The ToleranceDefinitionsType defines a list of tolerance definitions./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ToleranceDefinitionsType
    {
        /// <remarks This compositor provides a choice between a linear tolerance and an angular tolerance./>
        [System.Xml.Serialization.XmlElementAttribute("AngularTolerance", typeof(AngularToleranceDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearTolerance", typeof(LinearToleranceDefinitionType))]
        public object[] Items { get; set; }

        /// <remarks The required n attribute is the number of tolerance definitions in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The LinearToleranceDefinitionType defines a tolerance on a length
    /// that can be referenced by its QIF id./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinearToleranceDefinitionType
    {
        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public Primitives.AttributesType Attributes { get; set; }

        /// <remarks The choice is among (1) MaxValue, (2) MinValue, (3) both (with MaxValue coming first)./>
        [System.Xml.Serialization.XmlElementAttribute("MaxValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public Units.LinearValueType[] Items { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ToleranceChoiceType[] ItemsElementName { get; set; }

        /// <remarks The id attribute is the QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ToleranceChoiceType
    {
        MaxValue, ///< The MaxValue element is the maximum specification limit or upper tolerance.
        MinValue, ///< The MinValue element is the minimum specification limit or lower tolerance..
    }

    /// <remarks The AngularToleranceDefinitionType defines a tolerance on an angle that can be referenced by its QIF id./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularToleranceDefinitionType
    {
        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public Primitives.AttributesType Attributes { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaxValue", typeof(Units.AngularValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValue", typeof(Units.AngularValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public Units.AngularValueType[] Items { get; set; }

        /// <remarks The choice is among (1) MaxValue, (2) MinValue, (3) both (with MaxValue coming first). />
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ToleranceChoiceType[] ItemsElementName { get; set; }

        /// <remarks The id attribute is the QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
    }
}
