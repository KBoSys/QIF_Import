/*! \file ExternalQIFReferencesType.cs
    \brief Contains information about QIF documents referenced by this QIF document

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument
{
    /// <remarks
    /// The ExternalQIFReferencesType contains information about QIF
    /// documents referenced by this QIF document using the external id
    /// referencing mechanism in the QIFReferenceType./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ExternalQIFReferencesType
    {
        /// <remarks Each ExternalQIFDocument element contains information about an external QIF document referenced by this QIF document./>
        [XmlElement("ExternalQIFDocument", Type = typeof(ExternalQIFDocumentReferenceType))]
        public ExternalQIFDocumentReferenceType[] ExternalQIFDocuments { get; set; }

        /// <remarks The required n attribute is the number of employees in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.ExternalQIFDocuments.Length;
        }
    }

    /// <remarks
    /// The ExternalQIFDocumentReferencesType contains information about a
    /// single external QIF document and assigns a QIF id used for internal referencing./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ExternalQIFDocumentReferenceType : QIFIdTypeBase
    {
        /// <remarks The QPId element is the QPId of the external QIF document referenced by this QIF document./>
        [XmlElement]
        public Primitives.QPIdReferenceType QPId { get; set; }

        /// <remarks The optional URI element is a Uniform Resource Identifier for the external QIF document./>
        [XmlElement(IsNullable = true)]
        public Primitives.UriType URI { get; set; }

        /// <remarks The optional Description element is a description of the external QIF document./>
        [XmlElement]
        public string Description { get; set; }
    }
}
