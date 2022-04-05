using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFDocument
{
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class Attributes
	{
		/// <remarks/>
		public QIFDocumentAttributesAttributeBool AttributeBool { get; set; }

		/// <remarks/>
		public QIFDocumentAttributesAttributeStr AttributeStr { get; set; }

		/// <remarks/>
		public QIFDocumentAttributesAttributeTime AttributeTime { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public UInt32 n { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFDocumentAttributesAttributeBool
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool value { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFDocumentAttributesAttributeStr
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string value { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name { get; set; }
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFDocumentAttributesAttributeTime
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public System.DateTime value { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name { get; set; }
	}
}
