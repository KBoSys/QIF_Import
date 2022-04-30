/*! \file FeatureBaseType.cs
    \brief 
    The FeatureBase is the abstract base type for feature
    definitions, feature nominals, feature items, and feature
    measurements. It describes a subset of information common to all
    features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class FeatureBaseType : QIFApplications.QIFIdTypeBase
	{
		/// <summary>
		/// The optional Attributes element contains user defined
		/// attributes(typified, binary array, or XML structured).
		/// </summary>
		[XmlElement]
		QIFLibrary.Primitives.AttributesType Attributes { get; set; }
	}
}
