/*! \file SensorType.cs
	\brief Defines a sensor measurement resource.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The SensorType defines a sensor measurement resource.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeCoupledDeviceCameraSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UltrasonicSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuredLightSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LaserTriangulationSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DifferentialVariableReluctanceTransducerSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MagnetoInductiveSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrawWireSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConfocalChromaticSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EddyCurrentSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DetachableSensorBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TactileProbeSensorBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComplexTactileProbeSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleTactileProbeSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CapacitiveSensorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearVariableDifferentialTransformerSensorType))]
    public class SensorType : MeasurementResourceBaseType
    {
        /// <remarks> The optional ProtectionClass element is the protection level of a sensor in the environment.</remarks>
        [XmlElement]
        public string? ProtectionClass { get; set; }

        /// <remarks> The optional LinearityError element is the error in the
        /// linearity of a sensor.Linearity error is usually specified
        /// as percentage of Full Scale Output (FSO).</remarks>
        [XmlElement]
        public string? LinearityError { get; set; }

        /// <remarks> The optional Repeatability element is the repeatability of a sensor.</remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? Repeatability { get; set; }

        /// <remarks> The optional Sensitivity element is the sensitivity of a sensor.</remarks>
        [XmlElement]
        public DecimalType? Sensitivity { get; set; }

        /// <remarks> The optional Resolution element is the resolution of a sensor.</remarks>
        [XmlElement]
        public QIFLibrary.Units.LinearValueType? Resolution { get; set; }

        /// <remarks> The optional EnvironmentalRange element describes the
        /// range of environment in which the device may be used for
        /// producing usable measurements.</remarks>
        [XmlElement]
        public EnvironmentalRangeType? EnvironmentalRange { get; set; }
    }

    /// <remarks> The ChargeCoupledDeviceCameraSensorType defines a Charge Coupled Device(CCD) camera.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ChargeCoupledDeviceCameraSensorType : SensorType
    {
        /// <remarks></remarks>
        public int NumberOfPixels { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfPixelsSpecified { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxReadoutFrequency { get; set; }

        /// <remarks></remarks>
        public LinearValueType? HorizontalFieldOfView { get; set; }

        /// <remarks></remarks>
        public LinearValueType? VerticalFieldOfView { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxReadNoise { get; set; }

        /// <remarks></remarks>
        public decimal MaxFrameRate { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxFrameRateSpecified { get; set; }

        /// <remarks></remarks>
        public LinearValueType? PixelSize { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? SustainedDataRate { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? DarkCurrent { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxPixelClockSpeed { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? Linearity { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxOutputVoltage { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UltrasonicSensorType : SensorType
    {
        /// <remarks></remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? SamplingFrequency { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? AppliedFrequency { get; set; }

        /// <remarks></remarks>
        public TimeValueType? MaxResponseTime { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? ShockTolerance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? VibrationTolerance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MinPowerSupplyVoltage { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxPowerSupplyVoltage { get; set; }
    }

    /// <remarks> The StructuredLightSensorType defines a sensor based on structured a light principle.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StructuredLightSensorType : SensorType
    {
        /// <remarks></remarks>
        public string? OutputFileFormat { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MeasurementFieldSize { get; set; }

        /// <remarks></remarks>
        public int NumberOfCameraPixels { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfCameraPixelsSpecified { get; set; }

        /// <remarks></remarks>
        public string? LightSource { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MeasurementRate { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ClosedShellSetWorkingVolume", typeof(ClosedShellSetWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("CartesianWorkingVolume", typeof(CartesianWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalWorkingVolume", typeof(SphericalWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("CylindricalWorkingVolume", typeof(CylindricalWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedWorkingVolume", typeof(UserDefinedWorkingVolumeType))]
        public WorkingVolumeBaseType? WorkingVolume { get; set; }

        /// <remarks></remarks>
        public LinearValueType? StandOffDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxPermissibleProbingError { get; set; }

        /// <remarks></remarks>
        public LaserType? Laser { get; set; }
    }

    /// <remarks> The TriangulationSensorType defines a laser sensor that operates
    /// based on a triangulation principle.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LaserTriangulationSensorType : SensorType
    {
        /// <remarks></remarks>
        public LinearValueType? AverageSpotDiameter { get; set; }

        /// <remarks></remarks>
        public string? LaserSafetyClass { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxMeasurementFrequency { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public string? HousingMaterial { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? PermissibleAmbientLight { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? ShockTolerance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? VibrationTolerance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? OutputPower { get; set; }

        /// <remarks></remarks>
        public LaserType? Laser { get; set; }
    }

    /// <remarks> The DifferentialVariableReluctanceTransducerSensorType defines a
    /// differential variable reluctance transducer(DVRT).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DifferentialVariableReluctanceTransducerSensorType : SensorType
    {
        /// <remarks></remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? Hysteresis { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? FrequencyResponse { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? TemperatureStability { get; set; }

        /// <remarks></remarks>
        public string? HousingMaterial { get; set; }
    }

    /// <remarks> The MagnetoInductiveSensorType defines a magneto inductive sensor.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MagnetoInductiveSensorType : SensorType
    {
        /// <remarks></remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? FrequencyResponse { get; set; }

        /// <remarks></remarks>
        public LinearValueType? OffsetDistance { get; set; }

        /// <remarks></remarks>
        public PressureValueType? MaxPressure { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? ShockTolerance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? VibrationTolerance { get; set; }

        /// <remarks></remarks>
        public string? HousingMaterial { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxCurrentConsumption { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MinPowerSupplyVoltage { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxPowerSupplyVoltage { get; set; }
    }

    /// <remarks> The DrawWireSensorType defines a draw wire sensor.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DrawWireSensorType : SensorType
    {
        /// <remarks></remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public ForceValueType? MaxWireExtensionForce { get; set; }

        /// <remarks></remarks>
        public ForceValueType? MinWireRetractionForce { get; set; }

        /// <remarks></remarks>
        public string? MaxWireAcceleration { get; set; }
    }

    /// <remarks> The ConfocalChromaticSensorType defines a confocal chromatic sensor.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConfocalChromaticSensorType : SensorType
    {
        /// <remarks></remarks>
        public LinearValueType? SpotDiameter { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public int MultiPeakMeasurement { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MultiPeakMeasurementSpecified { get; set; }

        /// <remarks> The optional LightSource element is the type of light
        /// source used for illumination in a confocal chromatic sensor.</remarks>
        public string? LightSource { get; set; }

        /// <remarks></remarks>
        public AngularValueType? MaxTilt { get; set; }

        /// <remarks></remarks>
        public string? HousingMaterial { get; set; }

        /// <remarks></remarks>
        public LinearValueType? OpticalFiberCableLength { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? ShockTolerance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? VibrationTolerance { get; set; }
    }

    /// <remarks> The EddyCurrentSensorType defines an eddy current sensor.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EddyCurrentSensorType : SensorType
    {
        /// <remarks></remarks>
        public PressureValueType? MaxPressureFront { get; set; }

        /// <remarks></remarks>
        public PressureValueType? MaxPressureSide { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? TemperatureStability { get; set; }

        /// <remarks></remarks>
        public LinearValueType? OffsetDistance { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? FrequencyResponse { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MinPowerSupplyVoltage { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxPowerSupplyVoltage { get; set; }

        /// <remarks></remarks>
        public string? HousingMaterial { get; set; }

        /// <remarks></remarks>
        public string? MeasurementObjectMaterial { get; set; }
    }
}
