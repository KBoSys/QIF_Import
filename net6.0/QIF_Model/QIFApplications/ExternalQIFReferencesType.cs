/*! \file ExternalQIFReferencesType.cs
    \brief Contains information about QIF documents referenced by this QIF document

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications
{
    /// <remarks>
    /// The ExternalQIFReferencesType contains information about QIF
    /// documents referenced by this QIF document using the external id
    /// referencing mechanism in the QIFReferenceType.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ExternalQIFReferencesType : ArrayBaseType<ExternalQIFDocumentReferenceType>
    {
        /// <remarks> Each ExternalQIFDocument element contains information about an external QIF document referenced by this QIF document.</remarks>
        [XmlElement("ExternalQIFDocument", Type = typeof(ExternalQIFDocumentReferenceType))]
        public ExternalQIFDocumentReferenceType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks>
    /// The ExternalQIFDocumentReferencesType contains information about a
    /// single external QIF document and assigns a QIF id used for internal referencing.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ExternalQIFDocumentReferenceType : QIFIdTypeBase
    {
        /// <remarks> The QPId element is the QPId of the external QIF document referenced by this QIF document.</remarks>
        [XmlElement]
        public QPIdReferenceType? QPId { get; set; } = new QPIdReferenceType();

        /// <remarks> The optional URI element is a Uniform Resource Identifier for the external QIF document.</remarks>
        [XmlElement]
        public UriType? URI { get; set; }

        /// <remarks> The optional Description element is a description of the external QIF document.</remarks>
        [XmlElement]
        public string? Description { get; set; }
    }
}
