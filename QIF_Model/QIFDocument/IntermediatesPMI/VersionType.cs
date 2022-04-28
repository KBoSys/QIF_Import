/*! \file VersionType.cs

        The VersionBase Type defines basic information about a
        version of a QIF instance file and is the base type for other
        version types.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class VersionBaseType
	{
		public VersionBaseType() { }

		/// <remarks The optional TimeCreated element gives the time when the version was created/>
		[XmlElement(IsNullable = true)]
		public Nullable<System.DateTime> TimeCreated { get; set; }

		/// <remarks The optional SignOffs element identifies the employees who signed off on the version./>
		[XmlElement(IsNullable = true)]
		public SignOffsType SignOffs { get; set; }
	}

	/// <remarks The VersionType defines information about the version of the QIF instance file in which the VersionType is placed./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class VersionType : VersionBaseType
	{
		/// <remarks The optional ThisInstanceQPId element is a UUID identifier of a version of a QIF instance file./>
		[XmlElement(IsNullable = true)]
		public Primitives.QPIdType ThisInstanceQPId;
	}
}
