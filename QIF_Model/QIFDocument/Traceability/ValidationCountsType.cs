/*! \file ValidationCountsType.cs

        The ValidationCountsType contains redundancy checks in the form of
        counts of items in the significant lists contained within a QIF
        document.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Traceability
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
    public class ValidationCountsType
    {
        public ValidationCountsType() { }

        /// <remarks The optional ExternalQIFReferencesCount element is the number of external QIF references in the QIF document./>
        [XmlElement]
        public uint ExternalQIFReferencesCount { get; set; }

        /// <remarks The optional DatumDefinitionsCount element is the number of datum definitions in the QIF document./>
        [XmlElement]
        public uint DatumDefinitionsCount { get; set; }

        /// <remarks The optional DatumTargetDefinitionsCount element is the number of datum target definitions in the QIF document./>
        [XmlElement]
        public uint DatumTargetDefinitionsCount { get; set; }

        /// <remarks The optional TransformsCount element is the number of transforms in the QIF document./>
        [XmlElement]
        public uint TransformsCount { get; set; }

        /// <remarks The optional CoordinateSystemsCount element is the number of coordinate systems in the QIF document./>
        [XmlElement]
        public uint CoordinateSystemsCount { get; set; }

        /// <remarks The optional DatumReferenceFramesCount element is the number of datum reference frames in the QIF document./>
        [XmlElement]
        public uint DatumReferenceFramesCount { get; set; }

        /// <remarks The optional MeasurementResourcesCount element is the number of measurement resources in the QIF document./>
        [XmlElement]
        public uint MeasurementResourcesCount { get; set; }

        /// <remarks The optional ThreadSpecificationsCount element is the number of thread specifications in the QIF document./>
        [XmlElement]
        public uint ThreadSpecificationsCount { get; set; }

        /// <remarks The optional ProductGeometrySetCount element is the number of geometric entities present in the CAD scene./>
        [XmlElement]
        public uint ProductGeometrySetCount { get; set; }

        /// <remarks The optional ProductTopologySetCount element is the number of topological entities in the QIF document./>
        [XmlElement]
        public uint ProductTopologySetCount { get; set; }

        /// <remarks The optional ProductNoteSetCount element is the number of notes in the QIF document./>
        [XmlElement]
        public uint ProductNoteSetCount { get; set; }

        /// <remarks The optional ProductNoteFlagSetCount element is the number of flag notes present in the QIF document./>
        [XmlElement]
        public uint ProductNoteFlagSetCount { get; set; }

        /// <remarks The optional ProductPartNoteSetCount element is the number of part notes and standard notes in the QIF document./>
        [XmlElement]
        public uint ProductPartNoteSetCount { get; set; }

        /// <remarks The optional ProductViewSetCount element is the number of views in the QIF document./>
        [XmlElement]
        public uint ProductViewSetCount { get; set; }

        /// <remarks The optional ProductLayerSetCount element is the number of model layers./>
        [XmlElement]
        public uint ProductLayerSetCount { get; set; }

        /// <remarks The optional ProductCoordinateSystemSetCount element is the number of coordinate systems in the QIF document./>
        [XmlElement]
        public uint ProductCoordinateSystemSetCount { get; set; }

        /// <remarks
        /// The optional ProductVisualizationSetCount element is the number
        /// of display information objects associated with PMI entities in
        /// the QIF document.
        /// />
        [XmlElement]
        public uint ProductVisualizationSetCount { get; set; }

        /// <remarks The optional ProductAuxiliarySetCount element is the number of auxiliary objects present in the CAD scene./>
        [XmlElement]
        public uint ProductAuxiliarySetCount { get; set; }

        /// <remarks The optional ProductPartSetCount element is the number of parts in the QIF document./>
        [XmlElement]
        public uint ProductPartSetCount { get; set; }

        /// <remarks The optional ProductAssemblySetCount element is the number of assemblies in the QIF document./>
        [XmlElement]
        public uint ProductAssemblySetCount { get; set; }

        /// <remarks The optional ProductComponentSetCount element is the number of components in the QIF document./>
        [XmlElement]
        public uint ProductComponentSetCount { get; set; }

        /// <remarks The optional ProductAsmPathsCount element is the number of asm paths present in the CAD scene./>
        [XmlElement]
        public uint ProductAsmPathsCount { get; set; }

        /// <remarks The optional FeatureDefinitionsCount element is the number of inspection feature definitions in the QIF document./>
        [XmlElement]
        public uint FeatureDefinitionsCount { get; set; }

        /// <remarks The optional FeatureNominalsCount element is the number of nominal inspection features./>
        [XmlElement]
        public uint FeatureNominalsCount { get; set; }

        /// <remarks The optional FeatureItemsCount element is the number of inspection features items in the QIF document./>
        [XmlElement]
        public uint FeatureItemsCount { get; set; }

        /// <remarks The optional CharacteristicDefinitionsCount element is the number of characteristic definitions in the QIF document./>
        [XmlElement]
        public uint CharacteristicDefinitionsCount { get; set; }

        /// <remarks
        /// The optional DefaultCharacteristicDefinitionsCount element is
        /// the number of default or "unless otherwise specified"
        /// characteristic definitions in the QIF document.        
        /// />
        [XmlElement]
        public uint DefaultCharacteristicDefinitionsCount { get; set; }

        /// <remarks
        /// The optional DefaultToleranceDefinitionsCount element is the
        /// number of default or "unless otherwise specified" tolerance
        /// definitions which allow a tolerance definition to be shared
        /// among characteristic definitions of different types.        
        /// />
        [XmlElement]
        public uint DefaultToleranceDefinitionsCount { get; set; }

        /// <remarks The optional CharacteristicNominalsCount element is the number of characteristic nominals in the QIF document./>
        [XmlElement]
        public uint CharacteristicNominalsCount { get; set; }

        /// <remarks The optional CharacteristicItemsCount element is the number of characteristic items in the QIF document./>
        [XmlElement]
        public uint CharacteristicItemsCount { get; set; }

        /// <remarks The optional CharacteristicGroupsCount element is the number of characteristic groups in the QIF document./>
        [XmlElement]
        public uint CharacteristicGroupsCount { get; set; }

        /// <remarks The optional WeldSymbolSetCount element is the number of Weld Symbols in the QIF document./>
        [XmlElement]
        public uint WeldSymbolSetCount { get; set; }

        /// <remarks
        /// The optional MeasurementsPlanPresent element is a boolean
        /// indicating whether a measurement plan is present in the QIF document.
        /// />
        [XmlElement]
        public bool MeasurementsPlanPresent { get; set; }

        /// <remarks The optional MeasurementsResultsCount element is the number of measurement results in the QIF document./>
        [XmlElement]
        public uint MeasurementsResultsCount { get; set; }

        /// <remarks The optional StatisticalStudyPlansCount element is the number of statistical study plans in the QIF document./>
        [XmlElement]
        public uint StatisticalStudyPlansCount { get; set; }

        /// <remarks The optional StatisticalStudiesResultsCount element is the number of statistical studies results in the QIF document./>
        [XmlElement]
        public uint StatisticalStudiesResultsCount { get; set; }

        /// <remarks The optional CorrectiveActionPlansCount element is the number of corrective action plans in the QIF document./>
        [XmlElement]
        public uint CorrectiveActionPlansCount { get; set; }

        /// <remarks
        /// The optional ManufacturingProcessTraceabilitiesCount element is
        /// the number of manufacturing process traceabilities in the QIF document.
        /// />
        [XmlElement]
        public uint ManufacturingProcessTraceabilitiesCount { get; set; }

        /// <remarks The optional FeatureRulesCount element is the number of feature rules in the QIF document./>
        [XmlElement]
        public uint FeatureRulesCount { get; set; }

        /// <remarks The optional DMESelectionRulesCount element is the number of DME selection rules in the QIF document./>
        [XmlElement]
        public uint DMESelectionRulesCount { get; set; }

        /// <remarks
        /// The optional SignaturePresent element is a boolean
        /// indicating whether a digital signature is present in the QIF document.
        /// />
        [XmlElement]
        public bool SignaturePresent { get; set; }
    }
}
