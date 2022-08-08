/*! \file CurveFeatureDefinitionBaseType.cs
    \brief 
        The CurveFeatureDefinitionBaseType is the abstract base type for
        shape feature definitions for features composed of curves.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointDefinedCurveFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherCurveFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeAngledLinesFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OppositeParallelLinesFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElongatedCircleFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticalArcFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipseFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularArcFeatureDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleFeatureDefinitionType))]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class CurveFeatureDefinitionBaseType : ShapeFeatureDefinitionBaseType
    {
    }
}
