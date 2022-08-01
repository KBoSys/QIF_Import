/*! \file ThreadSpecificationsType.cs
    \brief The ThreadSpecificationsType defines a list of thread specifications.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The ThreadSpecificationsType defines a list of thread specifications./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ThreadSpecificationsType
    {
        /// <remarks Each ThreadSpecification element is a specification of a thread./>
        [XmlElement(ElementName = "ThreadSpecification", Type = typeof(ThreadSpecificationType))]
        public ThreadSpecificationType[] ThreadSpecifications { get; set; }

        /// <remarks The required n attribute is the number of thread specifications in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.ThreadSpecifications.Length;
            set { }
        }
    }

    /// <remarks The ThreadSpecificationType defines the thread specification./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ThreadSpecificationType
    {
        //TODO:
    }
}