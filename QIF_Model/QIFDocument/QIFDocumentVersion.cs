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
	public partial class QIFDocumentVersion
	{

		private System.DateTime timeCreatedField;

		private QIFDocumentVersionSignOffs signOffsField;

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
		public QIFDocumentVersionSignOffs SignOffs
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
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFDocumentVersionSignOffs
	{

		private QIFDocumentVersionSignOffsEmployee[] employeeField;

		private uint nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Employee")]
		public QIFDocumentVersionSignOffsEmployee[] Employee
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
	public partial class QIFDocumentVersionSignOffsEmployee
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
