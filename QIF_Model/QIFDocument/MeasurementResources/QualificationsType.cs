/*! \file QualificationsType.cs
	\brief Defines a list of sensor qualifications.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.MeasurementResources
{
	/// <remarks The QualificationsType defines a list of sensor qualifications./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class QualificationsType
	{
		/// <remarks Each Qualification element gives information about a sensor qualification. />
		[XmlElement("Qualification", Type = typeof(QualificationType))]
		public QualificationType[] Types { get; set; }

		/// <remarks The required n attribute gives the number of fixtures in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Types.Length;
		}
	}

	/// <remarks The QualificationType defines how a measurement device has been qualified./>
	public class QualificationType : Primitives.AttributesTypeHolder
	{
		/// <remarks The Description element is a description of the qualification.
		/// This may include items such as orientation information and environment information. />
		[XmlElement(IsNullable = true)]
		public string Description { get; set; }
	}
}
