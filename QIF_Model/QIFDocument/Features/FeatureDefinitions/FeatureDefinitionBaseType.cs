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

namespace QIF_Model.QIFDocument.Features.FeatureDefinitions
{
	/// <remarks/>
	[System.SerializableAttribute()]
	public abstract class FeatureDefinitionBaseType : FeatureBaseType
	{
	}
}
