/*! \file FeatureTypeEnumType.cs
    \brief enumerates types of features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks The FeatureTypeEnumType enumerates types of features.
    /// The enumeration values represent the names of the feature types defined in Features.xsd./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum FeatureTypeEnumType
    {
        CIRCLE,                 ///<remarks CircleFeatureItemType />
        CIRCULARARC,            ///<remarks CircularArcFeatureItemType />
        CONE,                   ///<remarks ConeFeatureItemType />
        CONICALSEGMENT,         ///<remarks ConicalSegmentFeatureItemType />
        CYLINDER,               ///<remarks CylinderFeatureItemType />
        CYLINDRICALSEGMENT,     ///<remarks CylindricalSegmentFeatureItemType />
        EDGEPOINT,              ///<remarks EdgePointFeatureItemType />
        ELLIPSE,                ///<remarks EllipseFeatureItemType />
        ELLIPTICALARC,          ///<remarks EllipticalArcFeatureItemType />
        ELONGATEDCIRCLE,        ///<remarks ElongatedCircleFeatureItemType />
        ELONGATEDCYLINDER,      ///<remarks ElongatedCylinderFeatureItemType />
        EXTRUDEDCROSSSECTION,   ///<remarks ExtrudedCrossSectionFeatureItemType />
        GROUP,                  ///<remarks GroupFeatureItemType />
        LINE,                   ///<remarks LineFeatureItemType />
        MARKING,                ///<remarks MarkingFeatureItemType />
        OPPOSITEANGLEDLINES,    ///<remarks OppositeAngledLinesFeatureItemType />
        OPPOSITEANGLEDPLANES,   ///<remarks OppositeAngledPlanesFeatureItemType />
        OPPOSITEPARALLELLINES,  ///<remarks OppositeParallelLinesFeatureItemType />
        OPPOSITEPARALLELPLANES, ///<remarks OppositeParallelPlanesFeatureItemType />
        OTHERCURVE,             ///<remarks OtherCurveFeatureItemType />
        OTHERNONSHAPE,          ///<remarks OtherNonShapeFeatureItemType />
        OTHERSHAPE,             ///<remarks OtherShapeFeatureItemType />
        OTHERSURFACE,           ///<remarks OtherSurfaceFeatureItemType />
        PATTERN,                ///<remarks PatternFeatureItemBaseType(any pattern feature) />
        PATTERNCIRCLE,          ///<remarks PatternFeatureCircleItemType />
        PATTERNCIRCULARARC,     ///<remarks PatternFeatureCircularArcItemType />
        PATTERNLINEAR,          ///<remarks PatternFeatureLinearItemType />
        PATTERNPARALLELOGRAM,   ///<remarks PatternFeatureParallelogramItemType />
        PLANE,                  ///<remarks PlaneFeatureItemType />
        POINT,                  ///<remarks PointFeatureItemType />
        POINTDEFINEDCURVE,      ///<remarks PointDefinedCurveFeatureItemType />
        POINTDEFINEDSURFACE,    ///<remarks PointDefinedSurfaceFeatureItemType />
        SPHERE,                 ///<remarks SphereFeatureItemType />
        SPHERICALSEGMENT,       ///<remarks SphericalSegmentFeatureItemType />
        SURFACEOFREVOLUTION,    ///<remarks SurfaceOfRevolutionFeatureItemType />
        THREADED,               ///<remarks ThreadedFeatureItemType />
        TOROIDALSEGMENT,        ///<remarks ToroidalSegmentFeatureItemType />
        TORUS,                  ///<remarks TorusFeatureItemType />
    }
}
