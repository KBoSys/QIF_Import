﻿/*! \file SensorType.cs
	\brief Defines a sensor measurement resource.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.MeasurementResources
{
	/// <remarks The SensorType defines a sensor measurement resource./>
	public class SensorType : MeasurementResourceBaseType
	{
		/// <remarks The optional ProtectionClass element is the protection level of a sensor in the environment./>
		[XmlElement(IsNullable = true)]
		public string ProtectionClass { get; set; }

		/// <remarks The optional LinearityError element is the error in the
		/// linearity of a sensor.Linearity error is usually specified
		/// as percentage of Full Scale Output (FSO)./>
		[XmlElement(IsNullable = true)]
		public string LinearityError { get; set; }

		/// <remarks The optional Repeatability element is the repeatability of a sensor./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType Repeatability { get; set; }

		/// <remarks The optional Sensitivity element is the sensitivity of a sensor./>
		[XmlElement(IsNullable = true)]
		public DecimalType Sensitivity { get; set; }

		/// <remarks The optional Resolution element is the resolution of a sensor./>
		[XmlElement(IsNullable = true)]
		public Units.LinearValueType Resolution { get; set; }

		/// <remarks The optional EnvironmentalRange element describes the
		/// range of environment in which the device may be used for
		/// producing usable measurements./>
		[XmlElement(IsNullable = true)]
		public EnvironmentalRangeType EnvironmentalRange { get; set; }
	}
}
