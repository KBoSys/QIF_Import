/*! \file CorrectiveActionsType.cs
    \brief defines a list of corrective actions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The CorrectiveActionsType defines a list of corrective actions.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CorrectiveActionsType : ArrayBaseType<CorrectiveActionType>
    {
        /// <remarks> Each CorrectiveActionType element gives information about the a particular corrective action.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CorrectiveAction")]
        public CorrectiveActionType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The CorrectiveActionType defines an action to take on a control issue based on an assignable cause.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CorrectiveActionType
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }

        /// <remarks>
        /// The ActionToTake element describes a corrective action to take when a control issue is triggered in natural language.
        /// The ActionToTakeEnum element describes a corrective action to take when a control issue is triggered as an enumeration of common corrective actions.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ActionToTake", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ActionToTakeEnum", typeof(ActionToTakeEnumType))]
        public object Item { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks> The ActionToTakeEnumType enumerates the various corrective actions that can be taken when a control issue is encountered.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ActionToTakeEnumType
    {
        /// <remarks></remarks>
        HALT_PRODUCTION,

        /// <remarks></remarks>
        CONTAINMENT,

        /// <remarks></remarks>
        NEW_MATERIAL_BATCH,

        /// <remarks></remarks>
        NEW_TOOLING,

        /// <remarks></remarks>
        INSPECT_100PC,

        /// <remarks></remarks>
        REBOOT,

        /// <remarks></remarks>
        RECALIBRATE,

        /// <remarks></remarks>
        OTHER,
    }
}
