/*! \file DatumReferenceFramesType.cs
	\brief Defines a list of datums.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
    /// <remarks 
    /// The DatumsType defines the list of datums in the datum reference
    /// component of a feature control frame. Each of the up to five parts
    /// of the datum reference component represents the contents of a box
    /// on the right side of the feature control frame.
    /// />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumsType
	{
        /// <remarks 
        /// Each Datum element is a datum(simple, compound, or datum feature) with an assigned precedence(order). />
		[XmlElement(ElementName = "Datum", Type = typeof(DatumWithPrecedenceType))]
        public DatumWithPrecedenceType[] Datums { get; set; }

        /// <remarks The required n attribute is the number of datum reference frames in the list./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.Datums.Length;
        }
    }

    /// <remarks 
    /// The DatumWithPrecedenceType defines a datum reference with precedence in a feature control frame.
    /// />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumWithPrecedenceType
    {
        //---> choice

        /// <remarks 
        /// The NominalDatumFeature element is a feature used as a datum
        /// without an assigned datum label.The nominal feature is used
        /// to establish the datum feature.
        /// />
        [XmlElement]
        public NominalDatumFeatureType NominalDatumFeature { get; set; }

        /// <remarks 
        /// The MeasuredDatumFeature element is a feature used as a datum
        /// without an assigned datum label.The measured feature is used
        /// to establish the datum feature.
        /// />
        [XmlElement]
        public MeasuredDatumFeatureType MeasuredDatumFeature { get; set; }

        /// <remarks 
        /// The CompoundDatum element is a compound datum with assigned labels separated by dashes.
        /// />
        [XmlElement]
        public CompoundDatumType CompoundDatum { get; set; }

        //<--- choice

        /// <remarks 
        /// The Precedence element is the precedence of the datum. It is
        /// the order in the feature control frame of the datum with
        /// respect to other datums, or the order of the datum in a
        /// compound datum with respect to other datums.
        /// 
        /// In any feature control frame or compound datum, no two datums
        /// may have the same precedence, and there may be no gaps in the
        /// precedences(for example, a QUATERNARY precedence may not be
        /// assigned unless PRIMARY, SECONDARY, and TERTIARY are also assigned).
        /// />
        [XmlElement]
        public PrecedenceType Precedence { get; set; }
    }

    /// <remarks 
    /// The CompoundDatumType defines a compound datum specified by two or more datums with assigned labels.
    /// />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CompoundDatumType
    {
        /// <remarks 
        /// Each Datum element gives a datum with assigned datum labels. At
        /// least two datums are required, and there is no maximum number.
        /// The sequence number is used to order the datums in the compound datum.
        /// />
		[XmlElement(ElementName = "SequencedDatum", Type = typeof(SequencedDatumType))]
        public SequencedDatumType[] SequencedDatums { get; set; }

        /// <remarks 
        /// (ISO specific PT,SL,PL) The optional ReducedDatum element
        /// specifies that the compound datum is reduced to a simpler type to handle a case like(A-B)[PT].
        /// />
        [XmlElement]
        public ReducedDatumEnumType ReducedDatum { get; set; }

        /// <remarks The required n attribute is the number of datums in the compound datum./>
        [XmlAttribute("n")]
        public int Count
        {
            get => this.SequencedDatums.Length;
        }
    }
}
