/*! \file FileType.cs
	\brief The FileType defines file information.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class FileType
	{
		public FileType() { }

		//! The Name element is the fully qualified identifier (URI) of the file.
		[XmlElement]
		public string Name { get; set; }

		//! The optional Version element is the version number of the file.
		[XmlElement]
		public string Version { get; set; }

		//! The optional Format element is the file format.
		[XmlElement]
		public PrimitivesPMI.DigitalModelFormatType Format { get; set; }
	}
}
