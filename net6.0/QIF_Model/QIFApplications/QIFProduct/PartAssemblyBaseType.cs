/*! \file PartAssemblyBaseType.cs
	\brief abstract base type that defines information about a part/assembly definition

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFApplications.QIFProduct
{
    /// <remarks> The PartAssemblyBaseType is the abstract base type that defines
    /// information about a part/assembly definition that was inspected or will be inspected.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AssemblyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PartAssemblyBaseType : DrawableBaseType
    {
        /// <remarks> The optional Validation element is a set of part/assembly validation properties.</remarks>
        public ValidationPartAssemblyType? Validation { get; set; }

        /// <remarks> The optional Header element is a description of the provenance of the file.</remarks>
        public PartAssemblyHeaderType? Header { get; set; }

        /// <remarks> The optional UUID element is a persistent identifier for
        /// the product definition.If used, it should be generated using a widely accepted UUID generator.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public QPIdType? UUID { get; set; }

        /// <remarks> The optional ModelNumber element is the identifier of a
        /// very specific type of product definition.There may be many
        /// product instances with the same ModelNumber, but they should all be identical (or nearly so).</remarks>
        public string? ModelNumber { get; set; }

        /// <remarks> The optional Version element is the version of the product definition.</remarks>
        public string? Version { get; set; }

        /// <remarks> The optional SecurityClassification element describes the security classification of the product definition.</remarks>
        public SecurityClassificationType? SecurityClassification { get; set; }

        /// <remarks> The optional ExportControlClassification element describes
        /// the export control classification of the product definition.</remarks>
        public string? ExportControlClassification { get; set; }

        /// <remarks> The optional FeatureNominalIds element contains any feature
        /// nominals for the product definition.</remarks>
        public ArrayReferenceFullType? FeatureNominalIds { get; set; }

        /// <remarks> The optional FeatureZoneIds element contains feature zones for the product definition.</remarks>
        public ArrayReferenceFullType? FeatureZoneIds { get; set; }

        /// <remarks> The optional CharacteristicNominalIds element contains any characteristic nominals for the product definition.</remarks>
        public ArrayReferenceFullType? CharacteristicNominalIds { get; set; }

        /// <remarks> The optional NoteIds element contains any notes for the product definition.</remarks>
        public ArrayReferenceFullType? NoteIds { get; set; }

        /// <remarks> The optional PartNoteIds element contains any part notes for the product definition.</remarks>
        public ArrayReferenceFullType? PartNoteIds { get; set; }

        /// <remarks> The optional DatumDefinitionIds element contains any datum definitions for the product definition.</remarks>
        public ArrayReferenceFullType? DatumDefinitionIds { get; set; }

        /// <remarks> The optional DatumTargetDefinitionIds element contains any datum target definitions for the product definition.</remarks>
        public ArrayReferenceFullType? DatumTargetDefinitionIds { get; set; }

        /// <remarks> The optional DatumReferenceFrameIds element contains any datum reference frames for the product definition.</remarks>
        public ArrayReferenceFullType? DatumReferenceFrameIds { get; set; }

        /// <remarks> The optional BodyIds element is an array of body identifiers present in this block.</remarks>
        public ArrayReferenceType? BodyIds { get; set; }

        /// <remarks> The optional CoordinateSystemIds element is an array of coordinate system identifiers present in this block.</remarks>
        public ArrayReferenceType? CoordinateSystemIds { get; set; }

        /// <remarks> The optional AuxiliaryIds element is an array of auxiliary object identifiers present in this block.</remarks>
        public ArrayReferenceType? AuxiliaryIds { get; set; }

        /// <remarks> The optional ViewIds element is an array of view object identifiers present in this block.</remarks>
        public ArrayReferenceType? ViewIds { get; set; }

        /// <remarks> The optional PointCloudIds element is an array of point cloud identifiers present in this block.</remarks>
        public ArrayReferenceType? PointCloudIds { get; set; }

        private PointSimpleType? originMassPropertyField;

        /// <remarks> The optional originMassProperty attribute is the origin point
        /// for calculating of objects mass properties contained in this block.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("originMassProperty")]
        public double[]? OriginMassProperty 
        { 
            get => originMassPropertyField?.Value; 
            set => originMassPropertyField = new PointSimpleType(value); }

        /// <remarks> The optional materialIndex attribute specifies a material index in the material library.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("materialIndex")]
        public uint MaterialIndex { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaterialIndexSpecified { get; set; }
    }
}
