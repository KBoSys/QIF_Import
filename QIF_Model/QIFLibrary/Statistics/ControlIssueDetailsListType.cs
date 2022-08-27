/*! \file ControlIssueDetailsListType.cs
    \brief defines a list of control issues.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The ControlIssueDetailsListType defines a list of control issues.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ControlIssueDetailsListType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ControlIssueDetails")]
        public ControlIssueDetailsType[] ControlIssueDetails { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.ControlIssueDetails.Length;
            set { }
        }
    }

    /// <remarks> The ControlIssueDetailsType defines the details of a control issue.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ControlIssueDetailsType
    {
        /// <remarks> The ControlIssue element defines the type of the control issue.</remarks>
        public ControlIssueType ControlIssue { get; set; }

        /// <remarks> The optional ControlMethodId element is the QIF id of the control method triggering this issue.</remarks>
        public QIFReferenceType ControlMethodId { get; set; }

        /// <remarks> The optional StudyIssueId element is the QIF id of the study issue associated with this control issue.</remarks>
        public QIFReferenceType StudyIssueId { get; set; }
    }

    /// <remarks> The ControlIssueType defines the reason for a control issue.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ControlIssueType
    {
        /// <remarks>
        /// The ControlIssueEnum element describes an often-used control issue reason.
        /// The OtherControlIssue element describes the control issue reason in natural language.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ControlIssueEnum", typeof(ControlIssueEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherControlIssue", typeof(string))]
        public object Item { get; set; }
    }

    /// <remarks> The ControlIssueEnumType enumerates various common control issues that can occur.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ControlIssueEnumType
    {

        /// <remarks></remarks>
        OOT,

        /// <remarks></remarks>
        CP,

        /// <remarks></remarks>
        CPK,

        /// <remarks></remarks>
        PP,

        /// <remarks></remarks>
        PPK,

        /// <remarks></remarks>
        OOC,

        /// <remarks></remarks>
        TRENDING,

        /// <remarks></remarks>
        SKEWED,

        /// <remarks></remarks>
        ONETHIRDGROUPED,

        /// <remarks></remarks>
        TWOTHIRDGROUPED,

        /// <remarks></remarks>
        OSCILLATING,

        /// <remarks></remarks>
        STRATIFIED,

        /// <remarks></remarks>
        OOCRNG,

        /// <remarks></remarks>
        UNDEFINED,
    }
}
