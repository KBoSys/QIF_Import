/*! \file PartAssemblyBaseType.cs
    \brief The PartAssemblyBaseType is the abstract base type that defines information about a part/assembly definition

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFProduct
{
	/// <remarks The PartAssemblyBaseType is the abstract base type that defines
	/// information about a part/assembly definition that was inspected or will be inspected./>
	public abstract class PartAssemblyBaseType : DrawableBaseType
	{
		/// <remarks The optional Validation element is a set of part/assembly validation properties./>
		[XmlElement(IsNullable = true)]
		public ValidationPartAssemblyType Validation { get; set; }

		/// <remarks The optional Header element is a description of the provenance of the file./>
		[XmlElement(IsNullable = true)]
		public PartAssemblyHeaderType Header { get; set; }

		/// <remarks The optional UUID element is a persistent identifier for
		/// the product definition.If used, it should be generated using a widely accepted UUID generator./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.QPIdType UUID { get; set; }

		/// <remarks The optional ModelNumber element is the identifier of a
		/// very specific type of product definition.There may be many
		/// product instances with the same ModelNumber, but they should all be identical (or nearly so)./>
		[XmlElement(IsNullable = true)]
		public string ModelNumber { get; set; }

		/// <remarks The optional Version element is the version of the product definition./>
		[XmlElement(IsNullable = true)]
		public string Version { get; set; }

		/// <remarks The optional SecurityClassification element describes the security classification of the product definition./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.PrimitivesPMI.SecurityClassificationType SecurityClassification { get; set; }

		/// <remarks The optional ExportControlClassification element describes
		/// the export control classification of the product definition./>
		[XmlElement(IsNullable = true)]
		public string ExportControlClassification { get; set; }

		/// <remarks The optional FeatureNominalIds element contains any feature nominals for the product definition./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType FeatureNominalIds { get; set; }

		/// <remarks The optional FeatureZoneIds element contains feature zones for the product definition./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType FeatureZoneIds { get; set; }

		/// <remarks The optional CharacteristicNominalIds element contains any characteristic nominals for the product definition./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType CharacteristicNominalIds { get; set; }

		/// <remarks The optional NoteIds element contains any notes for the product definition./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType NoteIds { get; set; }

		/// <remarks The optional PartNoteIds element contains any part notes for the product definition./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType PartNoteIds { get; set; }

		/// <remarks The optional DatumDefinitionIds element contains any datum definitions for the product definition./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType DatumDefinitionIds { get; set; }

		/// <remarks The optional DatumTargetDefinitionIds element contains any datum target definitions for the product definition./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType DatumTargetDefinitionIds { get; set; }

		/// <remarks The optional DatumReferenceFrameIds element contains any datum reference frames for the product definition./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType DatumReferenceFrameIds { get; set; }

		/// <remarks The optional BodyIds element is an array of body identifiers present in this block./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType BodyIds { get; set; }

		/// <remarks The optional CoordinateSystemIds element is an array of coordinate system identifiers present in this block./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType CoordinateSystemIds { get; set; }

		/// <remarks The optional AuxiliaryIds element is an array of auxiliary object identifiers present in this block./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType AuxiliaryIds { get; set; }

		/// <remarks The optional ViewIds element is an array of view object identifiers present in this block./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType ViewIds { get; set; }

		/// <remarks The optional PointCloudIds element is an array of point cloud identifiers present in this block./>
		[XmlElement(IsNullable = true)]
		public QIFLibrary.Primitives.ArrayReferenceType PointCloudIds { get; set; }

		/// <remarks The optional originMassProperty attribute is the origin point
		/// for calculating of objects mass properties contained in this block./>
		[XmlElement("originMassProperty", IsNullable = true)]
		public QIFLibrary.Primitives.PointSimpleType OriginMassProperty { get; set; }

		/// <remarks The optional materialIndex attribute specifies a material index in the material library./>
		[XmlElement("materialIndex", IsNullable = true)]
		public NaturalType MaterialIndex { get; set; }
	}
}
