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
	public class ListIntType : List<Decimal>
	{
	}
	/// <summary>
	/// The I2Type is an array of two integer values.
	/// </summary>
	public class I2Type : ListIntType
	{
		public I2Type()
		{
			Capacity = 2;
		}
	}
	/// <summary>
	/// The I3Type is an array of three integer values.
	/// </summary>
	public class I3Type : ListIntType
	{
		public I3Type()
		{
			Capacity = 3;
		}
	}
}
	