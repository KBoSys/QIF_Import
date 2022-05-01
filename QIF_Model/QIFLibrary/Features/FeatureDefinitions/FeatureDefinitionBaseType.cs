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
	/// <remarks The FeatureDefinitionBaseType is the abstract base type for feature
	/// definitions.A feature definition holds that portion of feature
	/// nominal information which can be shared among several features,	e.g.feature size./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class FeatureDefinitionBaseType : FeatureBaseType
	{
	}

	/// <remarks The NonShapeFeatureDefinitionBaseType is the abstract base type for
	/// non-shape feature definitions.A non-shape feature definition holds
	/// that portion of non-shape feature nominal information which can be shared among several features, e.g.feature size./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class NonShapeFeatureDefinitionBaseType : FeatureDefinitionBaseType
	{
	}

	/// <remarks The PatternFeatureDefinitionBaseType is the abstract base type that
	/// defines the pattern feature nominal information that can be common	to one or more pattern features./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class PatternFeatureDefinitionBaseType : GroupFeatureDefinitionType
	{
	}


	/// <remarks The SpecifiedFeatureDefinitionBaseType is the abstract base type
	/// for shape feature definitions for features that are defined	indirectly by a specification rather than by a direct shape description./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class SpecifiedFeatureDefinitionBaseType : ShapeFeatureDefinitionBaseType
	{
	}
}
