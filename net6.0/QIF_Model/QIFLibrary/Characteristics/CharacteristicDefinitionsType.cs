/*! \file CharacteristicDefinitionsType.cs
    \brief defines a list of characteristic definitions. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Characteristics.Definition;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Visualization;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <summary>
    /// The CharacteristicDefinitionsType defines a list of characteristic definitions.
    /// </summary>
    public class CharacteristicDefinitionsType : ArrayBaseType<Definition.CharacteristicDefinitionBaseType>
    {
        /// <remarks> Each CharacteristicDefinition element gives information about a characteristic.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AngleBetweenCharacteristicDefinition", typeof(AngleBetweenCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleCharacteristicDefinition", typeof(AngleCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularCoordinateCharacteristicDefinition", typeof(AngularCoordinateCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleFromCharacteristicDefinition", typeof(AngleFromCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularityCharacteristicDefinition", typeof(AngularityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ChordCharacteristicDefinition", typeof(ChordCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularityCharacteristicDefinition", typeof(CircularityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularRunoutCharacteristicDefinition", typeof(CircularRunoutCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("CoaxialityCharacteristicDefinition", typeof(CoaxialityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ConcentricityCharacteristicDefinition", typeof(ConcentricityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicalTaperCharacteristicDefinition", typeof(ConicalTaperCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicityCharacteristicDefinition", typeof(ConicityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("CurveLengthCharacteristicDefinition", typeof(CurveLengthCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("CylindricityCharacteristicDefinition", typeof(CylindricityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("DepthCharacteristicDefinition", typeof(DepthCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("DiameterCharacteristicDefinition", typeof(DiameterCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceBetweenCharacteristicDefinition", typeof(DistanceBetweenCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceFromCharacteristicDefinition", typeof(DistanceFromCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("EllipticityCharacteristicDefinition", typeof(EllipticityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatTaperCharacteristicDefinition", typeof(FlatTaperCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatnessCharacteristicDefinition", typeof(FlatnessCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("HeightCharacteristicDefinition", typeof(HeightCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("LengthCharacteristicDefinition", typeof(LengthCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearCoordinateCharacteristicDefinition", typeof(LinearCoordinateCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("LineProfileCharacteristicDefinition", typeof(LineProfileCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherFormCharacteristicDefinition", typeof(OtherFormCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ParallelismCharacteristicDefinition", typeof(ParallelismCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("PerpendicularityCharacteristicDefinition", typeof(PerpendicularityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("PointProfileCharacteristicDefinition", typeof(PointProfileCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("PositionCharacteristicDefinition", typeof(PositionCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("RadiusCharacteristicDefinition", typeof(RadiusCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalDiameterCharacteristicDefinition", typeof(SphericalDiameterCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalRadiusCharacteristicDefinition", typeof(SphericalRadiusCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericityCharacteristicDefinition", typeof(SphericityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SquareCharacteristicDefinition", typeof(SquareCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("StraightnessCharacteristicDefinition", typeof(StraightnessCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileCharacteristicDefinition", typeof(SurfaceProfileCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileNonUniformCharacteristicDefinition", typeof(SurfaceProfileNonUniformCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceTextureCharacteristicDefinition", typeof(SurfaceTextureCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ThicknessCharacteristicDefinition", typeof(ThicknessCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadCharacteristicDefinition", typeof(ThreadCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("ToroidicityCharacteristicDefinition", typeof(ToroidicityCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("TotalRunoutCharacteristicDefinition", typeof(TotalRunoutCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAttributeCharacteristicDefinition", typeof(UserDefinedAttributeCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedLinearCharacteristicDefinition", typeof(UserDefinedLinearCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAngularCharacteristicDefinition", typeof(UserDefinedAngularCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAreaCharacteristicDefinition", typeof(UserDefinedAreaCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedForceCharacteristicDefinition", typeof(UserDefinedForceCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedMassCharacteristicDefinition", typeof(UserDefinedMassCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedPressureCharacteristicDefinition", typeof(UserDefinedPressureCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedSpeedCharacteristicDefinition", typeof(UserDefinedSpeedCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTemperatureCharacteristicDefinition", typeof(UserDefinedTemperatureCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTimeCharacteristicDefinition", typeof(UserDefinedTimeCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitCharacteristicDefinition", typeof(UserDefinedUnitCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WidthCharacteristicDefinition", typeof(WidthCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFilletCharacteristicDefinition", typeof(WeldFilletCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldPlugCharacteristicDefinition", typeof(WeldPlugCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSlotCharacteristicDefinition", typeof(WeldSlotCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSpotCharacteristicDefinition", typeof(WeldSpotCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldStudCharacteristicDefinition", typeof(WeldStudCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSeamCharacteristicDefinition", typeof(WeldSeamCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSurfacingCharacteristicDefinition", typeof(WeldSurfacingCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldEdgeCharacteristicDefinition", typeof(WeldEdgeCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSquareCharacteristicDefinition", typeof(WeldSquareCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldBevelCharacteristicDefinition", typeof(WeldBevelCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldVCharacteristicDefinition", typeof(WeldVCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldUCharacteristicDefinition", typeof(WeldUCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldJCharacteristicDefinition", typeof(WeldJCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareVCharacteristicDefinition", typeof(WeldFlareVCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareBevelCharacteristicDefinition", typeof(WeldFlareBevelCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldScarfCharacteristicDefinition", typeof(WeldScarfCharacteristicDefinitionType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldCompoundCharacteristicDefinition", typeof(WeldCompoundCharacteristicDefinitionType))]
        public Definition.CharacteristicDefinitionBaseType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
