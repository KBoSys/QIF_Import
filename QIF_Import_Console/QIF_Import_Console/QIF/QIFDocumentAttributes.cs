using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Import_Console.QIF
{
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFDocumentAttributes
	{

		private QIFDocumentAttributesAttributeBool attributeBoolField;

		private QIFDocumentAttributesAttributeStr attributeStrField;

		private QIFDocumentAttributesAttributeTime attributeTimeField;

		private byte nField;

		/// <remarks/>
		public QIFDocumentAttributesAttributeBool AttributeBool
		{
			get
			{
				return this.attributeBoolField;
			}
			set
			{
				this.attributeBoolField = value;
			}
		}

		/// <remarks/>
		public QIFDocumentAttributesAttributeStr AttributeStr
		{
			get
			{
				return this.attributeStrField;
			}
			set
			{
				this.attributeStrField = value;
			}
		}

		/// <remarks/>
		public QIFDocumentAttributesAttributeTime AttributeTime
		{
			get
			{
				return this.attributeTimeField;
			}
			set
			{
				this.attributeTimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
		{
			get
			{
				return this.nField;
			}
			set
			{
				this.nField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFDocumentAttributesAttributeBool
	{

		private bool valueField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFDocumentAttributesAttributeStr
	{

		private string valueField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFDocumentAttributesAttributeTime
	{

		private System.DateTime valueField;

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public System.DateTime value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
	}
}
