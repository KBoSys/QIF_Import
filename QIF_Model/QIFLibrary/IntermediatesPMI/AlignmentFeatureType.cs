/*! \file AlignmentFeatureType.cs
 	\brief Definition of AlignmentFeatureType

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks
    /// The ReferencedComponentEnumType enumerates values that describe
    /// whether the nominal or measured component of a feature or coordinate
    /// system is used in a construction, characteristic or datum reference. />
    public enum ReferencedComponentEnumType
    {
        NOMINAL,
        ACTUAL,
    }

    /// <remarks
    /// The BaseFeatureType defines a feature used in a construction or alignment. />
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class BaseFeatureType
    {
        /// <remarks
        ///  The ReferencedComponent element identifies whether the measured
        ///  or nominal component of this feature is used in the
        ///  construction or alignment. />
        [XmlElement]
        public ReferencedComponentEnumType ReferencedComponent { get; set; }

        /// <remarks
        ///  The FeatureId element is the QIF id of a feature nominal in the
        ///  case where a construction is defined at the feature nominal
        ///  level, or the QIF id of a feature item in the case where a
        ///  construction is defined at the feature item level.The allowed
        ///  values of FeatureId are restricted by key/keyref pairs. />
        [XmlElement]
        public Primitives.QIFReferenceFullType FeatureId { get; set; }
    }

    /// <remarks
    /// The SequencedBaseFeatureType defines a feature that is one of a set
    /// of features used in a construction or alignment. />
    public class SequencedBaseFeatureType : BaseFeatureType
    {
        /// <remarks
        /// The SequenceNumber element is an ordinal number specifying
        /// the order of the base feature in the construction or alignment. />
        [XmlElement]
        public QIFApplications.NaturalType SequenceNumber { get; set; }
    }

    /// <remarks
    /// The AlignmentFeatureType defines a reference to an alignment
    /// feature, either a datum or a feature item. />
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AlignmentFeatureType
    {
        /// <remarks
        ///  The DatumDefinitionId element is the QIF id of the datum definition used in the alignment operation.
        /// />
        [XmlElement]
        public Primitives.QIFReferenceFullType DatumDefinitionId { get; set; }

        /// <remarks
        ///  The BaseFeature element is the feature used in an alignment operation.
        /// />
        [XmlElement]
        public BaseFeatureType BaseFeature { get; set; }
    }
}
