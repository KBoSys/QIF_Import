﻿/*! \file CylindricalSegmentFeatureDefinitionType.cs
	\brief Defines cylindrical segment feature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureDefinitions
{
	/// <remarks The CylindricalSegmentFeatureDefinitionType defines the cylindrical
	/// segment feature nominal information that can be common to one or more cylindrical segment features./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class CylindricalSegmentFeatureDefinitionType : SurfaceFeatureDefinitionBaseType
	{
		/// <remarks The InternalExternal element indicates whether the feature is internal or external./>
		[XmlElement]
		public QIFLibrary.PrimitivesPMI.InternalExternalEnumType InternalExternal { get; set; }

		/// <remarks The Diameter element is the nominal diameter of the circle feature./>
		[XmlElement]
		public QIFLibrary.Units.LinearValueType Diameter { get; set; }

		/// <remarks The optional Length element is the nominal length of the
		/// cylindrical segment from the start point in the direction of the cylindrical segment axis./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Units.LinearValueType Length { get; set; }

		/// <remarks The optional Bottom element is the bottom type of the cylindrical segment./>
		[XmlElement(IsNullable = true)]
		public PrimitivesPMI.BottomType Bottom { get; set; }
	}
}
