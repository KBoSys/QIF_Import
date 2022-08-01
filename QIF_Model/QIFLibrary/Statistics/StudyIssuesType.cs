/*! \file StudyIssuesType.cs
    \brief defines a list of study issues.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Traceability;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The StudyIssuesType defines a list of study issues./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StudyIssuesType
    {
        /// <remarks Each StudyIssue element provides details about any issues encountered in the study./>
        [System.Xml.Serialization.XmlElementAttribute("StudyIssue")]
        public StudyIssueType[] StudyIssues { get; set; }

        /// <remarks The required n attribute is the number of study issues in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.StudyIssues.Length;
            set { }
        }
    }

    /// <remarks The StudyIssueType defines the details of a statistical study issue./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StudyIssueType
    {
        /// <remarks The optional Traceability element is traceability information associated with the statistical study issue./>
        public InspectionTraceabilityType Traceability { get; set; }

        /// <remarks The optional AssignableCauseIds element contains the ids of assignable causes associated with this issue./>
        public ArrayReferenceType AssignableCauseIds { get; set; }

        /// <remarks The optional CorrectiveActionIds element contains the ids of corrective actions taken in the resolution of this issue./>
        public ArrayReferenceType CorrectiveActionIds { get; set; }

        /// <remarks The optional Resolution element contains additional notes about the resolution of the issue./>
        public string Resolution { get; set; }

        /// <remarks This optional compositor provides a choice between a list of
        /// characteristic measurement ids or subgroup ids identifying the measurements at fault in a study./>
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicMeasurementIds", typeof(ArrayReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupIds", typeof(ArrayReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ArrayReferenceType Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StudyIssueChoiceType ItemElementName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum StudyIssueChoiceType
    {
        /// <remarks/>
        CharacteristicMeasurementIds,

        /// <remarks/>
        SubgroupIds,
    }
}
