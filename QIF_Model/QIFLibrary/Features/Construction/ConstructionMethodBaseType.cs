﻿/*! \file ConstructionMethodBaseType.cs
    \brief The ConstructionMethodBaseType is the abstract base type that defines a construction method.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Construction
{
    /// <remarks> The ConstructionMethodBaseType is the abstract base type that defines a construction method.A construction method defines the
    /// data for constructing a feature and describes how to use that data in the construction of a feature.In any case where more than one
    /// feature can be constructed with the same input, the result closest to the feature's nominal definition will be chosen.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureFromCylinderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureExtremeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureMovePointAxisType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureMovePointVectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureMovePointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureMidPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureCenterOfGravityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureFromConeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureProjectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeaturePierceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureIntersectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceExtractType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveExtractType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneExtractType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneThroughType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneTangentThroughType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneParallelType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlanePerpendicularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneOffsetType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneMidplaneType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherShapeFeatureCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCurveFeatureCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesProjectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesIntersectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesProjectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesIntersectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineExtractType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineTangentThroughType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineParallelType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinePerpendicularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineProjectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineIntersectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineMidlineType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcIntersectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcProjectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseIntersectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseProjectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcExtractType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcIntersectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcProjectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcBestFitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFromScanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFromConeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleTransformType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleTangentThroughType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleTangentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleCastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleCopyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleProjectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleIntersectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleRecompType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleBestFitType))]
    public abstract class ConstructionMethodBaseType
    {
        /// <remarks> The optional NominalsCalculated element identifies whether nominals are calculated rather than supplied for the
        /// constructed feature: "true" for calculated, "false" or not present for supplied.</remarks>
        [XmlElement]
        public bool NominalsCalculated { get; set; } = false;
    }

    /// <remarks> The OtherShapeFeatureCopyType defines a copied other shape feature construction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherShapeFeatureCopyType : ConstructionMethodBaseType
    {
        /// <remarks> The BaseOtherShapeFeature element identifies the other shape feature to be copied.</remarks>
        public BaseFeatureType BaseOtherShapeFeature { get; set; }
    }
}
