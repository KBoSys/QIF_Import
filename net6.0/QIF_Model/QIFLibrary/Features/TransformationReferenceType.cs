﻿/*! \file TransformationReferenceType.cs
    \brief The TransformationReferenceType defines a component of a coordinate
        system to be used in a transform-by construction.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features
{
    /// <remarks> The TransformationReferenceType defines a component of a coordinate system to be used in a transform-by construction.</remarks>
    public class TransformationReferenceType
    {
        /// <remarks> The ReferencedComponent element indicates whether the measured or nominal component of this coordinate system is referenced.</remarks>
        [XmlElement]
        public IntermediatesPMI.ReferencedComponentEnumType ReferencedComponent { get; set; }

        /// <remarks> The CoordinateSystemId element is the QIF id of the coordinate system used in a feature transform construction.</remarks>
        [XmlElement]
        public QIFReferenceFullType? CoordinateSystemId { get; set; } = new QIFReferenceFullType();

        /// <remarks> The SequenceNumber element is an ordinal number defining the order of the base feature in the construction.</remarks>
        [XmlElement]
        public uint SequenceNumber { get; set; }
    }
}
