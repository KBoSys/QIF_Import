/*! \file PhysicalAddressType.cs
	\brief The PhysicalAddressType defines a physical address.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PhysicalAddressType
    {
        /// <summary>
        /// The optional Description element characterizes the type of the
        /// address to distinguish among delivery, postal, and visitor
        /// addresses.
        /// </summary>
        [XmlElement]
        public AddressDescriptionType? Description { get; set; }

        /// <summary>
        /// The optional InternalLocation element is an
        /// organization-defined address for internal mail delivery.
        /// </summary>
        [XmlElement]
        public string? InternalLocation { get; set; }

        /// <summary>
        /// The optional StreetNumber element is the number of a location on a street.
        /// </summary>
        [XmlElement]
        public string? StreetNumber { get; set; }

        //! The optional Street element is the name of the street.
        [XmlElement]
        public string? Street { get; set; }

        //! The optional PostalBox element is the number of a postal box.
        [XmlElement]
        public string? PostalBox { get; set; }

        //! The optional Town element is the name of a town or city.
        [XmlElement]
        public string? Town { get; set; }

        //! The optional Region element is the name of a region.
        [XmlElement]
        public string? Region { get; set; }

        //! The optional PostalCode element is the code used by the country's postal service.
        [XmlElement]
        public string? PostalCode { get; set; }

        //! The optional Country element is the name of the country.
        [XmlElement]
        public string? Country { get; set; }

        //! The optional FacsimileNumber element is the telephone number where facsimiles may be received.
        [XmlElement]
        public string? FacsimileNumber { get; set; }

        //! The optional TelephoneNumber element is the number where telephone calls may be received.
        [XmlElement]
        public string? TelephoneNumber { get; set; }

        //! The optional ElectronicMailAddress element is the electronic mail address at which electronic messages may be received.
        [XmlElement]
        public string? ElectronicMailAddress { get; set; }

        //! The optional TelexNumber element is the number at which telex messages may be received.
        [XmlElement]
        public string? TelexNumber { get; set; }
    }

    /// <summary>
    /// The AddressDescriptionEnumType enumerates values that describe the
    /// type of a physical address.
    /// </summary>
    public enum AddressDescriptionEnumType
    {
        DELIVERY,
        POSTAL,
        VISITOR,
        NOTDEFINED,
    }

    //! The AddressDescriptionType defines the type of a physical address.
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AddressDescriptionType
    {
        public AddressDescriptionType() { }

        //! The AddressDescriptionEnum element describes an often-used type of a physical address.
        [XmlElement("AddressDescriptionEnum", typeof(AddressDescriptionEnumType))]
        //! The OtherAddressDescription element describes a type of a physical address in natural language.
        [XmlElement("OtherStandardsOrganization", typeof(string))]
        public object? Description { get; set; }
    }

    //! The LocationType defines a physical location.
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class LocationType : QIFIdTypeBase
    {
        /// <summary>
        /// The LocationDescription element gives a natural language
        /// description of a location.If an address is also given, the
        /// description need not duplicate that information.
        /// </summary>
        [XmlElement]
        public string? LocationDescription { get; set; }

        /// <summary>
        /// The optional Address element gives a physical address for a location.        
        /// </summary>
        [XmlElement]
        public PhysicalAddressType? Address { get; set; }
    }
}
