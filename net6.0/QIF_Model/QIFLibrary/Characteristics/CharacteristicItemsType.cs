/*! \file CharacteristicItemsType.cs
    \brief defines a list of characteristic items.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications.QIFResults;
using QIF_Model.QIFLibrary.Characteristics.Items;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <summary>
    /// The CharacteristicItemsType defines a list of characteristic items.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicItemsType : ArrayBaseType<CharacteristicItemBaseType>
    {
        /// <remarks> Each CharacteristicItem element gives information about a characteristic item.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AngleBetweenCharacteristicItem", typeof(AngleBetweenCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleCharacteristicItem", typeof(AngleCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularCoordinateCharacteristicItem", typeof(AngularCoordinateCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleFromCharacteristicItem", typeof(AngleFromCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularityCharacteristicItem", typeof(AngularityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("ChordCharacteristicItem", typeof(ChordCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularityCharacteristicItem", typeof(CircularityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularRunoutCharacteristicItem", typeof(CircularRunoutCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("CoaxialityCharacteristicItem", typeof(CoaxialityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("ConcentricityCharacteristicItem", typeof(ConcentricityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicalTaperCharacteristicItem", typeof(ConicalTaperCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicityCharacteristicItem", typeof(ConicityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("CurveLengthCharacteristicItem", typeof(CurveLengthCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("CylindricityCharacteristicItem", typeof(CylindricityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("DepthCharacteristicItem", typeof(DepthCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("DiameterCharacteristicItem", typeof(DiameterCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceBetweenCharacteristicItem", typeof(DistanceBetweenCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceFromCharacteristicItem", typeof(DistanceFromCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("EllipticityCharacteristicItem", typeof(EllipticityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatTaperCharacteristicItem", typeof(FlatTaperCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatnessCharacteristicItem", typeof(FlatnessCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("HeightCharacteristicItem", typeof(HeightCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("LengthCharacteristicItem", typeof(LengthCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearCoordinateCharacteristicItem", typeof(LinearCoordinateCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("LineProfileCharacteristicItem", typeof(LineProfileCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherFormCharacteristicItem", typeof(OtherFormCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("ParallelismCharacteristicItem", typeof(ParallelismCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("PerpendicularityCharacteristicItem", typeof(PerpendicularityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("PointProfileCharacteristicItem", typeof(PointProfileCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("PositionCharacteristicItem", typeof(PositionCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("RadiusCharacteristicItem", typeof(RadiusCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalDiameterCharacteristicItem", typeof(SphericalDiameterCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalRadiusCharacteristicItem", typeof(SphericalRadiusCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericityCharacteristicItem", typeof(SphericityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("SquareCharacteristicItem", typeof(SquareCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("StraightnessCharacteristicItem", typeof(StraightnessCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileCharacteristicItem", typeof(SurfaceProfileCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileNonUniformCharacteristicItem", typeof(SurfaceProfileNonUniformCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceTextureCharacteristicItem", typeof(SurfaceTextureCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("ThicknessCharacteristicItem", typeof(ThicknessCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadCharacteristicItem", typeof(ThreadCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("ToroidicityCharacteristicItem", typeof(ToroidicityCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("TotalRunoutCharacteristicItem", typeof(TotalRunoutCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAttributeCharacteristicItem", typeof(UserDefinedAttributeCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedLinearCharacteristicItem", typeof(UserDefinedLinearCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAngularCharacteristicItem", typeof(UserDefinedAngularCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAreaCharacteristicItem", typeof(UserDefinedAreaCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedForceCharacteristicItem", typeof(UserDefinedForceCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedMassCharacteristicItem", typeof(UserDefinedMassCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedPressureCharacteristicItem", typeof(UserDefinedPressureCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedSpeedCharacteristicItem", typeof(UserDefinedSpeedCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTemperatureCharacteristicItem", typeof(UserDefinedTemperatureCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTimeCharacteristicItem", typeof(UserDefinedTimeCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitCharacteristicItem", typeof(UserDefinedUnitCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WidthCharacteristicItem", typeof(WidthCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFilletCharacteristicItem", typeof(WeldFilletCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldPlugCharacteristicItem", typeof(WeldPlugCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSlotCharacteristicItem", typeof(WeldSlotCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSpotCharacteristicItem", typeof(WeldSpotCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldStudCharacteristicItem", typeof(WeldStudCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSeamCharacteristicItem", typeof(WeldSeamCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSurfacingCharacteristicItem", typeof(WeldSurfacingCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldEdgeCharacteristicItem", typeof(WeldEdgeCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSquareCharacteristicItem", typeof(WeldSquareCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldBevelCharacteristicItem", typeof(WeldBevelCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldVCharacteristicItem", typeof(WeldVCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldUCharacteristicItem", typeof(WeldUCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldJCharacteristicItem", typeof(WeldJCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareVCharacteristicItem", typeof(WeldFlareVCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareBevelCharacteristicItem", typeof(WeldFlareBevelCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldScarfCharacteristicItem", typeof(WeldScarfCharacteristicItemType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldCompoundCharacteristicItem", typeof(WeldCompoundCharacteristicItemType))]
        public CharacteristicItemBaseType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
