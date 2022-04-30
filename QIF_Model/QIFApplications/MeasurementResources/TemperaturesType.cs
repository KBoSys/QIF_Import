/*! \file TemperaturesType.cs
	\brief Defines a list of temperatures.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
	/// <remarks The TemperaturesType defines a list of temperatures./>
	public class TemperaturesType
	{
		/// <remarks Each Temperature element is a temperature noted for a machine./>
		[XmlElement("Temperature", Type = typeof(TemperatureType))]
		public TemperatureType[] TemperatureTypes { get; set; }

		/// <remarks The required n attribute is the number of temperatures in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.TemperatureTypes.Length;
		}
	}

	/// <remarks The TemperatureType defines information about a temperature measurement./>
	public class TemperatureType
	{
		/// <remarks The optional Attributes element contains user defined attributes (typified, binary array, or XML structured)./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.AttributesType Attributes { get; set; }

		/// <remarks The Temperature element is the temperature value./>
		[XmlElement(IsNullable = false)]
		public QIFLibrary.Units.TemperatureValueType Temperature { get; set; }

		/// <remarks The optional TimeStamp element is a time and date associated with the temperature value./>
		[XmlElement(IsNullable = true)]
		public Nullable<DateTime> TimeStamp { get; set; }
	}
}
