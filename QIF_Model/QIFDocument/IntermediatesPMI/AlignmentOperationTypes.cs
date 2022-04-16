/*! \file CoordinateSystemsType.cs
 	\brief Definitions of AlignmentOperationType

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.IntermediatesPMI
{
    /// <remarks
    /// The AlignmentOperationBaseType is the abstract base type that
    /// defines a coordinate system alignment operation with a sequence
    /// number for ordering.Each alignment operation takes place in the
    /// current coordinate system, which is established as follows:
    ///   1. If a previous alignment operation exists, the current
    ///     coordinate system is the coordinate system established by the
    ///     previous alignment operation.
    ///   2. Otherwise, if the base coordinate system is defined, the
    ///     current coordinate system is the base coordinate system.
    ///   3. Otherwise, the current coordinate system is the common
    ///     coordinate system. />
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class AlignmentOperationBaseType
    {
        /// <remarks
        /// The SequenceNumber element is the sequence number of the
        /// alignment operation.The sequence numbers in an ordered set of
        /// alignment operations should be assigned 1, 2, 3, .../>
        [XmlElement]
        public NaturalType SequenceNumber { get; set; }

        /// <remarks
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured)./>
        [XmlElement(IsNullable = true)]
        public AttributesType Attributes { get; set; }  
    }

    /// <remarks
    /// The PrimaryAlignmentOperationType defines information particular to
    /// a primary alignment operation.In a primary alignment operation the
    /// coordinate system is aligned so that the measured feature axis or
    /// normal vector points exactly in the specified primary direction. />
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PrimaryAlignmentOperationType : AlignmentOperationBaseType
    {
        /// <remarks
        /// The PrimaryEntity element is the feature or datum for the
        /// primary alignment operation.This feature or datum must
        /// have an axis or normal vector. />
        [XmlElement(IsNullable = false)]
        public AlignmentFeatureType PrimaryEntity { get; set; }

        /// <remarks 
        /// The PrimaryAxis element is the direction in which the
        /// primary axis points in the current coordinate system./>
        [XmlElement(IsNullable = false)]
        public Primitives.UnitVectorType PrimaryAxis { get; set; }
    }

    /// <remarks
    /// The SecondaryAlignmentOperationType defines information particular
    /// to a secondary alignment operation.In a secondary alignment
    /// operation the coordinate system is aligned so that the measured
    /// feature axis or normal vector points as closely as possible in the
    /// specified secondary direction given the constraint that the primary
    /// alignment axis or rotation axis remains unchanged./>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SecondaryAlignmentOperationType : AlignmentOperationBaseType
    {
        /// <remarks
        /// The SecondaryEntity element is the feature or datum for the
        /// secondary alignment operation.This feature or datum must
        /// have an axis or normal vector. />
        [XmlElement(IsNullable = false)]
        public AlignmentFeatureType SecondaryEntity { get; set; }

        /// <remarks 
        /// The SecondaryAxis element is the direction in which the
        /// secondary axis points in the current coordinate system. />
        [XmlElement(IsNullable = false)]
        public Primitives.UnitVectorType SecondaryAxis { get; set; }

        /// <remarks 
        /// The optional RotationAxis element is the direction in the
        /// current coordinate system about which the coordinate system
        /// is rotated to establish the secondary axis.If absent the
        /// rotation axis will be the primary axis defined in a
        /// previous alignment operation. />
        [XmlElement(IsNullable = true)]
        public Primitives.UnitVectorType RotationAxis { get; set; }
    }

    /// <remarks
    /// The MeasurementOffsetAlignmentOperationType defines information
    /// particular to a measurement origin offset alignment operation./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class MeasurementOffsetAlignmentOperationType : AlignmentOperationBaseType
    {
        /// <remarks
        ///  Each Origin element describes one alignment feature setting an origin in one direction. />
        [XmlElement(ElementName = "Origin", Type = typeof(MeasurementOriginOffsetType))]
        public MeasurementOriginOffsetType[] OriginOffsets { get; set; }

        /// <remarks The required n attribute is the number of origin offsets specified. />
        [XmlAttribute("n")]
        public int Count
        {
            get => this.OriginOffsets.Length;
        }
    }

    /// <remarks
    /// The NominalOffsetAlignmentOperationType defines information particular to a nominal offset operation./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class NominalOffsetAlignmentOperationType : AlignmentOperationBaseType
    {
        /// <remarks
        /// The Offset element is the XYZ offset in the current coordinate system. />
        [XmlElement(IsNullable = false)]
        public Primitives.VectorType Offset { get; set; }
    }

    /// <remarks
    /// The NominalRotationAlignmentOperationType defines information particular to a nominal rotation alignment operation./>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class NominalRotationAlignmentOperationType : AlignmentOperationBaseType
    {
        /// <remarks
        /// The RotationAxis element is the direction in the current
        /// coordinate system about which the coordinate system is rotated. />
        [XmlElement(IsNullable = false)]
        public Primitives.UnitVectorType RotationAxis { get; set; }

        /// <remarks
        /// The Angle element is the angle through which the coordinate
        /// system is rotated.A positive angle represents a
        /// right-handed rotation about the rotation axis. />
        [XmlElement(IsNullable = false)]
        public Units.AngularValueType Angle { get; set; }
    }

    /// <remarks
    /// The DatumPrecedenceAlignmentOperationType defines information
    /// particular to a datum reference frame alignment operation using
    /// datum reference frame precedence and degrees of freedom rules. />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DatumPrecedenceAlignmentOperationType : AlignmentOperationBaseType
    {
        /// <remarks
        /// The DatumReferenceFrameId element is the QIF id of the
        /// datum reference frame used in the alignment operation. />
        [XmlElement(IsNullable = false)]
        public Primitives.QIFReferenceFullType DatumReferenceFrameId { get; set; }

        /// <remarks
        /// The PrimaryAxis element is the direction in which the
        /// primary axis points in the current coordinate system, the
        /// direction defined by the axis or normal of the primary datum. />
        [XmlElement(IsNullable = false)]
        public Primitives.UnitVectorType PrimaryAxis { get; set; }

        /// <remarks
        /// The optional SecondaryAxis element is the direction in
        /// which the secondary axis points in the current coordinate
        /// system, the direction defined by the axis, normal, or
        /// relative location of the secondary datum if present in the
        /// datum reference frame./>
        [XmlElement(IsNullable = false)]
        public Primitives.UnitVectorType SecondaryAxis { get; set; }
    }

    /// <remarks
    /// The BestFitAlignmentOperationType defines information particular to a best fit alignment operation. />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class BestFitAlignmentOperationType : AlignmentOperationBaseType
    {
        /// <remarks
        /// The DegreesOfFreedom element is the degrees of freedom for the best-fit alignment operation. />
        [XmlElement(IsNullable = false)]
        public DegreesOfFreedomType DegreesOfFreedom { get; set; }

        /// <remarks
        /// Each BaseFeature element is a base feature used in the best
        /// fit alignment.The number and placement of base features
        /// must be sufficient to control all degrees of freedom. />
        [XmlElement(ElementName = "BaseFeature", Type = typeof(BaseFeatureType))]
        public SequencedBaseFeatureType[] BaseFeatures { get; set; }

        /// <remarks The required n attribute is the number of base features used in the alignment./>
		[XmlAttribute("n")]
        public int Count
        {
            get => this.BaseFeatures.Length;
        }
    }

    /// <remarks
    /// The MachineCoordinateSystemOperationType defines a switch to
    /// machine coordinate system operation. />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class MachineCoordinateSystemOperationType : AlignmentOperationBaseType
    {
    }


    /// <remarks
    /// The MeasurementOriginOffsetType defines information particular to a
    /// measurement origin offset. />
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class MeasurementOriginOffsetType
	{
        /// <remarks
        /// The OriginEntity element is the feature or datum that defines an origin along the specified direction. />
        [XmlElement]
        public AlignmentFeatureType OriginEntity { get; set; }

        /// <remarks
        /// The OriginDirection element is the direction in the current coordinate system in which the origin is set. />
        [XmlElement]
        public Primitives.UnitVectorType OriginDirection { get; set; }
    }
}
