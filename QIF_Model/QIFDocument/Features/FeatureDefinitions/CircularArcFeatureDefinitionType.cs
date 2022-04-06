/*! \file CircularArcFeatureDefinitionType.cs

        The CircularArcFeatureDefinitionType defines the circular arc
        feature nominal information that can be common to one or more
        circular arc features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFDocument.Features.FeatureDefinitions
{
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class CircularArcFeatureDefinitionType : FeatureDefinitionBaseType
	{
		private PrimitivesPMI.InternalExternalEnumType internalExternalField;
		public CircularArcFeatureDefinitionType()
		{
			internalExternalField = PrimitivesPMI.InternalExternalEnumType.INTERNAL;
		}

		/// <remarks The InternalExternal element indicates whether the feature is internal or external./>
		public PrimitivesPMI.InternalExternalEnumType InternalExternal
		{
			get => internalExternalField;
			set => internalExternalField = value;
		}

		/// <remarks The Radius element is the nominal radius of the circular arc feature./>
		public Units.LinearValueType Radius { get; set; }
	}
}
