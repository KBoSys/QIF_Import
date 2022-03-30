/*! \file FeatureDefinitionsType.cs
    \brief 
            The optional FeatureDefinitions element is a list of
            definitions of the inspection features.

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
	//[XmlRoot(Namespace = "", IsNullable = false)]
	public class FeatureDefinitionsType
	{
		private List<FeatureBaseType> items = new List<FeatureBaseType>();
		private byte nField;

		[XmlElement(ElementName = "CircleFeatureDefinition", Type = typeof(CircleFeatureDefinitionType))]
		[XmlElement(ElementName = "CircularArcFeatureDefinition", Type = typeof(CircularArcFeatureDefinitionType))]
		public List<FeatureBaseType> Items { get => this.items; set => this.items = value; }

		/// <remarks/>
		[XmlAttribute]
		public byte n
		{
			get => this.nField;
			set => this.nField = value;
		}
	}
}
