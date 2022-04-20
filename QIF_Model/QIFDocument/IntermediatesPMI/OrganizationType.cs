/*! \file OrganizationType.cs
	\brief The OrganizationType defines information about an organization.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class OrganizationType
	{
		public OrganizationType() { }

        //! The Name element is the name of the organization.
        [XmlElement]
        public string Name { get; set; }

        //! The optional Address element is the address of the organization.
        [XmlElement]
        public PhysicalAddressType Address { get; set; }

        //! The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).
        [XmlElement]
        Primitives.AttributesType Attributes { get; set; }
	}
}
