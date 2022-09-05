/*! \file ThreadSpecificationsType.cs
    \brief The ThreadSpecificationsType defines a list of thread specifications.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The ThreadSpecificationsType defines a list of thread specifications.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ThreadSpecificationsType : ArrayBaseType<ThreadSpecificationType>
    {
        /// <remarks> Each ThreadSpecification element is a specification of a thread.</remarks>
        [XmlElement(ElementName = "ThreadSpecification", Type = typeof(ThreadSpecificationType))]
        public ThreadSpecificationType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The ThreadSpecificationType defines the thread specification.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadSpecificationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("MultiLeadSpecification", typeof(MultiLeadThreadSpecificationType))]
        [System.Xml.Serialization.XmlElementAttribute("SingleLeadSpecification", typeof(SingleLeadThreadSpecificationType))]
        [System.Xml.Serialization.XmlElementAttribute("TextThreadSpecification", typeof(TextThreadSpecificationType))]
        public object Item { get; set; }
    }

    /// <remarks> The TextThreadSpecificationType defines a thread specification in natural language.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TextThreadSpecificationType
    {
        /// <remarks> The TextSpecification element is the thread specification in natural language.</remarks>
        public string TextSpecification { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        #region QIFID
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
        #endregion
    }
}