/*! \file EnvironmentalRangeType.cs
	\brief Describes a range of environmental conditions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
	/// <remarks The EnvironmentalRangeType describes a range of environmental conditions./>
	public class EnvironmentalRangeType
	{
		/// <remarks The optional Name element is the name of the environmental range./>
		[XmlElement(IsNullable = true)]
		public string Name { get; set; }

		/// <remarks The optional Description element is a description of the environmental range./>
		[XmlElement(IsNullable = true)]
		public string Description { get; set; }

		/// <remarks The optional MaxAmbientTemperature element is the maximum ambient temperature of the range./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Units.TemperatureValueType MaxAmbientTemperature { get; set; }

		/// <remarks The optional MinAmbientTemperature element is the minimum ambient temperature of the range./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Units.TemperatureValueType MinAmbientTemperature { get; set; }

		/// <remarks The optional MaxAmbientAirPressure element is the maximum ambient air pressure of the range./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Units.PressureValueType MaxAmbientAirPressure { get; set; }

		/// <remarks The optional MinAmbientAirPressure element is the minimum ambient air pressure of the range./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Units.PressureValueType MinAmbientAirPressure { get; set; }

		/// <remarks The optional MaxAmbientRelativeHumidity element is the maximum ambient relative humidity of the range./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Units.SpecifiedDecimalType MaxAmbientRelativeHumidity { get; set; }

		/// <remarks The optional MinAmbientRelativeHumidity element is the minimum ambient relative humidity of the range./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Units.SpecifiedDecimalType MinAmbientRelativeHumidity { get; set; }

		/// <remarks The optional MaxVibration element is the maximum vibration of the range.The minimum is zero./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Units.UserDefinedUnitValueType MaxVibration { get; set; }

		/// <remarks The optional Attributes element contains user defined attributes (typified, binary array, or XML structured)./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.AttributesType Attributes { get; set; }
	}
}
