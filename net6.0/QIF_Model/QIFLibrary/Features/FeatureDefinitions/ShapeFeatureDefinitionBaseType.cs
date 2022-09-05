/*! \file ShapeFeatureDefinitionBaseType.cs
	
	The ShapeFeatureDefinitionBaseType is the abstract base type for
    shape feature definitions. A shape feature definition holds that
    portion of shape feature nominal information which can be shared
    among several features, e.g. feature size.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class ShapeFeatureDefinitionBaseType : FeatureDefinitionBaseType
    {
    }
}
