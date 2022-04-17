﻿/*! \file DatumFeatureBaseType.cs
	\brief Defines Datum Features

    The DatumFeatureType exists for DMIS harmonization.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
    /// <remarks 
    /// The DatumFeatureBaseType is the abstract base type that defines a
    /// component of a datum reference frame(i.e., one of the boxes on the
    /// right side of a feature control frame) when that component uses a
    /// datum feature without an assigned datum label.
    /// />
	public abstract class DatumFeatureBaseType
	{
        /// <remarks 
        /// The FeatureNominalId element is the QIF id of the feature nominal of the datum feature.
        /// />
        [XmlElement]
        public Primitives.QIFReferenceFullType FeatureNominalId { get; set; }
    }

    /// <remarks 
    /// The MeasuredDatumFeatureType defines a DatumFeatureBaseType in which
    /// the datum feature is to be established from the measured feature.
    /// />
	public class MeasuredDatumFeatureType : DatumFeatureBaseType
    {
        /// <remarks 
        /// The MaterialModifier element is the material condition or material boundary modifier for the datum feature.
        /// />
        [XmlElement]
        public MaterialModifierEnumType MaterialModifier { get; set; }

        /// <remarks 
        /// The optional SubstituteFeatureAlgorithm element is the
        /// substitute feature data fitting algorithm for the datum
        /// feature.This setting overrides any substitute feature
        /// algorithm defined on the datum feature nominal or datum
        /// feature item for the purpose of establishing a datum
        /// reference frame.
        /// />
        [XmlElement(IsNullable = true)]
        public SubstituteFeatureAlgorithmType SubstituteFeatureAlgorithm { get; set; }
    }

    /// <remarks 
    /// The NominalDatumFeatureType defines a DatumFeatureBaseType in which
    /// the datum feature is to be established from the nominal feature.
    /// />
	public class NominalDatumFeatureType : DatumFeatureBaseType
    {
    }

    /// <remarks 
    /// The SubstituteFeatureAlgorithmEnumType enumerates values that
    /// describe the type of algorithm used to determine the substitute feature.
    /// />
    public enum SubstituteFeatureAlgorithmEnumType
    { 
      BEZIER,
      BSPLINE,
      DEFAULT,
      LEASTSQUARES,
      MAXINSCRIBED,
      MAXINNERLOCALSIZE,
      MAXOUTERLOCALSIZE,
      MINCIRCUMSCRIBED,
      MININNERLOCALSIZE,
      MINOUTERLOCALSIZE,
      MINMAX,
      NURBS,
      ONESIDED,
      UNDEFINED,
    }

    /// <remarks 
    /// The SubstituteFeatureAlgorithmType defines the type of algorithm
    /// used to determine the substitute feature
    /// />
	public class SubstituteFeatureAlgorithmType
    {
        /// <remarks 
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// />
        [XmlElement(IsNullable = true)]
        AttributesType Attributes { get; set; }

        //---> choice
        /// <remarks 
        /// The SubstituteFeatureAlgorithmEnum element describes an
        /// often-used type of algorithm used to determine the substitute feature.
        /// />
        [XmlElement(IsNullable = true)]
        public Nullable<SubstituteFeatureAlgorithmEnumType> SubstituteFeatureAlgorithmEnum { get; set; }

        /// <remarks 
        /// The SubstituteFeatureAlgorithmId element is the id of an algorithm definition.
        /// />
        [XmlElement(IsNullable = true)]
        public Primitives.QIFReferenceType SubstituteFeatureAlgorithmId { get; set; }

        /// <remarks 
        /// The OtherSubstituteFeatureAlgorithm element describes the type of algorithm used to determine the
        /// substitute feature in natural language.
        /// />
        [XmlElement(IsNullable = true)]
        public string OtherSubstituteFeatureAlgorithm { get; set; }

        //<--- choice
    }
}
