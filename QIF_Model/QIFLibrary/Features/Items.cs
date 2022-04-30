/*! \file Items.cs
    \brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Features
{
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class Items
	{

		private FeaturesFeatureItemsCircleFeatureItem circleFeatureItemField;

		private FeaturesFeatureItemsCircularArcFeatureItem circularArcFeatureItemField;

		private FeaturesFeatureItemsConeFeatureItem coneFeatureItemField;

		private byte nField;

		/// <remarks/>
		public FeaturesFeatureItemsCircleFeatureItem CircleFeatureItem
		{
			get
			{
				return this.circleFeatureItemField;
			}
			set
			{
				this.circleFeatureItemField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsCircularArcFeatureItem CircularArcFeatureItem
		{
			get
			{
				return this.circularArcFeatureItemField;
			}
			set
			{
				this.circularArcFeatureItemField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureItemsConeFeatureItem ConeFeatureItem
		{
			get
			{
				return this.coneFeatureItemField;
			}
			set
			{
				this.coneFeatureItemField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte n
		{
			get
			{
				return this.nField;
			}
			set
			{
				this.nField = value;
			}
		}
	}
}
