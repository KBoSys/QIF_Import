﻿/*! \file LineFeatureDefinitionType.cs
	\brief defines the line feature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
	/// <remarks The LineFeatureDefinitionType defines the line feature nominal
	/// information that can be common to one or more line features. 
	/// There is no definition information for a line feature beyond what is
	/// provided by the CurveFeatureDefinitionBaseType./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class LineFeatureDefinitionType : CurveFeatureDefinitionBaseType
	{
	}
}
