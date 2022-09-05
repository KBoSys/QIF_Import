﻿/*! \file PointListType.cs
	\brief defines a list of ordered nominal measurement points

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Visualization;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features
{
    /// <remarks> The PointListType defines a list of ordered nominal measurement
    /// points or a list of ordered measured points by referencing point sets and point subsets.</remarks>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PointListType : ArrayBaseType<IntermediatesPMI.PointSetReferenceBaseType>
    {
        /// <remarks> Each PointSetId is a reference to a point set or a portion thereof.</remarks>
        [XmlElement(ElementName = "WholePointSetId", Type = typeof(IntermediatesPMI.PointSetReferenceWholeType))]
        [XmlElement(ElementName = "RangePointSetId", Type = typeof(IntermediatesPMI.PointSetReferenceRangeType))]
        [XmlElement(ElementName = "SinglePointSetId", Type = typeof(IntermediatesPMI.PointSetReferenceSingleType))]
        public IntermediatesPMI.PointSetReferenceBaseType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
