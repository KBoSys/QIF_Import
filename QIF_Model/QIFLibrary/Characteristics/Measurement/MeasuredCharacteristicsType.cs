/*! \file MeasuredCharacteristicsType.cs
    \brief contains a list of characteristic measurements

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The MeasuredCharacteristicsType contains a list of characteristic
    /// measurements and optionally the status of characteristic group evaluations./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasuredCharacteristicsType
    {
        /// <remarks The CharacteristicMeasurements element is a list of characteristic measurements./>
        public CharacteristicMeasurementsType CharacteristicMeasurements { get; set; }

        /// <remarks The optional CharacteristicGroupStatuses element is a list of characteristic group statuses./>
        public CharacteristicGroupStatusesType CharacteristicGroupStatuses { get; set; }
    }

    /// <remarks The CharacteristicMeasurementsType defines a list of characteristic measurements./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicMeasurementsType
    {
        /// <remarks Each CharacteristicMeasurement element gives information about a characteristic measurement./>
        [System.Xml.Serialization.XmlElementAttribute("AngleBetweenCharacteristicMeasurement", typeof(AngleBetweenCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleCharacteristicMeasurement", typeof(AngleCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularCoordinateCharacteristicMeasurement", typeof(AngularCoordinateCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleFromCharacteristicMeasurement", typeof(AngleFromCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularityCharacteristicMeasurement", typeof(AngularityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ChordCharacteristicMeasurement", typeof(ChordCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularityCharacteristicMeasurement", typeof(CircularityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularRunoutCharacteristicMeasurement", typeof(CircularRunoutCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("CoaxialityCharacteristicMeasurement", typeof(CoaxialityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ConcentricityCharacteristicMeasurement", typeof(ConcentricityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicalTaperCharacteristicMeasurement", typeof(ConicalTaperCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicityCharacteristicMeasurement", typeof(ConicityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("CurveLengthCharacteristicMeasurement", typeof(CurveLengthCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("CylindricityCharacteristicMeasurement", typeof(CylindricityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("DepthCharacteristicMeasurement", typeof(DepthCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("DiameterCharacteristicMeasurement", typeof(DiameterCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceBetweenCharacteristicMeasurement", typeof(DistanceBetweenCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceFromCharacteristicMeasurement", typeof(DistanceFromCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("EllipticityCharacteristicMeasurement", typeof(EllipticityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatTaperCharacteristicMeasurement", typeof(FlatTaperCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatnessCharacteristicMeasurement", typeof(FlatnessCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("HeightCharacteristicMeasurement", typeof(HeightCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("LengthCharacteristicMeasurement", typeof(LengthCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearCoordinateCharacteristicMeasurement", typeof(LinearCoordinateCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("LineProfileCharacteristicMeasurement", typeof(LineProfileCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherFormCharacteristicMeasurement", typeof(OtherFormCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ParallelismCharacteristicMeasurement", typeof(ParallelismCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("PerpendicularityCharacteristicMeasurement", typeof(PerpendicularityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("PointProfileCharacteristicMeasurement", typeof(PointProfileCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("PositionCharacteristicMeasurement", typeof(PositionCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("RadiusCharacteristicMeasurement", typeof(RadiusCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalDiameterCharacteristicMeasurement", typeof(SphericalDiameterCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalRadiusCharacteristicMeasurement", typeof(SphericalRadiusCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericityCharacteristicMeasurement", typeof(SphericityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SquareCharacteristicMeasurement", typeof(SquareCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("StraightnessCharacteristicMeasurement", typeof(StraightnessCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileCharacteristicMeasurement", typeof(SurfaceProfileCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileNonUniformCharacteristicMeasurement", typeof(SurfaceProfileNonUniformCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceTextureCharacteristicMeasurement", typeof(SurfaceTextureCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ThicknessCharacteristicMeasurement", typeof(ThicknessCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadCharacteristicMeasurement", typeof(ThreadCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ToroidicityCharacteristicMeasurement", typeof(ToroidicityCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("TotalRunoutCharacteristicMeasurement", typeof(TotalRunoutCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAttributeCharacteristicMeasurement", typeof(UserDefinedAttributeCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedLinearCharacteristicMeasurement", typeof(UserDefinedLinearCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAngularCharacteristicMeasurement", typeof(UserDefinedAngularCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAreaCharacteristicMeasurement", typeof(UserDefinedAreaCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedForceCharacteristicMeasurement", typeof(UserDefinedForceCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedMassCharacteristicMeasurement", typeof(UserDefinedMassCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedPressureCharacteristicMeasurement", typeof(UserDefinedPressureCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedSpeedCharacteristicMeasurement", typeof(UserDefinedSpeedCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTemperatureCharacteristicMeasurement", typeof(UserDefinedTemperatureCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTimeCharacteristicMeasurement", typeof(UserDefinedTimeCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitCharacteristicMeasurement", typeof(UserDefinedUnitCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WidthCharacteristicMeasurement", typeof(WidthCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFilletCharacteristicMeasurement", typeof(WeldFilletCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldPlugCharacteristicMeasurement", typeof(WeldPlugCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSlotCharacteristicMeasurement", typeof(WeldSlotCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSpotCharacteristicMeasurement", typeof(WeldSpotCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldStudCharacteristicMeasurement", typeof(WeldStudCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSeamCharacteristicMeasurement", typeof(WeldSeamCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSurfacingCharacteristicMeasurement", typeof(WeldSurfacingCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldEdgeCharacteristicMeasurement", typeof(WeldEdgeCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSquareCharacteristicMeasurement", typeof(WeldSquareCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldBevelCharacteristicMeasurement", typeof(WeldBevelCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldVCharacteristicMeasurement", typeof(WeldVCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldUCharacteristicMeasurement", typeof(WeldUCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldJCharacteristicMeasurement", typeof(WeldJCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareVCharacteristicMeasurement", typeof(WeldFlareVCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareBevelCharacteristicMeasurement", typeof(WeldFlareBevelCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldScarfCharacteristicMeasurement", typeof(WeldScarfCharacteristicMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldCompoundCharacteristicMeasurement", typeof(WeldCompoundCharacteristicMeasurementType))]
        public CharacteristicMeasurementBaseType[] Items { get; set; }

        /// <remarks The required n attribute is the number of characteristic measurements in this set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

}
