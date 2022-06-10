/*! \file ExternalFileReferenceType.cs
	\brief Defines an external file reference

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
	/// <summary>
	/// The ExternalFileReferenceType defines an external file reference
	/// including the file's location, type and description.
	/// </summary>
	public class ExternalFileReferenceType
	{
		/// <remarks The URI element is a Uniform Resource Identifier for the
		/// information, which may be, for example, a file or a web site./>
		[XmlElement()]
		public QIFLibrary.Primitives.UriType URI { get; set; }

		/// <remarks The Description element is a description of the information in the file found at the URI./>
		[XmlElement()]
		public string Description { get; set; }
	}

	/// <summary>
	/// The ExternalFileReferencesType defines a list of external file references.
	/// </summary>
	public class ExternalFileReferencesType
	{
		/// <remarks Each ExternalQIFDocument element contains information about an external QIF document referenced by this QIF document./>
		[XmlElement("ExternalFileReference", Type = typeof(ExternalFileReferenceType))]
		public ExternalFileReferenceType[] ExternalFileReferences { get; set; }

		/// <remarks The required n attribute is the number of employees in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.ExternalFileReferences.Length;
			set { }
		}
	}
}
