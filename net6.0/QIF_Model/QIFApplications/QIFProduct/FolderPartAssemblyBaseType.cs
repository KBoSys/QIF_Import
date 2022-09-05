/*! \file FolderPartAssemblyBaseType.cs
	\brief The FolderPartAssemblyBaseType is the abstract base type that defines information about a part/assembly folder.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPD;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks> The FolderPartAssemblyBaseType is the abstract base type that defines information about a part/assembly folder.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FolderAssemblyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FolderPartType))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class FolderPartAssemblyBaseType : DrawableBaseType
    {
        /// <remarks> The optional FolderIds element contains indices of sub-folders.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceType? FolderIds { get; set; }

        /// <remarks> The optional FeatureNominalIds element contains feature nominals for the product definition.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceFullType? FeatureNominalIds { get; set; }

        /// <remarks> The optional FeatureZoneIds element contains feature zones for the product definition.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceFullType? FeatureZoneIds { get; set; }

        /// <remarks> The optional CharacteristicNominalIds element contains characteristic nominals for the product definition.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceFullType? CharacteristicNominalIds { get; set; }

        /// <remarks> The optional NoteIds element contains notes for the product definition.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceFullType? NoteIds { get; set; }

        /// <remarks> The optional PartNoteIds element contains part notes for the product definition.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceFullType? PartNoteIds { get; set; }

        /// <remarks> The optional DatumDefinitionIds element contains datum definitions for the product definition.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceFullType? DatumDefinitionIds { get; set; }

        /// <remarks> The optional DatumTargetDefinitionIds element contains datum target definitions for the product definition.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceFullType? DatumTargetDefinitionIds { get; set; }

        /// <remarks> The optional DatumReferenceFrameIds element contains datum reference frames for the product definition.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceFullType? DatumReferenceFrameIds { get; set; }

        /// <remarks> The optional BodyIds element is an array of body identifiers present in this block.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceType? BodyIds { get; set; }

        /// <remarks> The optional CoordinateSystemIds element is an array of coordinate system identifiers present in this block.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceType? CoordinateSystemIds { get; set; }

        /// <remarks> The optional AuxiliaryIds element is an array of auxiliary object identifiers present in this block.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceType? AuxiliaryIds { get; set; }

        /// <remarks> The optional ViewIds element is an array of view object identifiers present in this block.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceType? ViewIds { get; set; }

        /// <remarks> The optional PointCloudIds element is an array of point cloud identifiers present in this block.</remarks>
        [XmlElement]
        public QIFLibrary.Primitives.ArrayReferenceType? PointCloudIds { get; set; }
    }
}
