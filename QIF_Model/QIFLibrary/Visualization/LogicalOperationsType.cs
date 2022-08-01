/*! \file LogicalOperationsType.cs
	\brief defines a logical operations tree.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The LogicalOperationsType defines a logical operations tree./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LogicalOperationsType
    {
        /// <remarks Each LogicalOperation element is a logical operation./>
        [System.Xml.Serialization.XmlElementAttribute("LogicalOperation")]
        public LogicalOperationType[] LogicalOperations { get; set; }

        /// <remarks The required n attribute is the number of LogicalOperation elements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.LogicalOperations.Length;
            set { }
        }
    }

    /// <remarks The LogicalOperationType defines a logical operation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LogicalOperationType
    {
        /// <remarks The Action element specifies the logical operation type: LOGICAL_AND or LOGICAL_OR./>
        public LogicalOperationEnumType Action { get; set; }

        /// <remarks This compositor provides a choice of two arguments of the
        /// logical operation.Each argument can be defined as a section
        /// plane or a result of other logical operation./>
        [System.Xml.Serialization.XmlElementAttribute("LogicalOperationResult", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("SectionPlane", typeof(uint))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public uint[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public LogicalOperationChoiceType[] ItemsElementName { get; set; }

        /// <remarks The required index attribute is an index identifying a logical operation within the LogicalOperations set./>
        [System.Xml.Serialization.XmlAttributeAttribute("index")]
        public uint Index { get; set; }
    }

    /// <remarks The LogicalOperationEnumType enumerates the logical operation types./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LogicalOperationEnumType
    {
        /// <remarks/>
        LOGICAL_AND,

        /// <remarks/>
        LOGICAL_OR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum LogicalOperationChoiceType
    {
        /// <remarks/>
        LogicalOperationResult,

        /// <remarks/>
        SectionPlane,
    }
}
