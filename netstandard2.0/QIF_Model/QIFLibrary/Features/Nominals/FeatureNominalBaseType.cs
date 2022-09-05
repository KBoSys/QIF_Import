/*! \file FeatureNominalBaseType.cs
    \brief The FeatureNominalBaseType is the abstract base type for feature nominals.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.Nominals
{
    /// <remarks> The FeatureNominalBaseType is the abstract base type for feature
    /// nominals.A feature nominal holds that portion of feature nominal
    /// information which cannot be shared among several features, e.g. feature location.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NonShapeFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarkingFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherNonShapeFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShapeFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroupFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircleNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircularArcNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureParallelogramNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureLinearNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherShapeFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecifiedFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCurveFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFeatureNominalType))]
    public abstract class FeatureNominalBaseType : FeatureBaseType
    {
        /// <remarks> The optional Name element is the name of the feature nominal.</remarks>
        [XmlElement()]
        public string Name { get; set; }

        /// <remarks> The optional UUID element is a persistent identifier for
        /// the shape feature nominal.If used, it should be generated using a widely accepted UUID generator.</remarks>
        [XmlElement()]
        public Primitives.QPIdType UUID { get; set; }

        /// <remarks> The FeatureDefinitionId element is the QIF id of the associated feature definition.</remarks>
        [XmlElement(IsNullable = false)]
        public Primitives.QIFReferenceType FeatureDefinitionId { get; set; }

        /// <remarks> The optional ParentFeatureNominalId element is the QIF id of
        /// the parent feature nominal when this feature item is derived from another feature nominal.</remarks>
        [XmlElement()]
        public Primitives.QIFReferenceType ParentFeatureNominalId { get; set; }

        /// <remarks> The EntityInternalIds element is a list of the QIF ids of
        /// internally-defined CAD entities associated with this feature nominal.</remarks>
        [XmlElement()]
        public Primitives.ArrayReferenceFullType EntityInternalIds { get; set; }

        /// <remarks> The EntityExternalIds element is a list of the QIF ids of
        /// instances of EntityExternalType associated with this feature nominal.</remarks>
        [XmlElement()]
        public Primitives.ArrayReferenceFullType EntityExternalIds { get; set; }
    }

    /// <remarks> The ShapeFeatureNominalBaseType is the abstract base type for shape
    /// feature nominals.A shape feature nominal holds that portion of
    /// shape feature nominal information which cannot be shared among
    /// several features, e.g.feature location.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroupFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircleNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureCircularArcNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureParallelogramNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PatternFeatureLinearNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherShapeFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpecifiedFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgePointFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCurveFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceFeatureNominalBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TorusFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceOfRevolutionFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedSurfaceFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherSurfaceFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledPlanesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelPlanesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtrudedCrossSectionFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCylinderFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalSegmentFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeFeatureNominalType))]
    public abstract class ShapeFeatureNominalBaseType : FeatureNominalBaseType
    {
        /// <remarks> The optional PointList element is a list of references to nominal target measurement points for the feature.</remarks>
        [XmlElement()]
        public PointListType PointList { get; set; }

        /// <remarks> The optional SubstituteFeatureAlgorithm element is the substitute feature data fitting algorithm for the shape feature.</remarks>
        [XmlElement()]
        public IntermediatesPMI.SubstituteFeatureAlgorithmType SubstituteFeatureAlgorithm { get; set; }
    }

    /// <remarks> The CurveFeatureNominalBaseType is the abstract base type for shape feature nominals for features composed of curves.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCurveFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcFeatureNominalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFeatureNominalType))]
    public abstract class CurveFeatureNominalBaseType : ShapeFeatureNominalBaseType
    {
        /// <remarks> The optional SurfaceFeatureNominalId element is the QIF id of the nominal surface feature the curve lies on.</remarks>
        [XmlElement()]
        public Primitives.QIFReferenceFullType SurfaceFeatureNominalId { get; set; }
    }

    /// <remarks> The SurfaceFeatureNominalBaseType is the abstract base type for shape feature nominals for features composed of surfaces.</remarks>
    public abstract class SurfaceFeatureNominalBaseType : ShapeFeatureNominalBaseType
    {
    }

    /// <remarks> The PointFeatureNominalBaseType is the abstract base type for shape feature nominals for features that are a point.</remarks>
    public abstract class PointFeatureNominalBaseType : ShapeFeatureNominalBaseType
    {
        /// <remarks> The optional SurfaceFeatureNominalId element is the QIF id of the nominal surface feature the point lies on.</remarks>
        [XmlElement]
        public Primitives.QIFReferenceFullType SurfaceFeatureNominalId { get; set; }

        /// <remarks> The optional CurveFeatureNominalId element is the QIF id of the nominal curve feature the point lies on.</remarks>
        [XmlElement]
        public Primitives.QIFReferenceFullType CurveFeatureNominalId { get; set; }
    }

    /// <remarks> The NonShapeFeatureNominalBaseType is the abstract base type for
    /// non-shape feature nominals.A non-shape feature nominal holds that
    /// portion of non-shape feature nominal information which cannot be
    /// shared among several features, e.g.feature location.</remarks>
    public abstract class NonShapeFeatureNominalBaseType : FeatureNominalBaseType
    {
    }

    /// <remarks> The PatternFeatureNominalBaseType is the abstract base type that
    /// defines the pattern feature nominal information for an individual
    /// pattern feature.Each feature nominal in an instance of
    /// PatternFeatureNominalBaseType must reference the same feature definition.</remarks>
    public abstract class PatternFeatureNominalBaseType : GroupFeatureNominalType
    {
    }

    /// <remarks> The SpecifiedFeatureNominalBaseType is the abstract base type for
    /// shape feature nominals for features that are defined indirectly by a
    /// specification rather than by a direct shape description.</remarks>
    public abstract class SpecifiedFeatureNominalBaseType : ShapeFeatureNominalBaseType
    {
    }
}
