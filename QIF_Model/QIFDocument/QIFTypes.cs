/*! \file QIFTypes.cs
    \brief Declaration of QIF Types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument
{
	/// <summary>
	/// Defines an alias type for the sealed base types
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class TypeAlias<T>
	{
		protected T _value;
		protected TypeAlias()
		{
			_value = default(T);
		}
		protected TypeAlias(T value)
		{
			this._value = value;
		}
		public T Value { get => _value; set => _value = value; }
	}

	/// <summary>
	/// Alias type for System.UInt32
	/// </summary>
	public class UInt32Type : TypeAlias<System.UInt32>
	{
		public UInt32Type()
		{
		}
		/// As we are using implicit conversions we can keep the constructor private
		protected UInt32Type(System.UInt32 value)
		{
			base._value = value;
		}
		/// Implicit conversion from System.UInt32 to UInt32Type 
		public static implicit operator UInt32Type(System.UInt32 value)
		{
			return new UInt32Type(value);
		}
		/// Implicit conversion to a System.UInt32.
		public static implicit operator System.UInt32(UInt32Type alias)
		{
			return alias.Value;
		}
	}

	/// <summary>
	/// The NaturalType is the natural number type (integer > 0).
	/// </summary>
	public class NaturalType : TypeAlias<System.UInt32>
	{
		public NaturalType()
		{
		}
		/// As we are using implicit conversions we can keep the constructor private
		private NaturalType(System.UInt32 value)
		{
			base._value = value;
		}
		/// Implicit conversion from System.UInt32 to NaturalType
		public static implicit operator NaturalType(System.UInt32 value)
		{
			return new NaturalType(value);
		}
		/// Implicit conversion to a System.UInt32.
		public static implicit operator System.UInt32(NaturalType alias)
		{
			return alias;
		}
	}

	/// <summary>
	/// Alias type for System.Decimal
	/// </summary>
	public class DecimalType : TypeAlias<System.Decimal>
	{
		public DecimalType()
		{
		}
		private DecimalType(System.Decimal value)
		{
			base._value = value;
		}
		/// Implicit conversion from System.Decimal to DecimalType 
		public static implicit operator DecimalType(System.Decimal value)
		{
			return new DecimalType(value);
		}
		/// Implicit conversion to a System.Decimal.
		public static implicit operator System.Decimal(DecimalType alias)
		{
			return alias;
		}
	}

	/// <summary>
	/// All local (i.e. not significant outside the instance file) identifiers in the QIF schemas are of type QIFIdType.
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class QIFIdType : UInt32Type
	{
		public QIFIdType() { }
		public QIFIdType(System.UInt32 value) : base(value) { }

		/// Implicit conversion from System.UInt32 to QIFIdType
		public static implicit operator QIFIdType(System.UInt32 value)
		{
			return new QIFIdType(value);
		}
	}

	//! Base class for all classes that have QIFIdType as an attribute
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class QIFIdTypeBase
	{
		public QIFIdTypeBase() { }

		/// <summary>
		/// The id attribute is the QIF id of the feature, used for referencing.
		/// </summary>
		[XmlIgnore]
		public QIFIdType QIFID { get; set; }

		/// <summary>
		/// The id attribute is the QIF id of the feature, used for referencing.
		/// </summary>
		[XmlAttribute]
		public UInt32 id { get => this.QIFID; set => this.QIFID = value; }
	}

	/// <summary>
	/// The QPIdType(QIF Persistent Identifier Type) is the text
	/// representation of the universally unique identifier described in
	/// the standard ISO/IEC 9834-8. As a number, it has 128 bits.As a
	/// text string it is represented by 32 hexadecimal digits displayed in
	/// five groups separated by hyphens in the form 8-4-4-4-12, for a
	/// total of 36 characters.example:
	/// fd43400a-29bf-4ec6-b96c-e2f846eb6ff6
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class QPIdType
	{
		private string value;

		public QPIdType() { }

		[XmlText]
		public string Value { get; set; }

		//TODO:
		//<xs:restriction base="xs:token">
		//<xs:pattern value = "[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}" />
		//</ xs:restriction>
	}
}
