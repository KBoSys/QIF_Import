/*! \file Types.cs
    \brief Defines different types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace QIF_Model.QIFDocument.Primitives
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
		private ListIntType(System.Int32[] value)
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
	}
	/// <summary>
	/// The I3Type is an array of three integer values.
	/// </summary>
	public class I3Type : ListIntType
	{
		public I3Type() : base(3)
		{
		}
	}
	/// <summary>
	/// The ListDoubleType is an array of double values.
	/// </summary>
	public class ListDoubleType : TypeAlias<System.Double[]>
	{
		public ListDoubleType(uint size)
		{
			Value = new System.Double[size];
		}
		private ListDoubleType(System.Double[] value)
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
	}
	/// <summary>
	/// The D3Type is an array of three double values.
	/// </summary>
	public class D3Type : ListDoubleType
	{
		public D3Type() : base(3)
		{
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
	}
}
