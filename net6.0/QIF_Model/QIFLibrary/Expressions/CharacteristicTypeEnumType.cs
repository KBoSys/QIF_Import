/*! \file CharacteristicTypeEnumType.cs
    \brief enumerates types of characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks> The CharacteristicTypeEnumType enumerates types of characteristics.
    /// The enumeration values represent the names of the characteristic types defined in Characteristics.xsd.</remarks>
    [System.SerializableAttribute()]
    public enum CharacteristicTypeEnumType
    {
        /// <remarks> Unknown/Invalid Type</remarks>
        UNKNOWN,

        /// <remarks> AngleCharacteristicNominalType</remarks>
        ANGLE,

        /// <remarks> AngleCoordinateCharacteristicNominalType</remarks>
        ANGLECOORDINATE,

        /// <remarks> AngleFromCharacteristicNominalType</remarks>
        ANGLEFROM,

        /// <remarks> AngleFromCharacteristicNominalType</remarks>
        ANGLEBETWEEN,

        /// <remarks> AngularityCharacteristicNominalType</remarks>
        ANGULARITY,

        /// <remarks> ChordCharacteristicNominalType</remarks>
        CHORD,

        /// <remarks> CircularityCharacteristicNominalType</remarks>
        CIRCULARITY,

        /// <remarks> CircularRunoutCharacteristicNominalType</remarks>
        CIRCULARRUNOUT,

        /// <remarks> ConcentricityCharacteristicNominalType</remarks>
        CONCENTRICITY,

        /// <remarks> ConicalTaperCharacteristicNominalType</remarks>
        CONICALTAPER,

        /// <remarks> ConicityCharacteristicNominalType</remarks>
        CONICITY,

        /// <remarks> CurveLengthCharacteristicNominalType</remarks>
        CURVELENGTH,

        /// <remarks> CylindricityCharacteristicNominalType</remarks>
        CYLINDRICITY,

        /// <remarks> DepthCharacteristicNominalType</remarks>
        DEPTH,

        /// <remarks> DiameterCharacteristicNominalType</remarks>
        DIAMETER,

        /// <remarks> DistanceBetweenCharacteristicNominalType</remarks>
        DISTANCE,

        /// <remarks> DistanceFromCharacteristicNominalType</remarks>
        DISTANCEFROM,

        /// <remarks> EllipticityCharacteristicNominalType</remarks>
        ELLIPTICITY,
        
        /// <remarks> FlatTaperCharacteristicNominalType</remarks>
        FLATTAPER,

        /// <remarks> FlatnessCharacteristicNominalType</remarks>
        FLATNESS,

        /// <remarks> HeightCharacteristicNominalType</remarks>
        HEIGHT,

        /// <remarks> LengthCharacteristicNominalType</remarks>
        LENGTH,

        /// <remarks> LengthCoordinateCharacteristicNominalType</remarks>
        LENGTHCOORDINATE,

        /// <remarks> LineProfileCharacteristicNominalType</remarks>
        LINEPROFILE,

        /// <remarks> OtherFormCharacteristicNominalType</remarks>
        OTHERFORM,

        /// <remarks> PerpendicularityCharacteristicNominalType</remarks>
        PERPENDICULARITY,

        /// <remarks> ParallelismCharacteristicNominalType</remarks>
        PARALLELISM,

        /// <remarks> PointProfileCharacteristicNominalType</remarks>
        POINTPROFILE,

        /// <remarks> PositionCharacteristicNominalType</remarks>
        POSITION,

        /// <remarks> RadiusCharacteristicNominalType</remarks>
        RADIUS,

        /// <remarks> SphericalDiameterCharacteristicNominalType</remarks>
        SPHERICALDIAMETER,

        /// <remarks> SphericalRadiusCharacteristicNominalType</remarks>
        SPHERICALRADIUS,

        /// <remarks> SphericityCharacteristicNominalType</remarks>
        SPHERICITY,

        /// <remarks> SquareCharacteristicNominalType</remarks>
        SQUARE,

        /// <remarks> StraightnessCharacteristicNominalType</remarks>
        STRAIGHTNESS,

        /// <remarks> SurfaceProfileCharacteristicNominalType</remarks>
        SURFACEPROFILE,

        /// <remarks> SurfaceProfileNonUniformChar'Nom'Type</remarks>
        SURFACEPROFILENONUNIFORM,

        /// <remarks> SymmetryCharacteristicNominalType</remarks>
        SYMMETRY,

        /// <remarks> ThicknessCharacteristicNominalType</remarks>
        THICKNESS,

        /// <remarks> ThreadCharacteristicNominalType</remarks>
        THREAD,

        /// <remarks> ToroidicityCharacteristicNominalType</remarks>
        TOROIDICITY,

        /// <remarks> TotalRunoutCharacteristicNominalType</remarks>
        TOTALRUNOUT,

        /// <remarks> WeldBevelCharacteristicNominalType</remarks>
        WELDBEVEL,

        /// <remarks> WeldEdgeCharacteristicNominalType</remarks>
        WELDEDGE,

        /// <remarks> WeldFilletCharacteristicNominalType</remarks>
        WELDFILLET,

        /// <remarks> WeldFlareBevelCharacteristicNominalType</remarks>
        WELDFLAREBEVEL,

        /// <remarks> WeldFlareVCharacteristicNominalType</remarks>
        WELDFLAREV,

        /// <remarks> WeldJCharacteristicNominalType</remarks>
        WELDJ,

        /// <remarks> WeldPlugCharacteristicNominalType</remarks>
        WELDPLUG,

        /// <remarks> WeldScarfCharacteristicNominalType</remarks>
        WELDSCARF,

        /// <remarks> WeldSeamCharacteristicNominalType</remarks>
        WELDSEAM,

        /// <remarks> WeldSlotCharacteristicNominalType</remarks>
        WELDSLOT,

        /// <remarks> WeldSpotCharacteristicNominalType</remarks>
        WELDSPOT,

        /// <remarks> WeldSquareCharacteristicNominalType</remarks>
        WELDSQUARE,

        /// <remarks> WeldStudCharacteristicNominalType</remarks>
        WELDSTUD,

        /// <remarks> WeldSurfacingCharacteristicNominalType</remarks>
        WELDSURFACING,

        /// <remarks> WeldUCharacteristicNominalType</remarks>
        WELDU,

        /// <remarks> WeldVCharacteristicNominalType</remarks>
        WELDV,

        /// <remarks> WidthCharacteristicNominalType</remarks>
        WIDTH,
    }
}
