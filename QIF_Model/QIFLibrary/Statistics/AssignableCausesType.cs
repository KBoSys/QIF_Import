/*! \file AssignableCausesType.cs
    \brief defines a list of assignable causes.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The AssignableCausesType defines a list of assignable causes.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AssignableCausesType : ArrayBaseType<AssignableCauseType>
    {
        /// <remarks> Each AssignableCause element gives information about the a particular assignable cause.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AssignableCause")]
        public AssignableCauseType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The AssignableCauseType defines a possible cause for a control issue and the action or actions to take.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AssignableCauseType
    {
        /// <remarks> The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }

        /// <remarks> 
        /// The Description element describes an assignable cause for a control issue in natural language.
        /// The AssignableCauseEnum element describes an assignable cause for a control issue as an enumeration of common causes.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AssignableCauseEnum", typeof(AssignableCauseEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
        public object Item { get; set; }

        /// <remarks> The optional CorrectiveActionIds element is a list of the ids
        /// of the corrective actions to take when this cause is assigned to a control issue.</remarks>
        public ArrayReferenceType CorrectiveActionIds { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The required id attribute is the QIF id of the corrective action, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks> The AssignableCauseEnumType enumerates various common causes that can be assigned to a control issue.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum AssignableCauseEnumType
    {
        /// <remarks></remarks>
        POWER_FAILURE,

        /// <remarks></remarks>
        BROKEN_TOOL,

        /// <remarks></remarks>
        COMPUTER_CRASH,

        /// <remarks></remarks>
        WEATHER_EVENT,

        /// <remarks></remarks>
        OTHER,
    }
}
