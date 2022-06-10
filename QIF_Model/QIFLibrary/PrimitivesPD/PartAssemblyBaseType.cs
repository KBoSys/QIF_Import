using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AssemblyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PartType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PartAssemblyBaseType : DrawableBaseType
    {

        private ValidationPartAssemblyType validationField;

        private PartAssemblyHeaderType headerField;

        private string uUIDField;

        private string modelNumberField;

        private string versionField;

        private SecurityClassificationType securityClassificationField;

        private string exportControlClassificationField;

        private ArrayReferenceFullType featureNominalIdsField;

        private ArrayReferenceFullType featureZoneIdsField;

        private ArrayReferenceFullType characteristicNominalIdsField;

        private ArrayReferenceFullType noteIdsField;

        private ArrayReferenceFullType partNoteIdsField;

        private ArrayReferenceFullType datumDefinitionIdsField;

        private ArrayReferenceFullType datumTargetDefinitionIdsField;

        private ArrayReferenceFullType datumReferenceFrameIdsField;

        private ArrayReferenceType bodyIdsField;

        private ArrayReferenceType coordinateSystemIdsField;

        private ArrayReferenceType auxiliaryIdsField;

        private ArrayReferenceType viewIdsField;

        private ArrayReferenceType pointCloudIdsField;

        private double[] originMassPropertyField;

        private uint materialIndexField;

        private bool materialIndexFieldSpecified;

        /// <remarks/>
        public ValidationPartAssemblyType Validation
        {
            get
            {
                return this.validationField;
            }
            set
            {
                this.validationField = value;
            }
        }

        /// <remarks/>
        public PartAssemblyHeaderType Header
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }

        /// <remarks/>
        public string ModelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        /// <remarks/>
        public string Version
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
        public SecurityClassificationType SecurityClassification
        {
            get
            {
                return this.securityClassificationField;
            }
            set
            {
                this.securityClassificationField = value;
            }
        }

        /// <remarks/>
        public string ExportControlClassification
        {
            get
            {
                return this.exportControlClassificationField;
            }
            set
            {
                this.exportControlClassificationField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceFullType FeatureNominalIds
        {
            get
            {
                return this.featureNominalIdsField;
            }
            set
            {
                this.featureNominalIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceFullType FeatureZoneIds
        {
            get
            {
                return this.featureZoneIdsField;
            }
            set
            {
                this.featureZoneIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceFullType CharacteristicNominalIds
        {
            get
            {
                return this.characteristicNominalIdsField;
            }
            set
            {
                this.characteristicNominalIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceFullType NoteIds
        {
            get
            {
                return this.noteIdsField;
            }
            set
            {
                this.noteIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceFullType PartNoteIds
        {
            get
            {
                return this.partNoteIdsField;
            }
            set
            {
                this.partNoteIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceFullType DatumDefinitionIds
        {
            get
            {
                return this.datumDefinitionIdsField;
            }
            set
            {
                this.datumDefinitionIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceFullType DatumTargetDefinitionIds
        {
            get
            {
                return this.datumTargetDefinitionIdsField;
            }
            set
            {
                this.datumTargetDefinitionIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceFullType DatumReferenceFrameIds
        {
            get
            {
                return this.datumReferenceFrameIdsField;
            }
            set
            {
                this.datumReferenceFrameIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceType BodyIds
        {
            get
            {
                return this.bodyIdsField;
            }
            set
            {
                this.bodyIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceType CoordinateSystemIds
        {
            get
            {
                return this.coordinateSystemIdsField;
            }
            set
            {
                this.coordinateSystemIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceType AuxiliaryIds
        {
            get
            {
                return this.auxiliaryIdsField;
            }
            set
            {
                this.auxiliaryIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceType ViewIds
        {
            get
            {
                return this.viewIdsField;
            }
            set
            {
                this.viewIdsField = value;
            }
        }

        /// <remarks/>
        public ArrayReferenceType PointCloudIds
        {
            get
            {
                return this.pointCloudIdsField;
            }
            set
            {
                this.pointCloudIdsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double[] originMassProperty
        {
            get
            {
                return this.originMassPropertyField;
            }
            set
            {
                this.originMassPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint materialIndex
        {
            get
            {
                return this.materialIndexField;
            }
            set
            {
                this.materialIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool materialIndexSpecified
        {
            get
            {
                return this.materialIndexFieldSpecified;
            }
            set
            {
                this.materialIndexFieldSpecified = value;
            }
        }
    }
}
