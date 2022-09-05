/*! \file QIFDocumenType.cs
    \brief The QIFDocumentType defines a QIF document.

    QIFDocument is the highest level element of all QIF instance files.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    [System.Xml.Serialization.XmlRootAttribute("QIFDocument", Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public class QIFDocumentType
    {
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string xsiSchemaLocation = "http://qifstandards.org/xsd/qif3 ../QIFApplications/QIFDocument.xsd";

        private string versionQIFField = "3.0.0";

        #region Properties
        /// <summary>
        /// The QIF persistent identifier for the document. This is a universally unique identifier.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Primitives.QPIdType? QPId { get; set; }

        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// </summary>
        [XmlElement]
        public QIFLibrary.Primitives.AttributesType? Attributes { get; set; }

        /// <summary>
        /// Version history information about the file
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.VersionHistoryType? VersionHistory { get; set; }

        /// <summary>
        /// Version information about the file, including TimeCreated and Signoffs.
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.VersionBaseType? Version { get; set; }

        /// <summary>
        /// The Header contains information about the creation of the
        /// file containing the CAD model and global parameters of the model.
        /// </summary>
        [XmlElement]
        public QIFDocumentHeaderType? Header { get; set; }

        /// <summary>
        /// The size of each of about 50 lists of QIF elements. 
        /// This is provided so that an application can check the integrity of the document 
        /// by checking the counts against the actual numbers of elements in the lists. 
        /// Each count is optional. If a count is omitted for a list, it does not imply that there are zero elements in the list.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Traceability.ValidationCountsType? ValidationCounts { get; set; }

        /// <summary>
        /// A description of quality checks applied to the document
        /// </summary>
        [XmlElement]
        public QIFLibrary.Traceability.ProductDataQualityType? ProductDataQuality { get; set; }

        /// <summary>
        /// A list of external QIF documents referenced in the document, with a local id for each external document
        /// </summary>
        [XmlElement]
        public ExternalQIFReferencesType? ExternalQIFReferences { get; set; }

        /// <summary>
        /// A list of standards referenced in the document.
        /// </summary>
        [XmlElement]
        public QIFLibrary.StandardsType? StandardsDefinitions { get; set; }

        /// <summary>
        /// A list of software systems referenced in the document.
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.SoftwaresType? SoftwareDefinitions { get; set; }

        /// <summary>
        /// A list of algorithm definitions referenced in the document.
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.AlgorithmsType? AlgorithmDefinitions { get; set; }

        /// <summary>
        /// Information about the provenance of the file before inspection has occurred.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Traceability.PreInspectionTraceabilityType? PreInspectionTraceability { get; set; }

        /// <summary>
        /// Information about the units used in the file.
        /// </summary>
        [XmlElement]
        public FileUnitsType? FileUnits { get; set; }

        /// <summary>
        /// A list of datum definitions
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.DatumDefinitionsType? DatumDefinitions { get; set; }

        /// <summary>
        /// A list of datum targets.
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.DatumTargetDefinitionsType? DatumTargetDefinitions { get; set; }

        /// <summary>
        /// A list of transforms
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.TransformListType? Transforms { get; set; }

        /// <summary>
        /// A list of coordinate systems
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.CoordinateSystemsType? CoordinateSystems { get; set; }

        /// <summary>
        /// A list of datum reference frames
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.DatumReferenceFramesType? DatumReferenceFrames { get; set; }

        /// <summary>
        /// Information about measurement resources
        /// </summary>
        [XmlElement]
        public MeasurementResources.MeasurementResourcesType? MeasurementResources { get; set; }

        /// <summary>
        /// The optional ThreadSpecifications element gives information about the thread specifications used in the QIF document.
        /// </summary>
        [XmlElement]
        public QIFLibrary.IntermediatesPMI.ThreadSpecificationsType? ThreadSpecifications { get; set; }

        /// <summary>
        /// The optional Product element gives information about the parts and assemblies used in the QIF document.
        /// </summary>
        [XmlElement]
        public QIFProduct.ProductType? Product { get; set; }

        /// <summary>
        /// Information about parts and assemblies, both designs and physical instances of the designs.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Features.FeatureAspectsListsType? Features { get; set; }

        /// <summary>
        /// The optional FeatureZones element gives information about the feature zones used in the QIF document.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Features.FeatureZoneListType? FeatureZones { get; set; }

        /// <summary>
        /// The optional Characteristics element gives information about the characteristics used in the QIF document.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Characteristics.CharacteristicAspectsListsType? Characteristics { get; set; }

        /// <summary>
        /// The optional Plan element gives information about the measurement plan used in the QIF document.
        /// </summary>
        [XmlElement]
        public QIFPlan.PlanType? Plan { get; set; }

        /// <summary>
        /// The optional Results element gives information about the measurement results used in the QIF document.
        /// </summary>
        [XmlElement]
        public QIFResults.ResultsType? Results { get; set; }

        /// <summary>
        /// The optional Statistics element gives information about statistical plans and the statistical results in the QIF document.
        /// </summary>
        [XmlElement]
        public QIFStatistics.StatisticsType? Statistics { get; set; }

        /// <summary>
        /// The optional ManufacturingProcessTraceabilities element gives
        /// traceability information about the manufacturing process or processes used.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Traceability.ManufacturingProcessTraceabilitiesType? ManufacturingProcessTraceabilities { get; set; }

        /// <summary>
        /// The optional Rules element gives information about rules
        /// in the QIF document for selecting on a per-feature basis any or all of 
        /// (1) the quantity of hit points to use,
        /// (2) the strategy to use for locating hit points, and
        /// (3) the substitute feature algorithm to use.
        /// </summary>
        [XmlElement]
        public QIFRules.QIFRulesType? Rules { get; set; }

        /// <summary>
        /// The UserDataXML element defines a user-defined XML structure
        /// from any namespace that is not the target namespace.The XML
        /// processor will validate elements if the corresponding schema
        /// will be presented.If the schema cannot be obtained, no errors will occur.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Primitives.UserDataXMLType? UserDataXML { get; set; }

        /// <summary>
        /// The Signature element is as defined in the XML-Signature Syntax and Processing W3C Recommendation 12 February 2002.
        /// </summary>
        [XmlElement]
        public QIFLibrary.Signature.SignatureType? Signature { get; set; }
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string versionQIF
        {
            get => versionQIFField;
            set => versionQIFField = value;
        }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public UInt32 idMax { get; set; }

        #endregion
    }
}
