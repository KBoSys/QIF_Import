using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFDocument
{
    /// <summary>
    /// The size of each of about 50 lists of QIF elements. 
    /// This is provided so that an application can check the integrity of the document 
    /// by checking the counts against the actual numbers of elements in the lists. Each count is optional. 
    /// If a count is omitted for a list, it does not imply that there are zero elements in the list.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentValidationCounts
    {

        private byte externalQIFReferencesCountField;

        private byte datumDefinitionsCountField;

        private byte datumTargetDefinitionsCountField;

        private byte transformsCountField;

        private byte coordinateSystemsCountField;

        private byte datumReferenceFramesCountField;

        private byte measurementResourcesCountField;

        private byte threadSpecificationsCountField;

        private byte productGeometrySetCountField;

        private byte productTopologySetCountField;

        private byte productNoteSetCountField;

        private byte productNoteFlagSetCountField;

        private byte productPartNoteSetCountField;

        private byte productViewSetCountField;

        private byte productLayerSetCountField;

        private byte productCoordinateSystemSetCountField;

        private byte productVisualizationSetCountField;

        private byte productAuxiliarySetCountField;

        private byte productPartSetCountField;

        private byte productAssemblySetCountField;

        private byte productComponentSetCountField;

        private byte productAsmPathsCountField;

        private byte featureDefinitionsCountField;

        private byte featureNominalsCountField;

        private byte featureItemsCountField;

        private byte characteristicDefinitionsCountField;

        private byte defaultCharacteristicDefinitionsCountField;

        private byte defaultToleranceDefinitionsCountField;

        private byte characteristicNominalsCountField;

        private byte characteristicItemsCountField;

        private byte characteristicGroupsCountField;

        private byte weldSymbolSetCountField;

        private bool measurementsPlanPresentField;

        private byte measurementsResultsCountField;

        private byte statisticalStudyPlansCountField;

        private byte statisticalStudiesResultsCountField;

        private byte correctiveActionPlansCountField;

        private byte manufacturingProcessTraceabilitiesCountField;

        private byte featureRulesCountField;

        private byte dMESelectionRulesCountField;

        private bool signaturePresentField;

        /// <remarks/>
        public byte ExternalQIFReferencesCount
        {
            get
            {
                return this.externalQIFReferencesCountField;
            }
            set
            {
                this.externalQIFReferencesCountField = value;
            }
        }

        /// <remarks/>
        public byte DatumDefinitionsCount
        {
            get
            {
                return this.datumDefinitionsCountField;
            }
            set
            {
                this.datumDefinitionsCountField = value;
            }
        }

        /// <remarks/>
        public byte DatumTargetDefinitionsCount
        {
            get
            {
                return this.datumTargetDefinitionsCountField;
            }
            set
            {
                this.datumTargetDefinitionsCountField = value;
            }
        }

        /// <remarks/>
        public byte TransformsCount
        {
            get
            {
                return this.transformsCountField;
            }
            set
            {
                this.transformsCountField = value;
            }
        }

        /// <remarks/>
        public byte CoordinateSystemsCount
        {
            get
            {
                return this.coordinateSystemsCountField;
            }
            set
            {
                this.coordinateSystemsCountField = value;
            }
        }

        /// <remarks/>
        public byte DatumReferenceFramesCount
        {
            get
            {
                return this.datumReferenceFramesCountField;
            }
            set
            {
                this.datumReferenceFramesCountField = value;
            }
        }

        /// <remarks/>
        public byte MeasurementResourcesCount
        {
            get
            {
                return this.measurementResourcesCountField;
            }
            set
            {
                this.measurementResourcesCountField = value;
            }
        }

        /// <remarks/>
        public byte ThreadSpecificationsCount
        {
            get
            {
                return this.threadSpecificationsCountField;
            }
            set
            {
                this.threadSpecificationsCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductGeometrySetCount
        {
            get
            {
                return this.productGeometrySetCountField;
            }
            set
            {
                this.productGeometrySetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductTopologySetCount
        {
            get
            {
                return this.productTopologySetCountField;
            }
            set
            {
                this.productTopologySetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductNoteSetCount
        {
            get
            {
                return this.productNoteSetCountField;
            }
            set
            {
                this.productNoteSetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductNoteFlagSetCount
        {
            get
            {
                return this.productNoteFlagSetCountField;
            }
            set
            {
                this.productNoteFlagSetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductPartNoteSetCount
        {
            get
            {
                return this.productPartNoteSetCountField;
            }
            set
            {
                this.productPartNoteSetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductViewSetCount
        {
            get
            {
                return this.productViewSetCountField;
            }
            set
            {
                this.productViewSetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductLayerSetCount
        {
            get
            {
                return this.productLayerSetCountField;
            }
            set
            {
                this.productLayerSetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductCoordinateSystemSetCount
        {
            get
            {
                return this.productCoordinateSystemSetCountField;
            }
            set
            {
                this.productCoordinateSystemSetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductVisualizationSetCount
        {
            get
            {
                return this.productVisualizationSetCountField;
            }
            set
            {
                this.productVisualizationSetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductAuxiliarySetCount
        {
            get
            {
                return this.productAuxiliarySetCountField;
            }
            set
            {
                this.productAuxiliarySetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductPartSetCount
        {
            get
            {
                return this.productPartSetCountField;
            }
            set
            {
                this.productPartSetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductAssemblySetCount
        {
            get
            {
                return this.productAssemblySetCountField;
            }
            set
            {
                this.productAssemblySetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductComponentSetCount
        {
            get
            {
                return this.productComponentSetCountField;
            }
            set
            {
                this.productComponentSetCountField = value;
            }
        }

        /// <remarks/>
        public byte ProductAsmPathsCount
        {
            get
            {
                return this.productAsmPathsCountField;
            }
            set
            {
                this.productAsmPathsCountField = value;
            }
        }

        /// <remarks/>
        public byte FeatureDefinitionsCount
        {
            get
            {
                return this.featureDefinitionsCountField;
            }
            set
            {
                this.featureDefinitionsCountField = value;
            }
        }

        /// <remarks/>
        public byte FeatureNominalsCount
        {
            get
            {
                return this.featureNominalsCountField;
            }
            set
            {
                this.featureNominalsCountField = value;
            }
        }

        /// <remarks/>
        public byte FeatureItemsCount
        {
            get
            {
                return this.featureItemsCountField;
            }
            set
            {
                this.featureItemsCountField = value;
            }
        }

        /// <remarks/>
        public byte CharacteristicDefinitionsCount
        {
            get
            {
                return this.characteristicDefinitionsCountField;
            }
            set
            {
                this.characteristicDefinitionsCountField = value;
            }
        }

        /// <remarks/>
        public byte DefaultCharacteristicDefinitionsCount
        {
            get
            {
                return this.defaultCharacteristicDefinitionsCountField;
            }
            set
            {
                this.defaultCharacteristicDefinitionsCountField = value;
            }
        }

        /// <remarks/>
        public byte DefaultToleranceDefinitionsCount
        {
            get
            {
                return this.defaultToleranceDefinitionsCountField;
            }
            set
            {
                this.defaultToleranceDefinitionsCountField = value;
            }
        }

        /// <remarks/>
        public byte CharacteristicNominalsCount
        {
            get
            {
                return this.characteristicNominalsCountField;
            }
            set
            {
                this.characteristicNominalsCountField = value;
            }
        }

        /// <remarks/>
        public byte CharacteristicItemsCount
        {
            get
            {
                return this.characteristicItemsCountField;
            }
            set
            {
                this.characteristicItemsCountField = value;
            }
        }

        /// <remarks/>
        public byte CharacteristicGroupsCount
        {
            get
            {
                return this.characteristicGroupsCountField;
            }
            set
            {
                this.characteristicGroupsCountField = value;
            }
        }

        /// <remarks/>
        public byte WeldSymbolSetCount
        {
            get
            {
                return this.weldSymbolSetCountField;
            }
            set
            {
                this.weldSymbolSetCountField = value;
            }
        }

        /// <remarks/>
        public bool MeasurementsPlanPresent
        {
            get
            {
                return this.measurementsPlanPresentField;
            }
            set
            {
                this.measurementsPlanPresentField = value;
            }
        }

        /// <remarks/>
        public byte MeasurementsResultsCount
        {
            get
            {
                return this.measurementsResultsCountField;
            }
            set
            {
                this.measurementsResultsCountField = value;
            }
        }

        /// <remarks/>
        public byte StatisticalStudyPlansCount
        {
            get
            {
                return this.statisticalStudyPlansCountField;
            }
            set
            {
                this.statisticalStudyPlansCountField = value;
            }
        }

        /// <remarks/>
        public byte StatisticalStudiesResultsCount
        {
            get
            {
                return this.statisticalStudiesResultsCountField;
            }
            set
            {
                this.statisticalStudiesResultsCountField = value;
            }
        }

        /// <remarks/>
        public byte CorrectiveActionPlansCount
        {
            get
            {
                return this.correctiveActionPlansCountField;
            }
            set
            {
                this.correctiveActionPlansCountField = value;
            }
        }

        /// <remarks/>
        public byte ManufacturingProcessTraceabilitiesCount
        {
            get
            {
                return this.manufacturingProcessTraceabilitiesCountField;
            }
            set
            {
                this.manufacturingProcessTraceabilitiesCountField = value;
            }
        }

        /// <remarks/>
        public byte FeatureRulesCount
        {
            get
            {
                return this.featureRulesCountField;
            }
            set
            {
                this.featureRulesCountField = value;
            }
        }

        /// <remarks/>
        public byte DMESelectionRulesCount
        {
            get
            {
                return this.dMESelectionRulesCountField;
            }
            set
            {
                this.dMESelectionRulesCountField = value;
            }
        }

        /// <remarks/>
        public bool SignaturePresent
        {
            get
            {
                return this.signaturePresentField;
            }
            set
            {
                this.signaturePresentField = value;
            }
        }
    }
}
