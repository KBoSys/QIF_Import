﻿/*! \file CoordinateSystemsType.cs
 	\brief Defines a collection of coordinate systems

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks>
    /// The CoordinateSystemsType defines a collection of coordinate systems
    /// and optionally identifies which is the common coordinate system and
    /// which are machine coordinate systems.
    /// </remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CoordinateSystemsType
    {
        public CoordinateSystemsType() { }

        /// <remarks>
        /// The CoordinateSystemDefinitions element is a list coordinate
        /// system definitions.</remarks>
        [XmlElement]
        public CoordinateSystemListType CoordinateSystemDefinitions { get; set; }

        /// <remarks> 
        /// The optional CommonCoordinateSystemId element is the QIF id of
        /// the coordinate system which corresponds to the common
        /// coordinate system.</remarks>
        [XmlElement()]
        public Primitives.QIFReferenceFullType CommonCoordinateSystemId { get; set; }

        /// <remarks>
        /// Each optional MachineCoordinateSystem element is the QIF id of
        /// a coordinate system which corresponds to the machine
        /// coordinate system of a particular measurement device. </remarks>
        [XmlElement("MachineCoordinateSystem", Type = typeof(MachineCoordinateSystemType))]
        public MachineCoordinateSystemType[] MachineCoordinateSystems { get; set; }
    }

    /// <remarks>
    /// The MachineCoordinateSystemType defines the id of a coordinate
    /// system which is a machine coordinate system and optionally the
    /// measurement device id associated with that machine coordinate system. </remarks>
    [System.SerializableAttribute()]
    public class MachineCoordinateSystemType
    {
        /// <remarks>
        /// The CoordinateSystemId element is the QIF id of the machine coordinate system. </remarks>
        [XmlElement(IsNullable = false)]
        public Primitives.QIFReferenceFullType CoordinateSystemId { get; set; }

        /// <remarks>
        /// The optional MeasurementDeviceId element is the QIF id of
        /// the measurement device associated with the machine coordinate system. </remarks>
        [XmlElement()]
        public Primitives.QIFReferenceFullType MeasurementDeviceId { get; set; }
    }

    /// <remarks>
    /// The CoordinateSystemListType defines a list of one or more
    /// coordinate systems.The one coordinate system which corresponds to
    /// the common coordinate system in which all characteristics,
    /// features, and transforms are defined can be indicated.The
    /// coordinate system which represents the machine coordinate system
    /// may also be indicated. </remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CoordinateSystemListType : ArrayBaseType<CoordinateSystemType>
    {
        /// <remarks> Each CoordinateSystem element is a coordinate system in the list.</remarks>
		[XmlElement(ElementName = "CoordinateSystem", Type = typeof(CoordinateSystemType))]
        public CoordinateSystemType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks></remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CoordinateSystemType : QIFIdTypeBase
    {
        /// <remarks> 
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).</remarks>
        [XmlElement()]
        Primitives.AttributesType Attributes { get; set; }

        /// <remarks> The optional Name element is the name of the coordinate system.</remarks>
        [XmlElement()]
        public string Name { get; set; }

        /// <remarks> 
        /// The optional NominalTransform element gives the nominal
        /// transformation matrix used to establish the coordinate system.</remarks>
        [XmlElement()]
        public Primitives.TransformMatrixType NominalTransform { get; set; }

        /// <remarks> 
        /// The optional InternalCADCoordinateSystemId element identifies
        /// an associated coordinate system defined in an internal product
        /// definition.</remarks>
        [XmlElement()]
        public Primitives.QIFReferenceFullType InternalCADCoordinateSystemId { get; set; }

        /// <remarks> 
        /// The optional ExternalCADCoordinateSystemId element identifies
        /// an associated coordinate system defined in an external product
        /// definition.</remarks>
        [XmlElement()]
        public Primitives.QIFReferenceFullType ExternalCADCoordinateSystemId { get; set; }

        /// <remarks>
        /// The optional AlignmentOperations element gives the ordered
        /// series of alignment operations used to establish the coordinate
        /// system.</remarks>
        [XmlElement()]
        public AlignmentOperationsType AlignmentOperations { get; set; }

        /// <remarks>
        /// The optional SequenceNumber element is the sequence number of
        /// the coordinate system used to order coordinate systems with the
        /// same name from an iterative alignment.The sequence numbers in
        /// an ordered set of coordinate systems should be assigned 1, 2, 3, ...</remarks>
        [XmlElement()]
        public NaturalType SequenceNumber { get; set; }
    }

    /// <remarks> The AlignmentOperationsType defines a list of one or more ordered alignment operations. </remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AlignmentOperationsType : ArrayBaseType<AlignmentOperationBaseType>
    {
        /// <remarks> Each AlignmentOperation element is an ordered alignment operation.</remarks>
		[XmlElement(ElementName = "PrimaryAlignment", Type = typeof(PrimaryAlignmentOperationType))]
        [XmlElement(ElementName = "SecondaryAlignment", Type = typeof(SecondaryAlignmentOperationType))]
        [XmlElement(ElementName = "MeasurementOffset", Type = typeof(MeasurementOffsetAlignmentOperationType))]
        [XmlElement(ElementName = "NominalOffset", Type = typeof(NominalOffsetAlignmentOperationType))]
        [XmlElement(ElementName = "NominalRotation", Type = typeof(NominalRotationAlignmentOperationType))]
        [XmlElement(ElementName = "DatumPrecedence", Type = typeof(DatumPrecedenceAlignmentOperationType))]
        [XmlElement(ElementName = "BestFit", Type = typeof(BestFitAlignmentOperationType))]
        [XmlElement(ElementName = "Machine", Type = typeof(MachineCoordinateSystemOperationType))]
        public AlignmentOperationBaseType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The AngularCoordinateDirectionEnumType enumerates values that
    /// describe the direction for an angular coordinate characteristic.
    /// (See LinearCoordinateDirectionEnumType for usage guidelines.)</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum AngularCoordinateDirectionEnumType
    {
        ANGULAR,
        AZIMUTH,
        POLAR,
    }

    /// <remarks>
    /// The LinearCoordinateDirectionEnumType enumerates values that
    /// describe the direction for a linear coordinate characteristic.
    /// XAXIS and YAXIS are used with a 2D Cartesian coordinate system.
    /// RADIAL and ANGULAR are used with a 2D Polar coordinate system.
    /// XAXIS, YAXIS, and ZAXIS are used with a 3D Cartesian coordinate system.
    /// RADIAL, AZIMUTH, and ZAXIS are used with a 3D Cylindrical coordinate system.
    /// RADIAL, POLAR, and AZIMUTH are used with a 3D Spherical coordinate system.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LinearCoordinateDirectionEnumType
    {
        XAXIS,
        YAXIS,
        ZAXIS,
        RADIAL,
    }
}