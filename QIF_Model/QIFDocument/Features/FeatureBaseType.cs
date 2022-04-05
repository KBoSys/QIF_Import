/*! \file FeatureBaseType.cs
    \brief 
    The FeatureBase is the abstract base type for feature
    definitions, feature nominals, feature items, and feature
    measurements. It describes a subset of information common to all
    features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Features
{
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public abstract class FeatureBaseType
	{
		private QIFIdType _id = new QIFIdType(0);

		/// <summary>
		/// The optional Attributes element contains user defined
		/// attributes(typified, binary array, or XML structured).
		/// </summary>
		[XmlElement]
		Attributes Attributes { get; set; }

		/// <summary>
		/// The id attribute is the QIF id of the feature, used for referencing.
		/// </summary>
		[XmlIgnore]
		public QIFIdType QIFID { get => _id; }

		/// <summary>
		/// The id attribute is the QIF id of the feature, used for referencing.
		/// </summary>
		[XmlAttribute]
		public UInt32 id { get => this._id; set => this._id = value; }
	}
}
