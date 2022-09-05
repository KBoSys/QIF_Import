/*! \file CharacteristicNominalsType.cs
    \brief defines a list of characteristic	nominals.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Characteristics.Nominal;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <summary>
    /// The CharacteristicNominalsType defines a list of characteristic	nominals.
    /// </summary>
    public class CharacteristicNominalsType : ArrayBaseType<CharacteristicNominalBaseType>
    {
        /// <remarks> Each CharacteristicNominal element gives information about a characteristic nominal.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AngleBetweenCharacteristicNominal", typeof(AngleBetweenCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleCharacteristicNominal", typeof(AngleCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularCoordinateCharacteristicNominal", typeof(AngularCoordinateCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleFromCharacteristicNominal", typeof(AngleFromCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularityCharacteristicNominal", typeof(AngularityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("ChordCharacteristicNominal", typeof(ChordCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularityCharacteristicNominal", typeof(CircularityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularRunoutCharacteristicNominal", typeof(CircularRunoutCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("CoaxialityCharacteristicNominal", typeof(CoaxialityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("ConcentricityCharacteristicNominal", typeof(ConcentricityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicalTaperCharacteristicNominal", typeof(ConicalTaperCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicityCharacteristicNominal", typeof(ConicityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("CurveLengthCharacteristicNominal", typeof(CurveLengthCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("CylindricityCharacteristicNominal", typeof(CylindricityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("DepthCharacteristicNominal", typeof(DepthCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("DiameterCharacteristicNominal", typeof(DiameterCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceBetweenCharacteristicNominal", typeof(DistanceBetweenCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceFromCharacteristicNominal", typeof(DistanceFromCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("EllipticityCharacteristicNominal", typeof(EllipticityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatTaperCharacteristicNominal", typeof(FlatTaperCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatnessCharacteristicNominal", typeof(FlatnessCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("HeightCharacteristicNominal", typeof(HeightCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("LengthCharacteristicNominal", typeof(LengthCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearCoordinateCharacteristicNominal", typeof(LinearCoordinateCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("LineProfileCharacteristicNominal", typeof(LineProfileCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherFormCharacteristicNominal", typeof(OtherFormCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("ParallelismCharacteristicNominal", typeof(ParallelismCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("PerpendicularityCharacteristicNominal", typeof(PerpendicularityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("PointProfileCharacteristicNominal", typeof(PointProfileCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("PositionCharacteristicNominal", typeof(PositionCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("RadiusCharacteristicNominal", typeof(RadiusCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalDiameterCharacteristicNominal", typeof(SphericalDiameterCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalRadiusCharacteristicNominal", typeof(SphericalRadiusCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericityCharacteristicNominal", typeof(SphericityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("SquareCharacteristicNominal", typeof(SquareCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("StraightnessCharacteristicNominal", typeof(StraightnessCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileCharacteristicNominal", typeof(SurfaceProfileCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileNonUniformCharacteristicNominal", typeof(SurfaceProfileNonUniformCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceTextureCharacteristicNominal", typeof(SurfaceTextureCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("ThicknessCharacteristicNominal", typeof(ThicknessCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadCharacteristicNominal", typeof(ThreadCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("ToroidicityCharacteristicNominal", typeof(ToroidicityCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("TotalRunoutCharacteristicNominal", typeof(TotalRunoutCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAttributeCharacteristicNominal", typeof(UserDefinedAttributeCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedLinearCharacteristicNominal", typeof(UserDefinedLinearCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAngularCharacteristicNominal", typeof(UserDefinedAngularCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAreaCharacteristicNominal", typeof(UserDefinedAreaCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedForceCharacteristicNominal", typeof(UserDefinedForceCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedMassCharacteristicNominal", typeof(UserDefinedMassCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedPressureCharacteristicNominal", typeof(UserDefinedPressureCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedSpeedCharacteristicNominal", typeof(UserDefinedSpeedCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTemperatureCharacteristicNominal", typeof(UserDefinedTemperatureCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTimeCharacteristicNominal", typeof(UserDefinedTimeCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitCharacteristicNominal", typeof(UserDefinedUnitCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WidthCharacteristicNominal", typeof(WidthCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFilletCharacteristicNominal", typeof(WeldFilletCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldPlugCharacteristicNominal", typeof(WeldPlugCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSlotCharacteristicNominal", typeof(WeldSlotCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSpotCharacteristicNominal", typeof(WeldSpotCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldStudCharacteristicNominal", typeof(WeldStudCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSeamCharacteristicNominal", typeof(WeldSeamCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSurfacingCharacteristicNominal", typeof(WeldSurfacingCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldEdgeCharacteristicNominal", typeof(WeldEdgeCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSquareCharacteristicNominal", typeof(WeldSquareCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldBevelCharacteristicNominal", typeof(WeldBevelCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldVCharacteristicNominal", typeof(WeldVCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldUCharacteristicNominal", typeof(WeldUCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldJCharacteristicNominal", typeof(WeldJCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareVCharacteristicNominal", typeof(WeldFlareVCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareBevelCharacteristicNominal", typeof(WeldFlareBevelCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldScarfCharacteristicNominal", typeof(WeldScarfCharacteristicNominalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldCompoundCharacteristicNominal", typeof(WeldCompoundCharacteristicNominalType))]
        public CharacteristicNominalBaseType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
