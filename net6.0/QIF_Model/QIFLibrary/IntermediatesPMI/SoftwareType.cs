/*! \file SoftwareType.cs
	\brief The SoftwareType defines information about a software application.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <summary>
    /// The SoftwareType defines information about a software application.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SoftwareType : QIFIdTypeBase
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        [XmlElement]
        public Primitives.AttributesType? Attributes { get; set; }

        /// <remarks> The VendorName element is the company name of the software vendor.</remarks>
        [XmlElement]
        public string? VendorName { get; set; }

        /// <remarks> The ApplicationName element is the name of the software application.</remarks>
        [XmlElement]
        public string? ApplicationName { get; set; }

        /// <remarks> The optional Version element is the version number of the software application.</remarks>
        [XmlElement]
        public string? Version { get; set; }

        /// <remarks> The optional Description element is the description of the software application.</remarks>
        [XmlElement]
        public string? Description { get; set; }

        /// <remarks> The optional URI element is a Uniform Resource Identifier for the software application, for example, a file or a web site.</remarks>
        [XmlElement]
        public Primitives.UriType? URI { get; set; }

        /// <remarks> 
        /// The optional ReferencedStandardIds element are a list of ids of
        /// standards or specifications referenced by or associated with this software application.</remarks>
        [XmlElement]
        public Primitives.ArrayReferenceType? ReferencedStandardIds { get; set; }
    }

    /// <remarks> The SoftwaresType defines a list of software applications.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SoftwaresType : ArrayBaseType<SoftwareType>
    {
        /// <remarks> Each Software element defines information about a particular software application.</remarks>
        [XmlElement("Software", Type = typeof(SoftwareType))]
        public SoftwareType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
