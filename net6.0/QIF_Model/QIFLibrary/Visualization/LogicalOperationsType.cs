/*! \file LogicalOperationsType.cs
	\brief defines a logical operations tree.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Topology;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks> The LogicalOperationsType defines a logical operations tree.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LogicalOperationsType : ArrayBaseType<LogicalOperationType>
    {
        /// <remarks> Each LogicalOperation element is a logical operation.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("LogicalOperation")]
        public LogicalOperationType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The LogicalOperationType defines a logical operation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LogicalOperationType
    {
        /// <remarks> The Action element specifies the logical operation type: LOGICAL_AND or LOGICAL_OR.</remarks>
        public LogicalOperationEnumType Action { get; set; }

        /// <remarks> This compositor provides a choice of two arguments of the
        /// logical operation.Each argument can be defined as a section
        /// plane or a result of other logical operation.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("LogicalOperationResult", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("SectionPlane", typeof(uint))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public uint[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public LogicalOperationChoiceType[]? ItemsElementName { get; set; }

        /// <remarks> The required index attribute is an index identifying a logical operation within the LogicalOperations set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("index")]
        public uint Index { get; set; }
    }

    /// <remarks> The LogicalOperationEnumType enumerates the logical operation types.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LogicalOperationEnumType
    {
        /// <remarks></remarks>
        LOGICAL_AND,

        /// <remarks></remarks>
        LOGICAL_OR,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum LogicalOperationChoiceType
    {
        /// <remarks></remarks>
        LogicalOperationResult,

        /// <remarks></remarks>
        SectionPlane,
    }
}
