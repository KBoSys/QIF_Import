/*! \file ShapeFeatureDefinitionBaseType.cs
    \brief 
        The ShapeFeatureDefinitionBaseType is the abstract base type for
        shape feature definitions. A shape feature definition holds that
        portion of shape feature nominal information which can be shared
        among several features, e.g. feature size.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFDocument.Features.FeatureDefinitions
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class ShapeFeatureDefinitionBaseType : FeatureDefinitionBaseType
	{
	}
}
