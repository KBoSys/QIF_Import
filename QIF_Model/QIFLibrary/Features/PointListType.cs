/*! \file PointListType.cs
	\brief defines a list of ordered nominal measurement points

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features
{
	/// <remarks The PointListType defines a list of ordered nominal measurement
	/// points or a list of ordered measured points by referencing point sets and point subsets./>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
	public class PointListType
	{
		/// <remarks Each PointSetId is a reference to a point set or a portion thereof./>
		[XmlElement(ElementName = "WholePointSetId", Type = typeof(IntermediatesPMI.PointSetReferenceWholeType))]
		[XmlElement(ElementName = "RangePointSetId", Type = typeof(IntermediatesPMI.PointSetReferenceRangeType))]
		[XmlElement(ElementName = "SinglePointSetId", Type = typeof(IntermediatesPMI.PointSetReferenceSingleType))]
		public IntermediatesPMI.PointSetReferenceBaseType[] Points { get; set; }

		/// <remarks The required n attribute is the number of point set references in the list./>
		[XmlAttribute("n")]
		public int Count
		{
			get => this.Points.Length;
			set { }
		}
	}
}
