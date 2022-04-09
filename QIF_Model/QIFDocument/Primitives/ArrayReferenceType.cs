/*! \file ArrayReferenceType.cs
	\brief The ArrayReferenceType is an array of references to object IDs.

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
	public class ArrayReferenceType
	{
		private QIFReferenceType[] references;
		public ArrayReferenceType() { }

		/// <remarks Each Id element is a reference to the QIF id of an object./>
		[XmlElement(ElementName = "Id", Type = typeof(QIFReferenceType))]
		public QIFReferenceType[] References { get => this.references; set => this.references = value; }

		/// <remarks The required n attribute is the number of employees in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.references.Length;
		}
	}
}
