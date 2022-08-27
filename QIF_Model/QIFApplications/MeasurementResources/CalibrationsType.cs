/*! \file CalibrationsType.cs
	\brief Defines a list of calibrations..

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The CalibrationsType defines a list of calibrations.</remarks>
    public class CalibrationsType
    {
        /// <remarks> Each Calibration element gives information about a calibration.</remarks>
        [XmlElement("Calibration", Type = typeof(CalibrationType))]
        public CalibrationType[] Calibrations { get; set; }

        /// <remarks> The required n attribute is the number of calibrations in the list.</remarks>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.Calibrations.Length;
            set { }
        }
    }

    /// <remarks> The CalibrationMasterType defines a calibration master.</remarks>
    public class CalibrationMasterType
    {
        /// <remarks> The SerialNumber element is the serial number of a calibration master.</remarks>
        [XmlElement(IsNullable = false)]
        public string SerialNumber { get; set; }

        /// <remarks> The optional description element is the description of a calibration master.</remarks>
        [XmlElement()]
        public string Description { get; set; }
    }

    /// <remarks> The CalibrationType defines information about a calibration.</remarks>
    public class CalibrationType
    {
        /// <remarks> The optional CalibrationMaster element gives information about the calibration master.</remarks>
        [XmlElement()]
        public CalibrationMasterType CalibrationMaster { get; set; }

        /// <remarks> The Temperatures element is a list of temperatures noted for the calibration.</remarks>
        [XmlElement(IsNullable = false)]
        public TemperaturesType Temperatures { get; set; }

        /// <remarks> The CalibrationDate element is the date and time that the calibration took place.</remarks>
        [XmlElement(IsNullable = false)]
        public DateTime CalibrationDate { get; set; }

        /// <remarks> The ExpirationDate element is the date and time that the calibration expires.</remarks>
        [XmlElement(IsNullable = false)]
        public DateTime ExpirationDate { get; set; }
    }
}
