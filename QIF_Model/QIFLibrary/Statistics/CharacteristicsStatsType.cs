﻿/*! \file CharacteristicsStatsType.cs
    \brief defines a list of characteristic statistical evaluations.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The CharacteristicsStatsType defines a list of characteristic statistical evaluations./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicsStatsType
    {
        /// <remarks Each CharacteristicStats element gives information about a characteristic statistical evaluation./>
        [System.Xml.Serialization.XmlElementAttribute("AngleBetweenCharacteristicStats", typeof(AngleBetweenCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleCharacteristicStats", typeof(AngleCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularCoordinateCharacteristicStats", typeof(AngularCoordinateCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("AngleFromCharacteristicStats", typeof(AngleFromCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularCharacteristicStats", typeof(AngularCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("AngularityCharacteristicStats", typeof(AngularityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("ChordCharacteristicStats", typeof(ChordCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularityCharacteristicStats", typeof(CircularityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("CircularRunoutCharacteristicStats", typeof(CircularRunoutCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("CoaxialityCharacteristicStats", typeof(CoaxialityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("ConcentricityCharacteristicStats", typeof(ConcentricityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicalTaperCharacteristicStats", typeof(ConicalTaperCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicityCharacteristicStats", typeof(ConicityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("CurveLengthCharacteristicStats", typeof(CurveLengthCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("CylindricityCharacteristicStats", typeof(CylindricityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("DepthCharacteristicStats", typeof(DepthCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("DiameterCharacteristicStats", typeof(DiameterCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceBetweenCharacteristicStats", typeof(DistanceBetweenCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("DistanceFromCharacteristicStats", typeof(DistanceFromCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("EllipticityCharacteristicStats", typeof(EllipticityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatnessCharacteristicStats", typeof(FlatnessCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("FlatTaperCharacteristicStats", typeof(FlatTaperCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("GeometricCharacteristicStats", typeof(GeometricCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("HeightCharacteristicStats", typeof(HeightCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("LengthCharacteristicStats", typeof(LengthCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearCharacteristicStats", typeof(LinearCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearCoordinateCharacteristicStats", typeof(LinearCoordinateCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("LocationCharacteristicStats", typeof(LocationCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("LineProfileCharacteristicStats", typeof(LineProfileCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherFormCharacteristicStats", typeof(OtherFormCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("OrientationCharacteristicStats", typeof(OrientationCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("ParallelismCharacteristicStats", typeof(ParallelismCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("PerpendicularityCharacteristicStats", typeof(PerpendicularityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("PointProfileCharacteristicStats", typeof(PointProfileCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("PositionCharacteristicStats", typeof(PositionCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("RadiusCharacteristicStats", typeof(RadiusCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalDiameterCharacteristicStats", typeof(SphericalDiameterCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalRadiusCharacteristicStats", typeof(SphericalRadiusCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericityCharacteristicStats", typeof(SphericityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("SquareCharacteristicStats", typeof(SquareCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("StraightnessCharacteristicStats", typeof(StraightnessCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileCharacteristicStats", typeof(SurfaceProfileCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceProfileNonUniformCharacteristicStats", typeof(SurfaceProfileNonUniformCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceTextureCharacteristicStats", typeof(SurfaceTextureCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("SymmetryCharacteristicStats", typeof(SymmetryCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("ThicknessCharacteristicStats", typeof(ThicknessCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadCharacteristicStats", typeof(ThreadCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("ToroidicityCharacteristicStats", typeof(ToroidicityCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("TotalRunoutCharacteristicStats", typeof(TotalRunoutCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAttributeCharacteristicStats", typeof(UserDefinedAttributeCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedLinearCharacteristicStats", typeof(UserDefinedLinearCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAngularCharacteristicStats", typeof(UserDefinedAngularCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedAreaCharacteristicStats", typeof(UserDefinedAreaCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedForceCharacteristicStats", typeof(UserDefinedForceCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedMassCharacteristicStats", typeof(UserDefinedMassCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedPressureCharacteristicStats", typeof(UserDefinedPressureCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedSpeedCharacteristicStats", typeof(UserDefinedSpeedCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTemperatureCharacteristicStats", typeof(UserDefinedTemperatureCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedTimeCharacteristicStats", typeof(UserDefinedTimeCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitCharacteristicStats", typeof(UserDefinedUnitCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WidthCharacteristicStats", typeof(WidthCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFilletCharacteristicStats", typeof(WeldFilletCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldPlugCharacteristicStats", typeof(WeldPlugCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSlotCharacteristicStats", typeof(WeldSlotCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSpotCharacteristicStats", typeof(WeldSpotCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldStudCharacteristicStats", typeof(WeldStudCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSeamCharacteristicStats", typeof(WeldSeamCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSurfacingCharacteristicStats", typeof(WeldSurfacingCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldEdgeCharacteristicStats", typeof(WeldEdgeCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldSquareCharacteristicStats", typeof(WeldSquareCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldBevelCharacteristicStats", typeof(WeldBevelCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldVCharacteristicStats", typeof(WeldVCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldUCharacteristicStats", typeof(WeldUCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldJCharacteristicStats", typeof(WeldJCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareVCharacteristicStats", typeof(WeldFlareVCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldFlareBevelCharacteristicStats", typeof(WeldFlareBevelCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldScarfCharacteristicStats", typeof(WeldScarfCharacteristicStatsEvalType))]
        [System.Xml.Serialization.XmlElementAttribute("WeldCompoundCharacteristicStats", typeof(WeldCompoundCharacteristicStatsEvalType))]
        public CharacteristicStatsEvalBaseType[] CharacteristicStats { get; set; }

        /// <remarks The required n attribute is the number of characteristic statistical evaluations in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.CharacteristicStats.Length;
            set { }
        }
    }
}
