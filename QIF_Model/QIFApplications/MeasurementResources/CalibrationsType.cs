/*! \file CalibrationsType.cs
	\brief Defines a list of calibrations..

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
	/// <remarks The CalibrationsType defines a list of calibrations./>
	public class CalibrationsType
	{
		/// <remarks Each Calibration element gives information about a calibration./>
		[XmlElement("Calibration", Type = typeof(CalibrationType))]
		public CalibrationType[] Calibrations { get; set; }

		/// <remarks The required n attribute is the number of calibrations in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Calibrations.Length;
		}
	}

	/// <remarks The CalibrationMasterType defines a calibration master./>
	public class CalibrationMasterType
	{
		/// <remarks The SerialNumber element is the serial number of a calibration master./>
		[XmlElement(IsNullable = false)]
		public string SerialNumber { get; set; }

		/// <remarks The optional description element is the description of a calibration master./>
		[XmlElement(IsNullable = true)]
		public string Description { get; set; }
	}

	/// <remarks The CalibrationType defines information about a calibration./>
	public class CalibrationType
	{
		/// <remarks The optional CalibrationMaster element gives information about the calibration master./>
		[XmlElement(IsNullable = true)]
		public CalibrationMasterType CalibrationMaster { get; set; }

		/// <remarks The Temperatures element is a list of temperatures noted for the calibration./>
		[XmlElement(IsNullable = false)]
		public TemperaturesType Temperatures { get; set; }

		/// <remarks The CalibrationDate element is the date and time that the calibration took place./>
		[XmlElement(IsNullable = false)]
		public DateTime CalibrationDate { get; set; }

		/// <remarks The ExpirationDate element is the date and time that the calibration expires./>
		[XmlElement(IsNullable = false)]
		public DateTime ExpirationDate { get; set; }
	}
}
