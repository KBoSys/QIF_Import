/*! \file FeatureDefinitionBaseType.cs
    \brief 
        The FeatureDefinitionBaseType is the abstract base type for feature
        definitions. A feature definition holds that portion of feature
        nominal information which can be shared among several features,
        e.g. feature size.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class FeatureDefinitionBaseType : FeatureBaseType
	{
	}
}
