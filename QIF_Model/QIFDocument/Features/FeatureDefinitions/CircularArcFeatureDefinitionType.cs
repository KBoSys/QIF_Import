/*! \file CircularArcFeatureDefinitionType.cs
    \brief 

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
		private string internalExternalField;
		private FeaturesFeatureDefinitionsCircularArcFeatureDefinitionRadius radiusField;

		/// <remarks/>
		public string InternalExternal
		{
			get => this.internalExternalField;
			set => this.internalExternalField = value;
		}

		/// <remarks/>
		public FeaturesFeatureDefinitionsCircularArcFeatureDefinitionRadius Radius
		{
			get => this.radiusField;
			set => this.radiusField = value;
		}
	}
}
