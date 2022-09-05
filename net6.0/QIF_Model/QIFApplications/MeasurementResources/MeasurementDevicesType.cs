/*! \file MeasurementDevicesType.cs
	\brief Defines a list of measurement devices.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The MeasurementDevicesType defines a list of measurement devices.</remarks>
    public class MeasurementDevicesType : ArrayBaseType<MeasurementDeviceType>
    {
        /// <remarks> Each MeasurementDevice element gives information about a measurement device.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDevice")]
        [System.Xml.Serialization.XmlElementAttribute("Caliper", typeof(CaliperType))]
        [System.Xml.Serialization.XmlElementAttribute("CaliperDial", typeof(CaliperDialType))]
        [System.Xml.Serialization.XmlElementAttribute("CaliperDigital", typeof(CaliperDigitalType))]
        [System.Xml.Serialization.XmlElementAttribute("Micrometer", typeof(MicrometerType))]
        [System.Xml.Serialization.XmlElementAttribute("MicrometerAnalog", typeof(MicrometerAnalogType))]
        [System.Xml.Serialization.XmlElementAttribute("MicrometerDigital", typeof(MicrometerDigitalType))]
        [System.Xml.Serialization.XmlElementAttribute("GageDevice", typeof(GageDeviceType))]
        [System.Xml.Serialization.XmlElementAttribute("SineBar", typeof(SineBarType))]
        [System.Xml.Serialization.XmlElementAttribute("ManualMeasurementDevice", typeof(ManualMeasurementDeviceType))]
        [System.Xml.Serialization.XmlElementAttribute("Microscope", typeof(MicroscopeType))]
        [System.Xml.Serialization.XmlElementAttribute("Autocollimator", typeof(AutocollimatorType))]
        [System.Xml.Serialization.XmlElementAttribute("OpticalComparator", typeof(OpticalComparatorType))]
        [System.Xml.Serialization.XmlElementAttribute("UniversalLengthMeasuring", typeof(UniversalLengthMeasuringType))]
        [System.Xml.Serialization.XmlElementAttribute("LaserRadar", typeof(LaserRadarType))]
        [System.Xml.Serialization.XmlElementAttribute("LaserTracker", typeof(LaserTrackerType))]
        [System.Xml.Serialization.XmlElementAttribute("ComputedTomography", typeof(ComputedTomographyType))]
        [System.Xml.Serialization.XmlElementAttribute("Theodolite", typeof(TheodoliteType))]
        [System.Xml.Serialization.XmlElementAttribute("AACMM", typeof(AACMMType))]
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMM", typeof(CartesianCMMType))]
        [System.Xml.Serialization.XmlElementAttribute("MultipleCarriageCartesianCMM", typeof(MultipleCarriageCartesianCMMType))]
        [System.Xml.Serialization.XmlElementAttribute("ParallelLinkCMM", typeof(ParallelLinkCMMType))]
        [System.Xml.Serialization.XmlElementAttribute("LightPenCMM", typeof(LightPenCMMType))]
        public MeasurementDeviceType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The MeasurementDeviceType defines a measurement device. A
    /// MeasurementDevice includes all components needed for making	measurements.</remarks>
    public class MeasurementDeviceType : MeasurementResourceBaseType
    {
        /// <remarks> The optional Calibrations element is a list of calibrations for a measurement device.</remarks>
        [XmlElement]
        public CalibrationsType Calibrations { get; set; }

        /// <remarks> The optional EnvironmentalRange element describes the
        /// range of environments in which the device may be used for producing usable measurements.</remarks>
        [XmlElement]
        public EnvironmentalRangeType EnvironmentalRange { get; set; }
    }

    /// <remarks> The TemperatureCompensationEnumType enumerates values that describe
    /// types of temperature compensation.The DEVICE_AND_PART_SAME value
    /// means compensation is performed for both device temperature and
    /// part temperature, but the two temperatures are assumed to be the
    /// same. The DEVICE_AND_PART_SEPARATE value means temperature
    /// compensation is applied to both device and part, but the two
    /// temperatures are measured separately.</remarks>
    public enum TemperatureCompensationEnumType
    {
        NONE, DEVICE_ONLY, DEVICE_AND_PART_SAME, DEVICE_AND_PART_SEPARATE
    }

    /// <remarks> The TemperatureCompensationType defines the type of temperature compensation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TemperatureCompensationType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("OtherTemperatureCompensation", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TemperatureCompensationEnum", typeof(TemperatureCompensationEnumType))]
        public object? Item { get; set; }
    }
}
