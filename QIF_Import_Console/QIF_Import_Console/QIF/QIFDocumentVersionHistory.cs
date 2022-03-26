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
	public partial class QIFDocumentVersionHistory
	{

		private QIFDocumentVersionHistoryEarlierVersion[] earlierVersionField;

		private byte nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("EarlierVersion")]
		public QIFDocumentVersionHistoryEarlierVersion[] EarlierVersion
		{
			get
			{
				return this.earlierVersionField;
			}
			set
			{
				this.earlierVersionField = value;
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
	public partial class QIFDocumentVersionHistoryEarlierVersion
	{

		private System.DateTime timeCreatedField;

		private QIFDocumentVersionHistoryEarlierVersionSignOffs signOffsField;

		private string qPIdReferenceField;

		/// <remarks/>
		public System.DateTime TimeCreated
		{
			get
			{
				return this.timeCreatedField;
			}
			set
			{
				this.timeCreatedField = value;
			}
		}

		/// <remarks/>
		public QIFDocumentVersionHistoryEarlierVersionSignOffs SignOffs
		{
			get
			{
				return this.signOffsField;
			}
			set
			{
				this.signOffsField = value;
			}
		}

		/// <remarks/>
		public string QPIdReference
		{
			get
			{
				return this.qPIdReferenceField;
			}
			set
			{
				this.qPIdReferenceField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFDocumentVersionHistoryEarlierVersionSignOffs
	{

		private QIFDocumentVersionHistoryEarlierVersionSignOffsEmployee[] employeeField;

		private uint nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Employee")]
		public QIFDocumentVersionHistoryEarlierVersionSignOffsEmployee[] Employee
		{
			get
			{
				return this.employeeField;
			}
			set
			{
				this.employeeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public uint n
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
	public partial class QIFDocumentVersionHistoryEarlierVersionSignOffsEmployee
	{

		private string nameField;

		private string employeeIdField;

		private string shiftField;

		/// <remarks/>
		public string Name
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

		/// <remarks/>
		public string EmployeeId
		{
			get
			{
				return this.employeeIdField;
			}
			set
			{
				this.employeeIdField = value;
			}
		}

		/// <remarks/>
		public string Shift
		{
			get
			{
				return this.shiftField;
			}
			set
			{
				this.shiftField = value;
			}
		}
	}

}
