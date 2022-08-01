/*! \file CurveFeatureDefinitionBaseType.cs
    \brief 
        The CurveFeatureDefinitionBaseType is the abstract base type for
        shape feature definitions for features composed of curves.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class CurveFeatureDefinitionBaseType : ShapeFeatureDefinitionBaseType
    {
    }
}
