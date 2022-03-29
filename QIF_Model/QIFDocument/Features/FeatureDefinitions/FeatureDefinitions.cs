/*! \file Definisions.cs
    \brief 

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
	public class FeatureDefinitions
	{
		private List<FeatureDefinitionBase> items = new List<FeatureDefinitionBase>();
		private byte nField;

		[XmlElement(ElementName = "CircleFeatureDefinition", Type = typeof(CircleFeatureDefinition))]
		[XmlElement(ElementName = "CircularArcFeatureDefinition", Type = typeof(CircularArcFeatureDefinition))]
		public List<FeatureDefinitionBase> Items { get => this.items; set => this.items = value; }

		/// <remarks/>
		[XmlAttribute]
		public byte n
		{
			get => this.nField;
			set => this.nField = value;
		}
	}
}
