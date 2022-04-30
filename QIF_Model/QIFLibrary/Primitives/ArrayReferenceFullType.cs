/*! \file ArrayReferenceFullType.cs
	\brief The ArrayReferenceFullType is an array of references to object IDs.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Primitives
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class ArrayReferenceFullType
	{
		public ArrayReferenceFullType() { }
		/// <remarks The Id element is a reference to a QIF id that may include an AsmPath./>
		[XmlElement(ElementName = "Id", Type = typeof(QIFReferenceFullType))]
		public List<QIFReferenceFullType> References { get; set; }

		/// <remarks The required n attribute is the number of full reference types in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.References.Count;
		}
	}
}
