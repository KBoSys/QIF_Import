/*! \file CircleFeatureDefinitionType.cs

	The CircleFeatureDefinition defines circle feature nominal
    information that can be common to one or more circle features.

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
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class CircleFeatureDefinitionType : CurveFeatureDefinitionBaseType
	{
		private PrimitivesPMI.InternalExternalEnumType internalExternalField;

		public CircleFeatureDefinitionType()
		{
			internalExternalField = PrimitivesPMI.InternalExternalEnumType.INTERNAL;
		}

		/// <remarks The InternalExternal element indicates whether the feature is internal or external./>
		public PrimitivesPMI.InternalExternalEnumType InternalExternal 
		{ 
			get => internalExternalField; 
			set => internalExternalField = value; 
		}

		/// <remarks The Diameter element is the nominal diameter of the circle feature./>
		public Units.LinearValueType Diameter { get; set; }
	}
}
