﻿/*! \file CalibrationsType.cs
	\brief Defines a list of calibrations..

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The CalibrationsType defines a list of calibrations.</remarks>
    public class CalibrationsType : ArrayBaseType<CalibrationType>
    {
        /// <remarks> Each Calibration element gives information about a calibration.</remarks>
        [XmlElement("Calibration", Type = typeof(CalibrationType))]
        public CalibrationType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The CalibrationMasterType defines a calibration master.</remarks>
    public class CalibrationMasterType
    {
        /// <remarks> The SerialNumber element is the serial number of a calibration master.</remarks>
        public string? SerialNumber { get; set; } = "";

        /// <remarks> The optional description element is the description of a calibration master.</remarks>
        [XmlElement]
        public string? Description { get; set; } = "";
    }

    /// <remarks> The CalibrationType defines information about a calibration.</remarks>
    public class CalibrationType
    {
        /// <remarks> The optional CalibrationMaster element gives information about the calibration master.</remarks>
        [XmlElement]
        public CalibrationMasterType? CalibrationMaster { get; set; }

        /// <remarks> The Temperatures element is a list of temperatures noted for the calibration.</remarks>
        [XmlElement]
        public TemperaturesType Temperatures { get; set; } = new TemperaturesType();

        /// <remarks> The CalibrationDate element is the date and time that the calibration took place.</remarks>
        [XmlElement]
        public DateTime CalibrationDate { get; set; } = new DateTime();

        /// <remarks> The ExpirationDate element is the date and time that the calibration expires.</remarks>
        [XmlElement]
        public DateTime ExpirationDate { get; set; } = new DateTime();
    }
}
