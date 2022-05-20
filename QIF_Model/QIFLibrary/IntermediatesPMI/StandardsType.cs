/*! \file StandardsType.cs
    \brief The StandardsType defines a list of standards and or specifications.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class StandardsType
    {
        public StandardsType() { }

        /// <remarks Each Standard element defines information about a particular standard or specification./>
        [XmlElement(ElementName = "Standard", Type = typeof(StandardType))]
        public StandardType[] Standards { get; set; }

        /// <remarks The required n attribute is the number of standard and specification definitions in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public int Count
        {
            get => this.Standards.Length;
            set {}
        }
    }

    /// <summary>
    /// The StandardType defines information about a standard or
    /// specification.The Organization, Designator, and Year elements
    /// together identify the standard or specification,
    /// e.g., ASME Y14.5-2009, ISO 1101:2017.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class StandardType : QIFIdTypeBase
    {
        public StandardType() { }

        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// </summary>
        [XmlElement]
        public Primitives.AttributesType Attributes { get; set; }

        /// <summary>
        /// The Organization element is the name of the organization issuing
        /// the standard or specification, e.g.ASME, ISO as enumerations, 
        /// or "Acme Widget" as a string.
        /// </summary>
        //[XmlChoiceIdentifier("Organization")]
        public StandardsOrganizationType Organization { get; set; }

        /// <summary>
        /// The Designator element is the name of the designator of the
        /// standard or specification, e.g.Y14.5, 1101.
        /// </summary>
        [XmlElement]
        public string Designator { get; set; }

        /// <summary>
        /// The optional Year element is the year the standard or
        /// specification was released, e.g. 1994, 2009, 2017.
        /// </summary>
        [XmlElement]
        public string Year { get; set; }

        /// <summary>
        /// The optional Title element is the title of the
        /// standard or specification, e.g. "Dimensioning and Tolerancing",
        /// "Geometrical product specifications".
        /// </summary>
        [XmlElement]
        public string Title { get; set; }

        /// <summary>
        /// The optional Description element is the description of the
        /// standard or specification.
        /// </summary>
        [XmlElement]
        public string Description { get; set; }

        /// <summary>
        /// The optional URI element is a Uniform Resource Identifier for
        /// the standard or specification, for example, a file or a web
        /// site.
        /// </summary>
        [XmlElement]
        public Primitives.UriType URI { get; set; }

        /// <summary>
        /// The optional ISBN element is the International Standard Book
        /// Number for the standard or specification.
        /// </summary>
        [XmlElement]
        public string ISBN { get; set; }

        /// <summary>
        /// The optional ReferencedStandardIds element is a list of ids of
        /// standards or specifications referenced by or associated with
        /// this standard or specification.
        /// </summary>
        [XmlElement]
        public Primitives.ArrayReferenceType ReferencedStandardIds { get; set; }
    }

    /// <summary>
    /// The StandardOrganizationType defines information about an
    /// organization issuing a standard or specification.
    /// </summary>
    public class StandardsOrganizationType
    {
        /// <summary>
        /// This compositor provides a choice between the organization name
        /// as an enumeration of a common type and a user defined string
        /// that describes the standards organization name.
        /// </summary>
        [XmlElement("StandardsOrganizationEnum", typeof(IntermediatesPMI.StandardsOrganizationEnumType))]
        [XmlElement("OtherStandardsOrganization", typeof(string))]
        public object OrganizationType { get; set; }
    }
}
