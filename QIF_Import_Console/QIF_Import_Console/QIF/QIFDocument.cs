using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Import_Console.QIF
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IsNullable = false)]
    public partial class QIFDocument
    {

        private string qPIdField;

        private QIFDocumentAttributes attributesField;

        private QIFDocumentVersionHistory versionHistoryField;

        private QIFDocumentVersion versionField;

        private QIFDocumentHeader headerField;

        private QIFDocumentValidationCounts validationCountsField;

        private QIFDocumentProductDataQuality productDataQualityField;

        private QIFDocumentExternalQIFReferences externalQIFReferencesField;

        private QIFDocumentStandardsDefinitions standardsDefinitionsField;

        private QIFDocumentSoftwareDefinitions softwareDefinitionsField;

        private QIFDocumentAlgorithmDefinitions algorithmDefinitionsField;

        private QIFDocumentPreInspectionTraceability preInspectionTraceabilityField;

        private QIFDocumentFileUnits fileUnitsField;

        private QIFDocumentDatumDefinitions datumDefinitionsField;

        private QIFDocumentDatumTargetDefinitions datumTargetDefinitionsField;

        private QIFDocumentTransforms transformsField;

        private QIFDocumentCoordinateSystems coordinateSystemsField;

        private QIFDocumentDatumReferenceFrames datumReferenceFramesField;

        private QIFDocumentMeasurementResources measurementResourcesField;

        private QIFDocumentThreadSpecifications threadSpecificationsField;

        private QIFDocumentProduct productField;

        private string versionQIFField;

        private byte idMaxField;

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
        public QIFDocumentFileUnits FileUnits
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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
    }
}
