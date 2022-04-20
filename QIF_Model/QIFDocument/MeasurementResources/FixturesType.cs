/*! \file FixturesType.cs
	\brief Defines a list of fixtures

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.MeasurementResources
{
	/// <remarks The FixturesType defines a list of fixtures. />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class FixturesType
	{
		/// <remarks Each Fixture element gives information about a fixture. />
		[XmlElement("Fixture", Type = typeof(FixtureType))]
		public FixtureType[] Fixtures { get; set; }

		/// <remarks The required n attribute gives the number of fixtures in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Fixtures.Length;
		}
	}

	/// <remarks The FixtureType defines a fixture measurement resource. />
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class FixtureType : MeasurementResourceBaseType
	{

	}
}
