/*! \file Nominals.cs
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
	public partial class Nominals
	{

		private FeaturesFeatureNominalsCircleFeatureNominal circleFeatureNominalField;

		private FeaturesFeatureNominalsCircularArcFeatureNominal circularArcFeatureNominalField;

		private FeaturesFeatureNominalsConeFeatureNominal coneFeatureNominalField;

		private byte nField;

		/// <remarks/>
		public FeaturesFeatureNominalsCircleFeatureNominal CircleFeatureNominal
		{
			get
			{
				return this.circleFeatureNominalField;
			}
			set
			{
				this.circleFeatureNominalField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsCircularArcFeatureNominal CircularArcFeatureNominal
		{
			get
			{
				return this.circularArcFeatureNominalField;
			}
			set
			{
				this.circularArcFeatureNominalField = value;
			}
		}

		/// <remarks/>
		public FeaturesFeatureNominalsConeFeatureNominal ConeFeatureNominal
		{
			get
			{
				return this.coneFeatureNominalField;
			}
			set
			{
				this.coneFeatureNominalField = value;
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
