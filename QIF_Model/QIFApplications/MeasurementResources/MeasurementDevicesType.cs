/*! \file MeasurementDevicesType.cs
	\brief Defines a list of measurement devices.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks The MeasurementDevicesType defines a list of measurement devices./>
    public class MeasurementDevicesType
    {
        /// <remarks Each MeasurementDevice element gives information about a measurement device./>
        [XmlElement("MeasurementDevice", Type = typeof(MeasurementDeviceType))]
        [XmlElement("UniversalDevice", Type = typeof(UniversalDeviceType))]
        public MeasurementDeviceType[] MeasurementDevices { get; set; }

        /// <remarks The required n attribute is the number of measurement devices in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.MeasurementDevices.Length;
            set { }
        }
    }

    /// <remarks The MeasurementDeviceType defines a measurement device. A
    /// MeasurementDevice includes all components needed for making	measurements./>
    public class MeasurementDeviceType : MeasurementResourceBaseType
    {
        /// <remarks The optional Calibrations element is a list of calibrations for a measurement device./>
        [XmlElement()]
        public CalibrationsType Calibrations { get; set; }

        /// <remarks The optional EnvironmentalRange element describes the
        /// range of environments in which the device may be used for producing usable measurements./>
        [XmlElement()]
        public EnvironmentalRangeType EnvironmentalRange { get; set; }
    }

    /// <remarks The UniversalDeviceType defines a universal measurement device. Any
    /// nonmanual device that has a working volume, an effective working
    /// volume, and a resolution is considered to be a universal device./>
    public class UniversalDeviceType : MeasurementDeviceType
    {
        /// <remarks The optional Resolution element is the resolution of a universal measurement device./>
        [XmlElement("LinearResolution", Type = typeof(LinearResolutionType))]
        [XmlElement("CartesianResolution", Type = typeof(CartesianResolutionType))]
        [XmlElement("SphericalResolution", Type = typeof(SphericalResolutionType))]
        [XmlElement("UserDefinedResolution", Type = typeof(UserDefinedResolutionType))]
        public ResolutionBaseType Resolution { get; set; }

        /// <remarks The optional WorkingVolume element is the working volume of a universal measurement device./>
        [XmlElement("ClosedShellSetWorkingVolume", Type = typeof(ClosedShellSetWorkingVolumeType))]
        [XmlElement("CartesianWorkingVolume", Type = typeof(CartesianWorkingVolumeType))]
        [XmlElement("SphericalWorkingVolume", Type = typeof(SphericalWorkingVolumeType))]
        [XmlElement("CylindricalWorkingVolume", Type = typeof(CylindricalWorkingVolumeType))]
        [XmlElement("UserDefinedWorkingVolume", Type = typeof(UserDefinedWorkingVolumeType))]
        public WorkingVolumeBaseType WorkingVolume { get; set; }

        /// <remarks The optional EffectiveWorkingVolume element is the
        /// effective working volume of a universal measurement device./>
        [XmlElement("EffectiveClosedShellSetWorkingVolume", Type = typeof(EffectiveClosedShellSetWorkingVolumeType))]
        [XmlElement("EffectiveCartesianWorkingVolume", Type = typeof(EffectiveCartesianWorkingVolumeType))]
        [XmlElement("EffectiveSphericalWorkingVolume", Type = typeof(EffectiveSphericalWorkingVolumeType))]
        [XmlElement("EffectiveCylindricalWorkingVolume", Type = typeof(EffectiveCylindricalWorkingVolumeType))]
        [XmlElement("EffectiveUserDefinedWorkingVolume", Type = typeof(EffectiveUserDefinedWorkingVolumeType))]
        public EffectiveWorkingVolumeBaseType EffectiveWorkingVolume { get; set; }

        /// <remarks The optional TemperatureCompensation element is the
        /// temperature compensation of a universal measurement device./>
        [XmlElement()]
        public TemperatureCompensationType TemperatureCompensation { get; set; }
    }

    /// <remarks The TemperatureCompensationEnumType enumerates values that describe
    /// types of temperature compensation.The DEVICE_AND_PART_SAME value
    /// means compensation is performed for both device temperature and
    /// part temperature, but the two temperatures are assumed to be the
    /// same. The DEVICE_AND_PART_SEPARATE value means temperature
    /// compensation is applied to both device and part, but the two
    /// temperatures are measured separately./>
    public enum TemperatureCompensationEnumType
    {
        NONE, DEVICE_ONLY, DEVICE_AND_PART_SAME, DEVICE_AND_PART_SEPARATE
    }

    /// <remarks The TemperatureCompensationType defines the type of temperature compensation./>
    public class TemperatureCompensationType
    {
        #region Choice
        /// <remarks The TemperatureCompensationEnum element describes an often-used type of temperature compensation./>
        [XmlElement()]
        public TemperatureCompensationEnumType TemperatureCompensationEnum { get; set; }

        /// <remarks The OtherTemperatureCompensation element describes a type of temperature compensation in natural language./>
        [XmlElement()]
        public string OtherTemperatureCompensation { get; set; }
        #endregion
    }
}
