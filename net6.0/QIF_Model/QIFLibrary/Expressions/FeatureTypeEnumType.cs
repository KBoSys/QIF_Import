/*! \file FeatureTypeEnumType.cs
    \brief enumerates types of features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks> The FeatureTypeEnumType enumerates types of features.
    /// The enumeration values represent the names of the feature types defined in Features.xsd.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum FeatureTypeEnumType
    {
        ///<remarks> CircleFeatureItemType </remarks>
        CIRCLE,
        ///<remarks> CircularArcFeatureItemType </remarks>
        CIRCULARARC,
        ///<remarks> ConeFeatureItemType </remarks>
        CONE,
        ///<remarks> ConicalSegmentFeatureItemType </remarks>
        CONICALSEGMENT,
        ///<remarks> CylinderFeatureItemType </remarks>
        CYLINDER,
        ///<remarks> CylindricalSegmentFeatureItemType </remarks>
        CYLINDRICALSEGMENT,
        ///<remarks> EdgePointFeatureItemType </remarks>
        EDGEPOINT,
        ///<remarks> EllipseFeatureItemType </remarks>
        ELLIPSE,
        ///<remarks> EllipticalArcFeatureItemType </remarks>
        ELLIPTICALARC,
        ///<remarks> ElongatedCircleFeatureItemType </remarks>
        ELONGATEDCIRCLE,
        ///<remarks> ElongatedCylinderFeatureItemType </remarks>
        ELONGATEDCYLINDER,
        ///<remarks> ExtrudedCrossSectionFeatureItemType </remarks>
        EXTRUDEDCROSSSECTION,
        ///<remarks> GroupFeatureItemType </remarks>
        GROUP,
        ///<remarks> LineFeatureItemType </remarks>
        LINE,
        ///<remarks> MarkingFeatureItemType </remarks>
        MARKING,
        ///<remarks> OppositeAngledLinesFeatureItemType </remarks>
        OPPOSITEANGLEDLINES,
        ///<remarks> OppositeAngledPlanesFeatureItemType </remarks>
        OPPOSITEANGLEDPLANES,
        ///<remarks> OppositeParallelLinesFeatureItemType </remarks>
        OPPOSITEPARALLELLINES,
        ///<remarks> OppositeParallelPlanesFeatureItemType </remarks>
        OPPOSITEPARALLELPLANES,
        ///<remarks> OtherCurveFeatureItemType </remarks>
        OTHERCURVE,
        ///<remarks> OtherNonShapeFeatureItemType </remarks>
        OTHERNONSHAPE,
        ///<remarks> OtherShapeFeatureItemType </remarks>
        OTHERSHAPE,
        ///<remarks> OtherSurfaceFeatureItemType </remarks>
        OTHERSURFACE,
        ///<remarks> PatternFeatureItemBaseType(any pattern feature) </remarks>
        PATTERN,
        ///<remarks> PatternFeatureCircleItemType </remarks>
        PATTERNCIRCLE,
        ///<remarks> PatternFeatureCircularArcItemType </remarks>
        PATTERNCIRCULARARC,
        ///<remarks> PatternFeatureLinearItemType </remarks>
        PATTERNLINEAR,
        ///<remarks> PatternFeatureParallelogramItemType </remarks>
        PATTERNPARALLELOGRAM,
        ///<remarks> PlaneFeatureItemType </remarks>
        PLANE,
        ///<remarks> PointFeatureItemType </remarks>
        POINT,
        ///<remarks> PointDefinedCurveFeatureItemType </remarks>
        POINTDEFINEDCURVE,
        ///<remarks> PointDefinedSurfaceFeatureItemType </remarks>
        POINTDEFINEDSURFACE,
        ///<remarks> SphereFeatureItemType </remarks>
        SPHERE,
        ///<remarks> SphericalSegmentFeatureItemType </remarks>
        SPHERICALSEGMENT,
        ///<remarks> SurfaceOfRevolutionFeatureItemType </remarks>
        SURFACEOFREVOLUTION,
        ///<remarks> ThreadedFeatureItemType </remarks>
        THREADED,
        ///<remarks> ToroidalSegmentFeatureItemType </remarks>
        TOROIDALSEGMENT,
        ///<remarks> TorusFeatureItemType </remarks>
        TORUS,                  
    }
}
