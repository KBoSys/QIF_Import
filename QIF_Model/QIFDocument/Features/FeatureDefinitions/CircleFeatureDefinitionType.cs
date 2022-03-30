/*! \file CircleFeatureDefinitionType.cs
    \brief 
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
		private FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributes attributesField;
		private string internalExternalField;
		private FeaturesFeatureDefinitionsCircleFeatureDefinitionDiameter diameterField;

		public CircleFeatureDefinitionType()
		{
		}

		/// <remarks/>
		public FeaturesFeatureDefinitionsCircleFeatureDefinitionAttributes Attributes
		{
			get => this.attributesField;
			set => this.attributesField = value;
		}

		/// <remarks/>
		public string InternalExternal
		{
			get => this.internalExternalField;
			set => this.internalExternalField = value;
		}

		/// <remarks/>
		public FeaturesFeatureDefinitionsCircleFeatureDefinitionDiameter Diameter
		{
			get => this.diameterField;
			set => this.diameterField = value;
		}
	}

}
