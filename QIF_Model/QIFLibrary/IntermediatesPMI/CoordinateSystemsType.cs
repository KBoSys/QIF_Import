/*! \file CoordinateSystemsType.cs
 	\brief Defines a collection of coordinate systems

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFApplications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks
    /// The CoordinateSystemsType defines a collection of coordinate systems
    /// and optionally identifies which is the common coordinate system and
    /// which are machine coordinate systems.
    /// />
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CoordinateSystemsType
    {
        public CoordinateSystemsType() { }

        /// <remarks
        /// The CoordinateSystemDefinitions element is a list coordinate
        /// system definitions./>
        [XmlElement]
        public CoordinateSystemListType CoordinateSystemDefinitions { get; set; }

        /// <remarks 
        /// The optional CommonCoordinateSystemId element is the QIF id of
        /// the coordinate system which corresponds to the common
        /// coordinate system./>
        [XmlElement()]
        public Primitives.QIFReferenceFullType CommonCoordinateSystemId { get; set; }

        /// <remarks
        /// Each optional MachineCoordinateSystem element is the QIF id of
        /// a coordinate system which corresponds to the machine
        /// coordinate system of a particular measurement device. />
        [XmlElement("MachineCoordinateSystem", Type = typeof(MachineCoordinateSystemType))]
        public MachineCoordinateSystemType[] MachineCoordinateSystems { get; set; }
    }

    /// <remarks
    /// The MachineCoordinateSystemType defines the id of a coordinate
    /// system which is a machine coordinate system and optionally the
    /// measurement device id associated with that machine coordinate system. />
    [System.SerializableAttribute()]
    public class MachineCoordinateSystemType
	{
        /// <remarks
        /// The CoordinateSystemId element is the QIF id of the machine coordinate system. />
        [XmlElement(IsNullable = false)]
        public Primitives.QIFReferenceFullType CoordinateSystemId { get; set; }

        /// <remarks
        /// The optional MeasurementDeviceId element is the QIF id of
        /// the measurement device associated with the machine coordinate system. />
        [XmlElement()]
        public Primitives.QIFReferenceFullType MeasurementDeviceId { get; set; }
    }

    /// <remarks
    /// The CoordinateSystemListType defines a list of one or more
    /// coordinate systems.The one coordinate system which corresponds to
    /// the common coordinate system in which all characteristics,
    /// features, and transforms are defined can be indicated.The
    /// coordinate system which represents the machine coordinate system
    /// may also be indicated. />
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CoordinateSystemListType
    {
        /// <remarks Each CoordinateSystem element is a coordinate system in the list./>
		[XmlElement(ElementName = "CoordinateSystem", Type = typeof(CoordinateSystemType))]
        public CoordinateSystemType[] CoordinateSystems { get; set; }

        /// <remarks The required n attribute is the number of coordinate systems in the list./>
		[XmlAttribute("n")]
        public int Count
        {
            get => this.CoordinateSystems.Length;
            set { }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CoordinateSystemType : QIFIdTypeBase
    {
        /// <remarks 
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured)./>
        [XmlElement()]
        Primitives.AttributesType Attributes { get; set; }

        /// <remarks The optional Name element is the name of the coordinate system./>
        [XmlElement()]
        public string Name { get; set; }

        /// <remarks 
        /// The optional NominalTransform element gives the nominal
        /// transformation matrix used to establish the coordinate system./>
        [XmlElement()]
        public Primitives.TransformMatrixType NominalTransform { get; set; }

        /// <remarks 
        /// The optional InternalCADCoordinateSystemId element identifies
        /// an associated coordinate system defined in an internal product
        /// definition./>
        [XmlElement()]
        public Primitives.QIFReferenceFullType InternalCADCoordinateSystemId { get; set; }

        /// <remarks 
        /// The optional ExternalCADCoordinateSystemId element identifies
        /// an associated coordinate system defined in an external product
        /// definition./>
        [XmlElement()]
        public Primitives.QIFReferenceFullType ExternalCADCoordinateSystemId { get; set; }

        /// <remarks
        /// The optional AlignmentOperations element gives the ordered
        /// series of alignment operations used to establish the coordinate
        /// system./>
        [XmlElement()]
        public AlignmentOperationsType AlignmentOperations { get; set; }

        /// <remarks
        /// The optional SequenceNumber element is the sequence number of
        /// the coordinate system used to order coordinate systems with the
        /// same name from an iterative alignment.The sequence numbers in
        /// an ordered set of coordinate systems should be assigned 1, 2, 3, .../>
        [XmlElement()]
        public NaturalType SequenceNumber { get; set; }
    }

    /// <remarks The AlignmentOperationsType defines a list of one or more ordered alignment operations. />
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AlignmentOperationsType
    {
        /// <remarks Each AlignmentOperation element is an ordered alignment operation./>
		[XmlElement(ElementName = "PrimaryAlignment", Type = typeof(PrimaryAlignmentOperationType))]
        [XmlElement(ElementName = "SecondaryAlignment", Type = typeof(SecondaryAlignmentOperationType))]
        [XmlElement(ElementName = "MeasurementOffset", Type = typeof(MeasurementOffsetAlignmentOperationType))]
        [XmlElement(ElementName = "NominalOffset", Type = typeof(NominalOffsetAlignmentOperationType))]
        [XmlElement(ElementName = "NominalRotation", Type = typeof(NominalRotationAlignmentOperationType))]
        [XmlElement(ElementName = "DatumPrecedence", Type = typeof(DatumPrecedenceAlignmentOperationType))]
        [XmlElement(ElementName = "BestFit", Type = typeof(BestFitAlignmentOperationType))]
        [XmlElement(ElementName = "Machine", Type = typeof(MachineCoordinateSystemOperationType))]
        public AlignmentOperationBaseType[] AlignmentOperations { get; set; }

        /// <remarks The required n attribute is the number of coordinate systems in the list./>
		[XmlAttribute("n")]
        public int Count
        {
            get => this.AlignmentOperations.Length;
            set { }
        }
    }
}
