/*! \file QIFReferenceType.cs

        The QIFReferenceType defines a reference to a QIF id that may be in
        the same file as the reference or may be in an identified external
        file. In order to ensure that each reference refers to an object of
        the correct type, where possible, each reference is covered by an
        appropriate key/keyref constraint.

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
	public class QIFReferenceType : QIFReferenceBaseType
	{
		public QIFReferenceType() { }
	}
}
