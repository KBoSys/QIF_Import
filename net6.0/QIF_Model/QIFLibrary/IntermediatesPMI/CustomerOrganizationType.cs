/*! \file CustomerOrganizationType.cs
 	\brief The CustomerOrganizationType defines information about the supplier's view of the customer.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CustomerOrganizationType : OrganizationType
    {
        public CustomerOrganizationType() { }

        //! The CustomerNumber element is the supplier's number for the customer.
        [XmlElement]
        public string? CustomerNumber { get; set; }
    }
}
