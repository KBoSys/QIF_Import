/*! \file QIFReferenceBaseType.cs

        The QIFReferenceBaseType is the base type for references
        to 'id' attributes. It is not used as the type of an element
        or attribute.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Primitives
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class QIFReferenceBaseType : QIFIdAndReferenceBaseType
	{
		public QIFReferenceBaseType() { }
	}
}
