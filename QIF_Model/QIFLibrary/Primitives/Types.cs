/*! \file Types.cs
    \brief Defines different types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml.Serialization;
using QIF_Model.QIFApplications;
using System.Xml;

namespace QIF_Model.QIFLibrary.Primitives
{
	/// <summary>
	/// The BinaryDataType represents a Base64-encoded arbitrary binary
	/// data block.For base64Binary data the entire binary stream is
	/// encoded using the Base64 Alphabet in RFC 2045.
	/// </summary>
	public class BinaryDataType : TypeAlias<System.Byte[]>
	{
		public BinaryDataType()
		{
		}
		private BinaryDataType(System.Byte[] value)
		{
			base._value = value;
		}
		/// Implicit conversion from System.Byte[] to BinaryDataType 
		public static implicit operator BinaryDataType(System.Byte[] value)
		{
			return new BinaryDataType(value);
		}
		/// Implicit conversion to a System.Byte[].
		public static implicit operator System.Byte[](BinaryDataType alias)
		{
			return alias;
		}

		/// <summary>
		/// The required count attribute is the number of bytes in the binary block.
		/// </summary>
		[System.Xml.Serialization.XmlAttributeAttribute("count")]
		public NaturalType Count { get => (System.UInt32)Value.Length; }
	}

	/// <summary>
	/// The ListIntType is a list of integer numbers.
	/// </summary>
	public class ListIntType : TypeAlias<System.Int32[]>
	{
		public ListIntType(uint size)
		{
			Value = new System.Int32[size];
		}
		protected ListIntType(System.Int32[] value)
		{
			base._value = value;
		}
		/// Implicit conversion from System.Int32[] to ListIntType 
		public static implicit operator ListIntType(System.Int32[] value)
		{
			return new ListIntType(value);
		}
		/// Implicit conversion to a System.Int32[].
		public static implicit operator System.Int32[](ListIntType alias)
		{
			return alias;
		}
	}

	/// <summary>
	/// The I2Type is an array of two integer values.
	/// </summary>
	public class I2Type : ListIntType
	{
		public I2Type() : base(2)
		{
		}
		private I2Type(int[] value) : base(value) { }

		/// Implicit conversion from System.Int32[] to ListIntType 
		public static implicit operator I2Type(int[] value)
		{
			return new I2Type(value);
		}
	}

	/// <summary>
	/// The I3Type is an array of three integer values.
	/// </summary>
	public class I3Type : ListIntType
	{
		public I3Type() : base(3)
		{
		}
		private I3Type(int[] value) : base(value) { }

		/// Implicit conversion from System.Int32[] to ListIntType 
		public static implicit operator I3Type(int[] value)
		{
			return new I3Type(value);
		}
	}

	/// <summary>
	/// The D2Type is an array of two double values.
	/// </summary>
	public class D2Type : ListDoubleType
	{
		public D2Type() : base(2)
		{
		}
		protected D2Type(double[] value) : base(value) { }

		/// Implicit conversion from System.Int32[] to ListIntType 
		public static implicit operator D2Type(double[] value)
		{
			return new D2Type(value);
		}
	}

	/// <summary>
	/// The D3Type is an array of three double values.
	/// </summary>
	public class D3Type : ListDoubleType
	{
		public D3Type() : base(3)
		{
		}
		private D3Type(double[] value) : base(value) { }

		/// Implicit conversion from System.Int32[] to ListIntType 
		public static implicit operator D3Type(double[] value)
		{
			return new D3Type(value);
		}
	}

	/// <remarks The ArrayI3Type is an array of integer numbers representing a
	/// specific number of ordered triplets of integers.Each successive
	/// group of three entries in the array represents the first, second
	/// and third components of a triplet./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlRoot()]
	public partial class ArrayI3Type : TypeAlias<I3Type[]>
	{
		/// <remarks The required count attribute gives the number of integer
		/// triplets represented by the array. The number of entries in the array must be 3*count./>
		[System.Xml.Serialization.XmlAttributeAttribute("count")]
		public uint Count
		{
			get => (uint)base.Value.Length;
			set { }
		}
	}

	/// <summary>
	/// The ListDoubleType is an array of double values.
	/// </summary>
	public class ListDoubleType : TypeAlias<System.Double[]>
	{
		public ListDoubleType()
		{
		}
		public ListDoubleType(uint size)
		{
			Value = new System.Double[size];
		}
		protected ListDoubleType(System.Double[] value)
		{
			base._value = value;
		}
		/// Implicit conversion from System.Double[] to ListDoubleType
		public static implicit operator ListDoubleType(System.Double[] value)
		{
			return new ListDoubleType(value);
		}
		/// Implicit conversion to a System.Double[].
		public static implicit operator System.Double[](ListDoubleType alias)
		{
			return alias;
		}

		#region Xml Serialization Infrastructure
		public override string ToString()
		{
			string value = string.Join(" ", Value);
			return value;
		}

		public override void WriteXml(XmlWriter writer)
		{
			writer.WriteString(ToString());
		}

		public override void ReadXml(XmlReader reader)
		{
			string value = reader.ReadElementContentAsString();
			string[] parts = value.Split(' ');
			if (parts.Length == Value.Length)
			{
				for (int i = 0; i < parts.Length; ++i)
				{
					Value[i] = 0.0;
					double.TryParse(parts[i], out Value[i]);
				}
			}
		}
		public override System.Xml.Schema.XmlSchema GetSchema()
		{
			return (null);
		}
		#endregion
	}

	/// <summary>
	/// The ListBooleanType is an array of Boolean values.
	/// </summary>
	public class ListBooleanType : List<System.Boolean>
	{
		public ListBooleanType()
		{
		}
	}

	/// <summary>
	/// The ListDateTimeType is an array of date-time values.
	/// </summary>
	public class ListDateTimeType : List<System.DateTime>
	{
		public ListDateTimeType()
		{
		}
	}

	/// <summary>
	/// The ListTokenType is a list of string tokens.
	/// </summary>
	public class ListTokenType : List<System.String>
	{
		public ListTokenType()
		{
		}
	}
	public class DoublePositiveType : TypeAlias<System.Double>
	{
		public DoublePositiveType()
		{
		}
		private DoublePositiveType(System.Double value)
		{
			base._value = Math.Abs(value);
		}
		public static implicit operator DoublePositiveType(System.Double value)
		{
			return new DoublePositiveType(value);
		}
		public static implicit operator System.Double (DoublePositiveType value)
		{
			return value.Value;
		}
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
		public QPIdType() { }

		[XmlText]
		public string Value { get; set; }

		//TODO:
		//<xs:restriction base="xs:token">
		//<xs:pattern value = "[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}" />
		//</ xs:restriction>
	}

	/// <summary>
	/// The QPIdReferenceType defines the text representation of the
	/// universally unique identifier described in the standard ISO/IEC
	/// 9834-8. As a number, it has 128 bits.As a text string it is
	/// represented by 32 hexadecimal digits displayed in five groups
	/// separated by hyphens in the form 8-4-4-4-12, for a total of 36
	/// characters.example: fd43400a-29bf-4ec6-b96c-e2f846eb6ff6
	/// </summary>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class QPIdReferenceType
	{
		public QPIdReferenceType() { }

		[XmlText]
		public string Value { get; set; }

		//TODO:
		//<xs:restriction base="xs:token">
		//<xs:pattern value = "[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}" />
		//</ xs:restriction>
	}

	/// <summary>
	/// The FractionType is a fraction value. 
	/// </summary>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class FractionType
	{
		/// <remarks The Numerator element is the numerator of the fraction./>
		[XmlElement]
		public NaturalType NumeratorValue { get; set; }

		/// <remarks The Denominator element is the denominator of the fraction./>
		[XmlElement]
		public NaturalType Denominator { get; set; }
	}

	/// <summary>
	/// The ListNaturalType is an array of natural numbers.
	/// </summary>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class ListNaturalType : List<NaturalType>
	{
	}

	/// <summary>
	/// The Natural2Type is an array of two Natural values.
	/// </summary>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class Natural2Type : ListNaturalType
	{
		public Natural2Type() { }
	}

	/// <summary>
	/// The SweepType defines a partial feature using a vector and an angle.
	/// </summary>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class SweepType
	{
		/// <remarks The DirBeg element is a unit vector representing the beginning extent of the feature./>
		[XmlElement]
		public UnitVectorType DirBeg { get; set; }

		/// <remarks The DomainAngle element is the angle limits in angular units from the start vector to the start extent of the feature./>
		[XmlElement]
		public AngleRangeType DomainAngle { get; set; }
	}

	/// <summary>
	/// The AngleRangeType defines an angle range.
	/// </summary>
	public class AngleRangeType : D2Type
	{
		/// <remarks The DirBeg element is a unit vector representing the beginning extent of the feature./>
		[XmlAttribute("angularUnit")]
		public string UnitName { get; set; }
	}

	/// <remarks The QIFFeaturePairType defines a pair of feature references and
	/// optionally defines feature zones for either or both features.This
	/// type is used to define the two features participating in a distance	between or angle between characteristic./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class QIFFeaturePairType
	{
		/// <remarks The FirstFeature element is a reference to a QIF feature id that may include an AsmPath./>
		public QIFReferenceFullType FirstFeature { get; set; }

		/// <remarks The SecondFeature element is a reference to a QIF feature id that may include an AsmPath./>
		public QIFReferenceFullType SecondFeature { get; set; }

		/// <remarks The optional FirstFeatureZone element is a reference to a QIF
		/// zone feature id that may include an AsmPath.This feature zone is applied to the first feature./>
		public QIFReferenceFullType FirstFeatureZone { get; set; }

		/// <remarks The optional SecondFeatureZone element is a reference to a QIF
		/// zone feature id that may include an AsmPath.This feature zone is applied to the second feature./>
		public QIFReferenceFullType SecondFeatureZone { get; set; }
	}

	/// <remarks The ArrayReferenceFullType is an array of references to object IDs./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class ArrayPairReferenceFullType
	{
		/// <remarks The Id element is reference to a QIF id that may include an AsmPath./>
		[System.Xml.Serialization.XmlElementAttribute("FeaturePair")]
		public QIFFeaturePairType[] FeaturePairs { get; set; }

		/// <remarks The required n attribute is the number of Id elements in this array./>
		[System.Xml.Serialization.XmlAttributeAttribute("n")]
		public uint Count
		{
			get => (uint)this.FeaturePairs.Length;
			set {}
		}
	}

	/// <remarks The ArrayDoubleType is an array of double values./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class ArrayDoubleType : ListDoubleType
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("count")]
		public uint Count
		{
			get => (uint)base.Value.Length;
			set { }
		}
	}

	/// <remarks The ArrayNaturalType is an array of natural numbers./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class ArrayNaturalType : ListNaturalType
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("count")]
		public uint Count
		{
			get => (uint)base.Count;
			set { }
		}
	}
}
