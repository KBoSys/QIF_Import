/*! \file QIFDocumenType.cs
    \brief The QIFDocumentType defines a QIF document.

    QIFDocument is the highest level element of all QIF instance files.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFDocument.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "QIFDocument", Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class QIFDocumentType
    {
        public QIFDocumentType() { }

        #region Properties
        /// <summary>
        /// The QIF persistent identifier for the document. This is a universally unique identifier.
        /// </summary>
        [XmlElement]
        public Primitives.QPIdType QPId { get; set; }

        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// </summary>
        [XmlElement]
        public AttributesType Attributes { get; set; }

        /// <summary>
        /// Version history information about the file
        /// </summary>
        [XmlElement]
        public IntermediatesPMI.VersionHistoryType VersionHistory { get; set; }

        /// <summary>
        /// Version information about the file, including TimeCreated and Signoffs.
        /// </summary>
        [XmlElement]
        public IntermediatesPMI.VersionBaseType Version { get; set; }

        /// <summary>
        /// The Header contains information about the creation of the
        /// file containing the CAD model and global parameters of the model.
        /// </summary>
        [XmlElement]
        public QIFDocumentHeaderType Header { get; set; }

        /// <summary>
        /// The size of each of about 50 lists of QIF elements. 
        /// This is provided so that an application can check the integrity of the document 
        /// by checking the counts against the actual numbers of elements in the lists. 
        /// Each count is optional. If a count is omitted for a list, it does not imply that there are zero elements in the list.
        /// </summary>
        [XmlElement]
        public Traceability.ValidationCountsType ValidationCounts { get; set; }

        /// <summary>
        /// A description of quality checks applied to the document
        /// </summary>
        [XmlElement]
        public Traceability.ProductDataQualityType ProductDataQuality { get; set; }

        /// <summary>
        /// A list of external QIF documents referenced in the document, with a local id for each external document
        /// </summary>
        public QIFDocumentExternalQIFReferences ExternalQIFReferences { get; set; }

        /// <summary>
        /// A list of standards referenced in the document.
        /// </summary>
        [XmlElement]
        public StandardsType StandardsDefinitions { get; set; }

        /// <summary>
        /// A list of software systems referenced in the document.
        /// </summary>
        public QIFDocumentSoftwareDefinitions SoftwareDefinitions { get; set; }

        /// <summary>
        /// A list of algorithm definitions referenced in the document.
        /// </summary>
        public QIFDocumentAlgorithmDefinitions AlgorithmDefinitions { get; set; }

        /// <summary>
        /// Information about the provenance of the file before inspection has occurred.
        /// </summary>
        [XmlElement]
        public Traceability.PreInspectionTraceabilityType PreInspectionTraceability { get; set; }

        /// <summary>
        /// Information about the units used in the file.
        /// </summary>
        [XmlElement]
        public FileUnitsType FileUnits { get; set; }

		/// <summary>
		/// A list of datum definitions
		/// </summary>
		[XmlElement]
		public IntermediatesPMI.DatumDefinitionsType DatumDefinitions { get; set; }

		/// <summary>
		/// A list of datum targets.
		/// </summary>
		[XmlElement]
        public IntermediatesPMI.DatumTargetDefinitionsType DatumTargetDefinitions { get; set; }

        /// <summary>
        /// A list of transforms
        /// </summary>
        [XmlElement]
        public IntermediatesPMI.TransformListType Transforms { get; set; }

        /// <summary>
        /// A list of coordinate systems
        /// </summary>
        public QIFDocumentCoordinateSystems CoordinateSystems { get; set; }

        /// <summary>
        /// A list of datum reference frames
        /// </summary>
        public QIFDocumentDatumReferenceFrames DatumReferenceFrames { get; set; }

        /// <summary>
        /// Information about measurement resources
        /// </summary>
        public QIFDocumentMeasurementResources MeasurementResources { get; set; }

        /// <summary>
        /// A list of thread specifications
        /// </summary>
        public QIFDocumentThreadSpecifications ThreadSpecifications { get; set; }

        /// <summary>
        /// Information about parts and assemblies, both designs and physical instances of the designs.
        /// </summary>
        public QIFDocumentProduct Product { get; set; }

        /// <summary>
        /// Information about parts and assemblies, both designs and physical instances of the designs.
        /// </summary>
        public Features.Features Features { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versionQIF { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UInt32 idMax { get; set; }
        #endregion
    }
}
