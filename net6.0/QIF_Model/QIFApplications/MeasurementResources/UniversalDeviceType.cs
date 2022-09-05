/*! \file UniversalDeviceType.cs
	\brief Defines a universal measurement device. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The UniversalDeviceType defines a universal measurement device. 
    /// Any nonmanual device that has a working volume, an effective working
    /// volume, and a resolution is considered to be a universal device.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LaserRadarType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LaserTrackerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AutocollimatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MicroscopeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpticalComparatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComputedTomographyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UniversalLengthMeasuringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TheodoliteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CMMType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AACMMType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelLinkCMMType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LightPenCMMType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCMMType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultipleCarriageCartesianCMMType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UniversalDeviceType : MeasurementDeviceType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("LinearResolution", typeof(LinearResolutionType))]
        [System.Xml.Serialization.XmlElementAttribute("CartesianResolution", typeof(CartesianResolutionType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalResolution", typeof(SphericalResolutionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedResolution", typeof(UserDefinedResolutionType))]
        public ResolutionBaseType? Resolution { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ClosedShellSetWorkingVolume", typeof(ClosedShellSetWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("CartesianWorkingVolume", typeof(CartesianWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalWorkingVolume", typeof(SphericalWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("CylindricalWorkingVolume", typeof(CylindricalWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedWorkingVolume", typeof(UserDefinedWorkingVolumeType))]
        public WorkingVolumeBaseType? WorkingVolume { get; set; }

        /// <remarks></remarks>
        // MANEDIT added substitutions to base class
        [System.Xml.Serialization.XmlElementAttribute("EffectiveClosedShellSetWorkingVolume", typeof(EffectiveClosedShellSetWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("EffectiveCartesianWorkingVolume", typeof(EffectiveCartesianWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("EffectiveSphericalWorkingVolume", typeof(EffectiveSphericalWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("EffectiveCylindricalWorkingVolume", typeof(EffectiveCylindricalWorkingVolumeType))]
        [System.Xml.Serialization.XmlElementAttribute("EffectiveUserDefinedWorkingVolume", typeof(EffectiveUserDefinedWorkingVolumeType))]
        public EffectiveWorkingVolumeBaseType? EffectiveWorkingVolume { get; set; }

        /// <remarks></remarks>
        public TemperatureCompensationType? TemperatureCompensation { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LaserRadarType : UniversalDeviceType
    {
        /// <remarks></remarks>
        public LaserType? MeasurementLaser { get; set; }

        /// <remarks></remarks>
        public LaserType? PointingLaser { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxPointsRate { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasurementRange { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MinMeasurementRange { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? ScanningSpeed { get; set; }

        /// <remarks></remarks>
        public LinearErrorType? DistanceAccuracy { get; set; }

        /// <remarks></remarks>
        public AngularErrorType? AzimuthAngularAccuracy { get; set; }

        /// <remarks></remarks>
        public AngularErrorType? ElevationAngularAccuracy { get; set; }

        /// <remarks></remarks>
        public LinearValueType? RangeForVolumetricUncertainty { get; set; }

        /// <remarks></remarks>
        public LinearValueType? VolumetricUncertainty { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxEnvironmentalAltitude { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MinEnvironmentalAltitude { get; set; }

        /// <remarks></remarks>
        public TimeValueType? SurfacePointsSpeed { get; set; }

        /// <remarks></remarks>
        public TimeValueType? ToolingBallSpeed { get; set; }

        /// <remarks></remarks>
        public TimeValueType? FeatureSpeed { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LaserTrackerType : UniversalDeviceType
    {
        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaximumAngularVelocity { get; set; }

        /// <remarks></remarks>
        public LinearErrorType? DistanceAccuracy { get; set; }

        /// <remarks></remarks>
        public AngularErrorType? AngularAccuracy { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? SamplingRate { get; set; }

        /// <remarks></remarks>
        public TargetMirrorEnumType TargetMirror { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TargetMirrorSpecified { get; set; }

        /// <remarks></remarks>
        public MassValueType? HeadMass { get; set; }

        /// <remarks></remarks>
        public CartesianWorkingVolumeType? HeadSize { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaximumWorkingAmplitude { get; set; }

        /// <remarks></remarks>
        public LaserType? Laser { get; set; }

        /// <remarks></remarks>
        public LinearValueType? Repeatability { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum TargetMirrorEnumType
    {

        /// <remarks></remarks>
        CUBE_CORNER,

        /// <remarks></remarks>
        CATS_EYE,

        /// <remarks></remarks>
        PLANE_MIRROR,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AutocollimatorType : UniversalDeviceType
    {
        /// <remarks></remarks>
        public string? LightSource { get; set; }

        /// <remarks></remarks>
        public AngularErrorType? MeasuringAccuracy { get; set; }

        /// <remarks></remarks>
        public decimal Magnification { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MagnificationSpecified { get; set; }

        /// <remarks></remarks>
        public LinearValueType? ApertureSize { get; set; }

        /// <remarks></remarks>
        public AngularValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public AngularValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? ObjectiveFocalLength { get; set; }

        /// <remarks></remarks>
        public AngularValueType? FieldOfView { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MicroscopeType : UniversalDeviceType
    {
        /// <remarks></remarks>
        public string? IlluminationUnit { get; set; }

        /// <remarks></remarks>
        public decimal TotalMagnification { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalMagnificationSpecified { get; set; }

        /// <remarks></remarks>
        public decimal EyePieceMagnification { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EyePieceMagnificationSpecified { get; set; }

        /// <remarks></remarks>
        public decimal ObjectiveMagnification { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ObjectiveMagnificationSpecified { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxWorkpieceHeight { get; set; }

        /// <remarks></remarks>
        public MassValueType? MaxWorkpieceWeight { get; set; }

        /// <remarks></remarks>
        public LinearErrorType? Accuracy { get; set; }

        /// <remarks></remarks>
        public AngularValueType? StageSwivelingAngle { get; set; }

        /// <remarks></remarks>
        public ArrayReferenceType? ToolIds { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OpticalComparatorType : UniversalDeviceType
    {
        /// <remarks></remarks>
        public decimal Magnification { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MagnificationSpecified { get; set; }

        /// <remarks></remarks>
        public LinearValueType? EffectiveScreenDiameter { get; set; }

        /// <remarks></remarks>
        public string? ScreenMaterial { get; set; }

        /// <remarks></remarks>
        public AngularValueType? AngleResolution { get; set; }

        /// <remarks></remarks>
        public string? SurfaceIlluminationLightSource { get; set; }

        /// <remarks></remarks>
        public string? ContourIlluminationLightSource { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxWorkpieceHeight { get; set; }

        /// <remarks></remarks>
        public LinearValueType? WorkingDistance { get; set; }

        /// <remarks></remarks>
        public ArrayReferenceType? ToolIds { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ComputedTomographyType : UniversalDeviceType
    {
        /// <remarks></remarks>
        public string? SourceDescription { get; set; }

        /// <remarks></remarks>
        public string? SamplePenetratingMaterial { get; set; }

        /// <remarks></remarks>
        public LinearValueType? SamplePenetratingMaterialLength { get; set; }

        /// <remarks></remarks>
        public LinearValueType? FocalSpotSize { get; set; }

        /// <remarks></remarks>
        public MassValueType? MaxWorkpieceMass { get; set; }

        /// <remarks></remarks>
        public string? SafetyLevel { get; set; }

        /// <remarks></remarks>
        public CartesianWorkingVolumeType? CabinetDimensions { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxPower { get; set; }

        /// <remarks></remarks>
        public decimal DetectorBitNumber { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DetectorBitNumberSpecified { get; set; }

        /// <remarks></remarks>
        public LinearValueType? DetectorPixelSize { get; set; }

        /// <remarks></remarks>
        public FunctionDiscreteType? ActivePixelsNumber { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxKV { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MinOperatingCurrent { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxOperatingCurrent { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxFramePerSecond { get; set; }

        /// <remarks></remarks>
        public RotaryTableType? RotaryTable { get; set; }

        /// <remarks></remarks>
        public ArrayReferenceType? ToolIds { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UniversalLengthMeasuringType : UniversalDeviceType
    {
        /// <remarks></remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public ForceValueType? MeasuringForce { get; set; }

        /// <remarks></remarks>
        public LinearErrorType? Accuracy { get; set; }

        /// <remarks></remarks>
        public LinearValueType? Repeatability { get; set; }

        /// <remarks></remarks>
        public ArrayReferenceType? ToolIds { get; set; }

        /// <remarks></remarks>
        public MassValueType? MaxWorkpieceWeight { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TheodoliteType : UniversalDeviceType
    {
        /// <remarks></remarks>
        public SpeedValueType? LongitudinalTrackingSpeed { get; set; }

        /// <remarks></remarks>
        public SpeedValueType? LateralTrackingSpeed { get; set; }

        /// <remarks></remarks>
        public decimal Magnification { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MagnificationSpecified { get; set; }

        /// <remarks></remarks>
        public LinearValueType? FieldOfViewDiameter { get; set; }

        /// <remarks></remarks>
        public LinearValueType? ApertureSize { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxFocusDistance { get; set; }

        /// <remarks></remarks>
        public AngularValueType? AngularAccuracy { get; set; }

        /// <remarks></remarks>
        public AngularValueType? MaxTiltCompensation { get; set; }

        /// <remarks></remarks>
        public ChargeCoupledDeviceCameraSensorType? ChargeCoupledDeviceCameraSensor { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MinFocusDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? EffectiveDiameterOfObjective { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? StadiaBaseConstant { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? StadiaRateConstant { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MinPowerSupplyVoltage { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? MaxPowerSupplyVoltage { get; set; }

        /// <remarks></remarks>
        public LaserType? Laser { get; set; }
    }
}
