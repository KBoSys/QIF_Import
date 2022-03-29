/*! \file QIFDocument.cs
    \brief QIFDocument is the highest level element of all QIF instance files.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFDocument
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public partial class QIFDocument
    {
        #region Private Members
        private string qPIdField;                                                       //!> the QIF unique identifier for the document
		private QIFDocumentAttributes attributesField;                                  //!> Provides the user with opportunity to attach typed information that is not modeled in QIF.
        private QIFDocumentVersionHistory versionHistoryField;                          //!> Version history information about the file
        private QIFDocumentVersion versionField;                                        //!> Version information about the file
        private QIFDocumentHeader headerField;                                          //!> Identification of the source of the file and the scope of the file
        private QIFDocumentValidationCounts validationCountsField;                      //!> The size of each of about 50 lists of QIF elements. 
        private QIFDocumentProductDataQuality productDataQualityField;                  //!> a description of quality checks applied to the document
        private QIFDocumentExternalQIFReferences externalQIFReferencesField;            //!> a list of external QIF documents referenced in the document
        private QIFDocumentStandardsDefinitions standardsDefinitionsField;              //!> a list of standards referenced in the document.
        private QIFDocumentSoftwareDefinitions softwareDefinitionsField;                //!> a list of software systems referenced in the document.
        private QIFDocumentAlgorithmDefinitions algorithmDefinitionsField;              //!> a list of algorithm definitions referenced in the document.
        private QIFDocumentPreInspectionTraceability preInspectionTraceabilityField;    //!> information about the provenance of the file before inspection has occurred.
        private FileUnits.FileUnits fileUnitsField;                                     //!> information about the units used in the file.
        private QIFDocumentDatumDefinitions datumDefinitionsField;                      //!> a list of datum definitions
        private QIFDocumentDatumTargetDefinitions datumTargetDefinitionsField;          //!> a list of datum targets
        private QIFDocumentTransforms transformsField;                                  //!> a list of transforms
        private QIFDocumentCoordinateSystems coordinateSystemsField;                    //!> a list of coordinate systems
        private QIFDocumentDatumReferenceFrames datumReferenceFramesField;              //!> a list of datum reference frames
        private QIFDocumentMeasurementResources measurementResourcesField;              //!> information about measurement resources
        private QIFDocumentThreadSpecifications threadSpecificationsField;              //!> a list of thread specifications
        private QIFDocumentProduct productField;                                        //!> information about parts and assemblies
        private Features.Features featuresField;                                        //!> contains the geometrical information 

        private string versionQIFField;
        private byte idMaxField;
		#endregion
		#region Properties
		/// <summary>
		/// The QIF persistent identifier for the document. This is a universally unique identifier.
		/// </summary>
		public string QPId
        {
            get
            {
                return this.qPIdField;
            }
            set
            {
                this.qPIdField = value;
            }
        }

        /// <summary>
        /// Provides the user with opportunity to attach typed information that is not modeled in QIF.
        /// </summary>
        public QIFDocumentAttributes Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <summary>
        /// Version history information about the file
        /// </summary>
        public QIFDocumentVersionHistory VersionHistory
        {
            get
            {
                return this.versionHistoryField;
            }
            set
            {
                this.versionHistoryField = value;
            }
        }

        /// <summary>
        /// Version information about the file, including TimeCreated and Signoffs.
        /// </summary>
        public QIFDocumentVersion Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <summary>
        /// Identification of the source of the file and the scope of the file.
        /// </summary>
        public QIFDocumentHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <summary>
        /// The size of each of about 50 lists of QIF elements. 
        /// This is provided so that an application can check the integrity of the document 
        /// by checking the counts against the actual numbers of elements in the lists. 
        /// Each count is optional. If a count is omitted for a list, it does not imply that there are zero elements in the list.
        /// </summary>
        public QIFDocumentValidationCounts ValidationCounts
        {
            get
            {
                return this.validationCountsField;
            }
            set
            {
                this.validationCountsField = value;
            }
        }

        /// <summary>
        /// A description of quality checks applied to the document
        /// </summary>
        public QIFDocumentProductDataQuality ProductDataQuality
        {
            get
            {
                return this.productDataQualityField;
            }
            set
            {
                this.productDataQualityField = value;
            }
        }

        /// <summary>
        /// A list of external QIF documents referenced in the document, with a local id for each external document
        /// </summary>
        public QIFDocumentExternalQIFReferences ExternalQIFReferences
        {
            get
            {
                return this.externalQIFReferencesField;
            }
            set
            {
                this.externalQIFReferencesField = value;
            }
        }

        /// <summary>
        /// A list of standards referenced in the document.
        /// </summary>
        public QIFDocumentStandardsDefinitions StandardsDefinitions
        {
            get
            {
                return this.standardsDefinitionsField;
            }
            set
            {
                this.standardsDefinitionsField = value;
            }
        }

        /// <summary>
        /// A list of software systems referenced in the document.
        /// </summary>
        public QIFDocumentSoftwareDefinitions SoftwareDefinitions
        {
            get
            {
                return this.softwareDefinitionsField;
            }
            set
            {
                this.softwareDefinitionsField = value;
            }
        }

        /// <summary>
        /// A list of algorithm definitions referenced in the document.
        /// </summary>
        public QIFDocumentAlgorithmDefinitions AlgorithmDefinitions
        {
            get
            {
                return this.algorithmDefinitionsField;
            }
            set
            {
                this.algorithmDefinitionsField = value;
            }
        }

        /// <summary>
        /// Information about the provenance of the file before inspection has occurred.
        /// </summary>
        public QIFDocumentPreInspectionTraceability PreInspectionTraceability
        {
            get
            {
                return this.preInspectionTraceabilityField;
            }
            set
            {
                this.preInspectionTraceabilityField = value;
            }
        }

        /// <summary>
        /// Information about the units used in the file.
        /// </summary>
        public FileUnits.FileUnits FileUnits
        {
            get
            {
                return this.fileUnitsField;
            }
            set
            {
                this.fileUnitsField = value;
            }
        }

        /// <summary>
        /// A list of datum definitions
        /// </summary>
        public QIFDocumentDatumDefinitions DatumDefinitions
        {
            get
            {
                return this.datumDefinitionsField;
            }
            set
            {
                this.datumDefinitionsField = value;
            }
        }

        /// <summary>
        /// A list of datum targets.
        /// </summary>
        public QIFDocumentDatumTargetDefinitions DatumTargetDefinitions
        {
            get
            {
                return this.datumTargetDefinitionsField;
            }
            set
            {
                this.datumTargetDefinitionsField = value;
            }
        }

        /// <summary>
        /// A list of transforms
        /// </summary>
        public QIFDocumentTransforms Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <summary>
        /// A list of coordinate systems
        /// </summary>
        public QIFDocumentCoordinateSystems CoordinateSystems
        {
            get
            {
                return this.coordinateSystemsField;
            }
            set
            {
                this.coordinateSystemsField = value;
            }
        }

        /// <summary>
        /// A list of datum reference frames
        /// </summary>
        public QIFDocumentDatumReferenceFrames DatumReferenceFrames
        {
            get
            {
                return this.datumReferenceFramesField;
            }
            set
            {
                this.datumReferenceFramesField = value;
            }
        }

        /// <summary>
        /// Information about measurement resources
        /// </summary>
        public QIFDocumentMeasurementResources MeasurementResources
        {
            get
            {
                return this.measurementResourcesField;
            }
            set
            {
                this.measurementResourcesField = value;
            }
        }

        /// <summary>
        /// A list of thread specifications
        /// </summary>
        public QIFDocumentThreadSpecifications ThreadSpecifications
        {
            get
            {
                return this.threadSpecificationsField;
            }
            set
            {
                this.threadSpecificationsField = value;
            }
        }

        /// <summary>
        /// Information about parts and assemblies, both designs and physical instances of the designs.
        /// </summary>
        public QIFDocumentProduct Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <summary>
        /// Information about parts and assemblies, both designs and physical instances of the designs.
        /// </summary>
        public Features.Features Features
        {
            get => featuresField;
            set => this.featuresField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versionQIF
        {
            get
            {
                return this.versionQIFField;
            }
            set
            {
                this.versionQIFField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte idMax
        {
            get
            {
                return this.idMaxField;
            }
            set
            {
                this.idMaxField = value;
            }
        }
        #endregion
    }
}
