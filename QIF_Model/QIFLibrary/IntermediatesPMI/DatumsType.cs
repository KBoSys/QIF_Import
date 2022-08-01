/*! \file DatumReferenceFramesType.cs
	\brief Defines a list of datums.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks 
    /// (ISO specific) The DiameterModifierEnumType enumerates values
    /// that describe diameter modifiers for threaded datum features.
    /// />
    public enum DiameterModifierEnumType
    {
        None, PD, LD, MD
    }

    /// <remarks 
    /// (ISO specific) The SectionModifierEnumType enumerates values
    /// that establish datums or features section by section:
    /// />
    public enum SectionModifierEnumType
    {
        None,
        ACS, ///> any cross section
        ALS, ///> any longitudinal section.
        SCS, ///> specific fixed cross section
    }

    /// <remarks 
    /// (ISO specific) The ReducedDatumEnumType enumerates values
    /// that describe the reduction of a datum feature to a simpler
    /// type, e.g.a sphere to a point(PT), a cone to a straight line
    /// (SL), an opposite parallel planes feature to a plane(PL), etc.
    /// />
    public enum ReducedDatumEnumType
    {
        None,
        PT, ///> Point
        SL, ///> Stright Line
        PL, ///> Parallel Planes
    }

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
            set { }
        }
    }

    /// <remarks 
    /// The DatumWithPrecedenceType defines a datum reference with precedence in a feature control frame.
    /// />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumWithPrecedenceType
    {
        private object datumField;

        [XmlElement(ElementName = "SimpleDatum", Type = typeof(DatumType))]
        [XmlElement(ElementName = "NominalDatumFeature", Type = typeof(NominalDatumFeatureType))]
        [XmlElement(ElementName = "MeasuredDatumFeature", Type = typeof(MeasuredDatumFeatureType))]
        [XmlElement(ElementName = "CompoundDatum", Type = typeof(CompoundDatumType))]
        public object Datum { get => datumField; set => datumField = value; }

        /// <remarks 
        /// The NominalDatumFeature element is a feature used as a datum
        /// without an assigned datum label.The nominal feature is used
        /// to establish the datum feature.
        /// />
        [XmlIgnore]
        public NominalDatumFeatureType NominalDatumFeature
        {
            get => datumField as NominalDatumFeatureType;
            set => datumField = value;
        }

        /// <remarks 
        /// The MeasuredDatumFeature element is a feature used as a datum
        /// without an assigned datum label.The measured feature is used
        /// to establish the datum feature.
        /// />
        [XmlIgnore]
        public MeasuredDatumFeatureType MeasuredDatumFeature
        {
            get => datumField as MeasuredDatumFeatureType;
            set => datumField = value;
        }

        /// <remarks 
        /// The CompoundDatum element is a compound datum with assigned labels separated by dashes.
        /// />
        [XmlIgnore]
        public CompoundDatumType CompoundDatum
        {
            get => datumField as CompoundDatumType;
            set => datumField = value;
        }

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
    /// The DatumFeatureSimulatorModifierType defines a datum feature
    /// simulator size modifier like that found in square brackets in a datum reference frame.
    /// />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumFeatureSimulatorModifierType
    {
        //---> choice
        /// <remarks 
        /// The LinearSize element is the linear size of the datum feature
        /// simulator size modifier in a datum reference frame.
        /// />
        [XmlElement()]
        public Units.LinearValueType LinearSize { get; set; }

        /// <remarks 
        /// The DiametricalSize element is the diameter of the datum
        /// feature simulator size modifier in a datum reference frame.
        /// />
        [XmlElement()]
        public Units.LinearValueType DiametricalSize { get; set; }

        /// <remarks 
        /// The BasicSize element signifies that the size of the datum
        /// feature simulator is to be its basic size as indicated by
        /// [BASIC] or[BSC] in the datum reference frame.
        /// />
        [XmlElement()]
        public string BasicSize { get; set; }
        //<--- choice
    }

    /// <remarks 
    /// The DatumTranslationType defines whether a datum can translate and
    /// therefore act as an aligning datum rather than a clocking datum.
    /// />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumTranslationType
    {
        /// <remarks 
        /// The DatumTranslationAllowed element indicates if the datum is
        /// an aligning datum("true") rather than the default clocking datum("false").
        /// />
        [XmlElement]
        public bool DatumTranslationAllowed { get; set; }
    }

    /// <remarks 
    /// The DatumType defines a simple datum reference for use in a feature control frame.
    /// />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumType
    {
        /// <remarks 
        /// The DatumDefinitionId element is the QIF id of a datum
        /// definition type. A datum definition type assigns a datum label
        /// and can associate a feature with that datum label.
        /// />
        [XmlElement]
        public Primitives.QIFReferenceFullType DatumDefinitionId { get; set; }

        /// <remarks 
        /// The MaterialModifier element is the material condition or
        /// material boundary modifier for the datum in a feature control frame.
        /// ASME Y14.5 - 2009 Sections 1.3.38, 1.3.39, 3.4
        /// />
        [XmlElement]
        public MaterialModifierEnumType MaterialModifier { get; set; }

        /// <remarks 
        /// The optional SizeCharacteristicDefinitionId element is the QIF
        /// id of the associated datum feature size characteristic used to
        /// derive bonus mobility for maximum and least material boundary conditions.
        /// />
        [XmlElement()]
        public Primitives.QIFReferenceFullType SizeCharacteristicDefinitionId { get; set; }

        /// <remarks 
        /// The ReferencedComponent element identifies whether the datum is
        /// established from the measured feature or the nominal feature.
        /// />
        [XmlElement(IsNullable = false)]
        public ReferencedComponentEnumType ReferencedComponent { get; set; }

        /// <remarks 
        /// The optional SubstituteFeatureAlgorithm element is the
        /// substitute feature data fitting algorithm for the datum.This
        /// setting overrides any substitute feature algorithm defined on
        /// the datum feature nominal or datum feature item for the purpose
        /// of establishing a datum reference frame.
        /// />
        [XmlElement()]
        public SubstituteFeatureAlgorithmType SubstituteFeatureAlgorithm { get; set; }

        /// <remarks 
        /// The optional DatumFeatureSimulatorModifier element is the datum
        /// feature simulator size modifier found in a datum reference frame.
        /// />
        [XmlElement()]
        public DatumFeatureSimulatorModifierType DatumFeatureSimulatorModifier { get; set; }

        /// <remarks 
        /// The optional DatumTranslation element specifies whether datum
        /// translation is allowed as indicated by the datum translation
        /// symbol found in a datum reference frame.
        /// />
        [XmlElement()]
        public DatumTranslationType DatumTranslation { get; set; }

        /// <remarks 
        /// The optional DegreesOfFreedom element gives the degrees of
        /// freedom controlled by the datum.
        /// />
        [XmlElement()]
        public DegreesOfFreedomType DegreesOfFreedom { get; set; }

        /// <remarks 
        /// (ISO specific (P)) The optional ProjectedDatum element gives
        /// the distance a datum feature is projected in a feature control frame.
        /// />
        [XmlElement()]
        public Units.LinearValueType ProjectedDatum { get; set; }

        /// <remarks 
        /// (ISO specific PD,MD,LD) The optional DiameterModifier element
        /// is the diameter modifier for a threaded datum feature in a
        /// feature control frame.
        /// />
        [XmlElement()]
        [System.ComponentModel.DefaultValueAttribute(typeof(DiameterModifierEnumType), "None")]
        public DiameterModifierEnumType DiameterModifier { get; set; } = DiameterModifierEnumType.None;

        /// <remarks 
        /// (ISO specific ACS,SCS,ALS) The optional SectionModifier element
        /// is the cross section modifier for a datum feature in a feature
        /// control frame.
        /// />
        [XmlElement()]
        [System.ComponentModel.DefaultValueAttribute(typeof(SectionModifierEnumType), "None")]
        public SectionModifierEnumType SectionModifier { get; set; } = SectionModifierEnumType.None;

        /// <remarks 
        /// (ISO specific CF) The optional ContactingFeature element when
        /// present and set to true indicates that the measured datum
        /// feature comes into contact with a nominal datum feature of a
        /// different type.
        /// />
        [XmlElement()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ContactingFeature { get; set; }

        /// <remarks 
        /// (ISO specific DV) The optional DistanceVariable element when
        /// present and set to true indicates that the datum has a variable distance.
        /// />
        [XmlElement()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DistanceVariable { get; set; }

        /// <remarks 
        /// (ISO specific DF) The optional DatumFixed element when present
        /// and set to true indicates that the datum location has been
        /// fixed by higher precedence datums.
        /// />
        [XmlElement()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DatumFixed { get; set; }

        /// <remarks 
        /// (ISO specific PT,SL,PL) The optional ReducedDatum element
        /// specifies that the datum feature is reduced to a simpler type.
        /// />
        [XmlElement()]
        [System.ComponentModel.DefaultValueAttribute(typeof(ReducedDatumEnumType), "None")]
        public ReducedDatumEnumType ReducedDatum { get; set; } = ReducedDatumEnumType.None;

        /// <remarks 
        /// (ISO specific greaterthan/lessthan) The optional
        /// ConstrainOrientation element if present and set to true
        /// specifies that this datum constrains only the orientation of
        /// subsequent datums and the feature control frame.
        /// />
        [XmlElement()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ConstrainOrientation { get; set; }

        /// <remarks 
        /// (ISO specific lessthan/greaterthan) The optional
        /// ConstrainSubsequent element if present and set to true
        /// specifies that this datum constrains only subsequent datums and
        /// not the feature control frame itself.
        /// />
        [XmlElement()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ConstrainSubsequent { get; set; }

        /// <remarks 
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// />
        [XmlElement()]
        public Primitives.AttributesType Attributes { get; set; }
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
            set { }
        }
    }

    /// <remarks 
    /// The SequencedDatumType defines a datum reference with a sequence
    /// number for ordering in a compound datum.
    /// />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SequencedDatumType
    {
        /// <remarks 
        /// This compositor provides a choice between a datum with a simple
        /// label and a nested compound datum label(with an optional
        /// reduction modifier) to handle ISO specific cases such as
        /// (A-B)[PT]-(C-D)[SL].
        /// />

        #region Choice
        /// <remarks The Datum element is a simple datum with an assigned label. >/
        [XmlElement]
        public DatumType SimpleDatum { get; set; }

        /// <remarks (ISO specific) The CompoundDatum element is a nested compound datum. >/
        [XmlElement]
        public CompoundDatumType CompoundDatum { get; set; }
        #endregion

        /// <remarks 
        /// The SequenceNumber element is the sequence number of the datum
        /// in a compound datum.The sequence numbers in an ordered set of
        /// datums should be assigned 1, 2, 3, ... >/
        [XmlElement]
        public QIFApplications.NaturalType SequenceNumber { get; set; }
    }

    /// <remarks (ISO specific) The CollectionPlaneType defines a collection plane feature control frame modifier./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CollectionPlaneType
    {
        /// <remarks The CollectionPlaneEnum element specifies how the collection plane is derived from the datum./>
        public ModifyingPlaneEnumType CollectionPlaneEnum { get; set; }

        /// <remarks The DatumDefinitionId element identifies the datum from which the collection plane is derived./>
        public Primitives.QIFReferenceFullType DatumDefinitionId { get; set; }
    }

    /// <remarks (ISO specific) The IntersectionPlaneEnumType enumerates values that describe the how the intersection plane is derived./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum IntersectionPlaneEnumType
    {
        PARALLEL,
        PERPENDICULAR,
        INCLUDING,
    }

    /// <remarks (ISO specific) The IntersectionPlaneType defines an intersection plane feature control frame modifier./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class IntersectionPlaneType
    {
        /// <remarks The IntersectionPlaneEnum element specifies how the intersection plane is derived from the datum./>
        public IntersectionPlaneEnumType IntersectionPlaneEnum { get; set; }

        /// <remarks The DatumDefinitionId element identifies the datum from which the intersection plane is derived./>
        public Primitives.QIFReferenceFullType DatumDefinitionId { get; set; }
    }

    /// <remarks (ISO specific) The OrientationPlaneType defines an orientation plane feature control frame modifier./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class OrientationPlaneType
    {
        /// <remarks The OrientationPlaneEnum element specifies how the orientation plane is derived from the datum./>
        public ModifyingPlaneEnumType OrientationPlaneEnum { get; set; }

        /// <remarks The DatumDefinitionId element identifies the datum from which the orientation plane is derived./>
        public Primitives.QIFReferenceFullType DatumDefinitionId { get; set; }
    }
}
