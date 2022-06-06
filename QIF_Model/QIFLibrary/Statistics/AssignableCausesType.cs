/*! \file AssignableCausesType.cs
    \brief defines a list of assignable causes.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The AssignableCausesType defines a list of assignable causes./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AssignableCausesType
    {
        /// <remarks Each AssignableCause element gives information about the a particular assignable cause./>
        [System.Xml.Serialization.XmlElementAttribute("AssignableCause")]
        public AssignableCauseType[] AssignableCauses { get; set; }

        /// <remarks The required n attribute is the number of assignable causes in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.AssignableCauses.Length;
            set { }
        }
    }

    /// <remarks The AssignableCauseType defines a possible cause for a control issue and the action or actions to take./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AssignableCauseType
    {
        /// <remarks The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks 
        /// The Description element describes an assignable cause for a control issue in natural language.
        /// The AssignableCauseEnum element describes an assignable cause for a control issue as an enumeration of common causes./>
        [System.Xml.Serialization.XmlElementAttribute("AssignableCauseEnum", typeof(AssignableCauseEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
        public object Item { get; set; }

        /// <remarks The optional CorrectiveActionIds element is a list of the ids
        /// of the corrective actions to take when this cause is assigned to a control issue./>
        public ArrayReferenceType CorrectiveActionIds { get; set; }

        /// <remarks The QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The required id attribute is the QIF id of the corrective action, used for referencing./>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks The AssignableCauseEnumType enumerates various common causes that can be assigned to a control issue./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum AssignableCauseEnumType
    {
        /// <remarks/>
        POWER_FAILURE,

        /// <remarks/>
        BROKEN_TOOL,

        /// <remarks/>
        COMPUTER_CRASH,

        /// <remarks/>
        WEATHER_EVENT,

        /// <remarks/>
        OTHER,
    }
}
