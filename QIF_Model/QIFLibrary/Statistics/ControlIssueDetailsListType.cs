/*! \file ControlIssueDetailsListType.cs
    \brief defines a list of control issues.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The ControlIssueDetailsListType defines a list of control issues./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ControlIssueDetailsListType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ControlIssueDetails")]
        public ControlIssueDetailsType[] ControlIssueDetails { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.ControlIssueDetails.Length;
            set { }
        }
    }

    /// <remarks The ControlIssueDetailsType defines the details of a control issue./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ControlIssueDetailsType
    {
        /// <remarks The ControlIssue element defines the type of the control issue./>
        public ControlIssueType ControlIssue { get; set; }

        /// <remarks The optional ControlMethodId element is the QIF id of the control method triggering this issue./>
        public QIFReferenceType ControlMethodId { get; set; }

        /// <remarks The optional StudyIssueId element is the QIF id of the study issue associated with this control issue./>
        public QIFReferenceType StudyIssueId { get; set; }
    }

    /// <remarks The ControlIssueType defines the reason for a control issue./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ControlIssueType
    {
        /// <remarks
        /// The ControlIssueEnum element describes an often-used control issue reason.
        /// The OtherControlIssue element describes the control issue reason in natural language./>
        [System.Xml.Serialization.XmlElementAttribute("ControlIssueEnum", typeof(ControlIssueEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherControlIssue", typeof(string))]
        public object Item { get; set; }
    }

    /// <remarks The ControlIssueEnumType enumerates various common control issues that can occur./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ControlIssueEnumType
    {

        /// <remarks/>
        OOT,

        /// <remarks/>
        CP,

        /// <remarks/>
        CPK,

        /// <remarks/>
        PP,

        /// <remarks/>
        PPK,

        /// <remarks/>
        OOC,

        /// <remarks/>
        TRENDING,

        /// <remarks/>
        SKEWED,

        /// <remarks/>
        ONETHIRDGROUPED,

        /// <remarks/>
        TWOTHIRDGROUPED,

        /// <remarks/>
        OSCILLATING,

        /// <remarks/>
        STRATIFIED,

        /// <remarks/>
        OOCRNG,

        /// <remarks/>
        UNDEFINED,
    }
}
