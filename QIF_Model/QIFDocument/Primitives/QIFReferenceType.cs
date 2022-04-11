/*! \file QIFReferenceType.cs

        The QIFReferenceType defines a reference to a QIF id that may be in
        the same file as the reference or may be in an identified external
        file. In order to ensure that each reference refers to an object of
        the correct type, where possible, each reference is covered by an
        appropriate key/keyref constraint.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Primitives
{
	public class QIFReferenceType : QIFReferenceBaseType
	{
		public QIFReferenceType() { }
		public QIFReferenceType(System.UInt32 value) : base(value) { }

		/// Implicit conversion from System.UInt32 to UInt32Type 
		public static implicit operator QIFReferenceType(System.UInt32 value)
		{
			return new QIFReferenceType(value);
		}
	}

	/// <summary>
	/// The QIFReferenceSimpleType defines the type for simple references
	/// to 'id' attributes.It has no external id and no asm path.
	/// </summary>
	public class QIFReferenceSimpleType : QIFReferenceBaseType
	{
		public QIFReferenceSimpleType() { }
		public QIFReferenceSimpleType(System.UInt32 value) : base(value) { }

		/// Implicit conversion from System.UInt32 to UInt32Type 
		public static implicit operator QIFReferenceSimpleType(System.UInt32 value)
		{
			return new QIFReferenceSimpleType(value);
		}
	}
}
