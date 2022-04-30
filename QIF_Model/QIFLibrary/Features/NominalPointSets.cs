/*! \file NominalPointSets.cs
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
	public partial class NominalPointSets
	{

		private FeaturesNominalPointSetsNominalPointSet[] nominalPointSetField;

		private byte nField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("NominalPointSet")]
		public FeaturesNominalPointSetsNominalPointSet[] NominalPointSet
		{
			get
			{
				return this.nominalPointSetField;
			}
			set
			{
				this.nominalPointSetField = value;
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
