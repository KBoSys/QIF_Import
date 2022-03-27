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
    public partial class QIFDocumentCoordinateSystems
    {

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitions coordinateSystemDefinitionsField;

        private QIFDocumentCoordinateSystemsCommonCoordinateSystemId commonCoordinateSystemIdField;

        private QIFDocumentCoordinateSystemsMachineCoordinateSystem[] machineCoordinateSystemField;

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitions CoordinateSystemDefinitions
        {
            get
            {
                return this.coordinateSystemDefinitionsField;
            }
            set
            {
                this.coordinateSystemDefinitionsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCommonCoordinateSystemId CommonCoordinateSystemId
        {
            get
            {
                return this.commonCoordinateSystemIdField;
            }
            set
            {
                this.commonCoordinateSystemIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MachineCoordinateSystem")]
        public QIFDocumentCoordinateSystemsMachineCoordinateSystem[] MachineCoordinateSystem
        {
            get
            {
                return this.machineCoordinateSystemField;
            }
            set
            {
                this.machineCoordinateSystemField = value;
            }
        }
    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitions
    {

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystem[] coordinateSystemField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoordinateSystem")]
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystem[] CoordinateSystem
        {
            get
            {
                return this.coordinateSystemField;
            }
            set
            {
                this.coordinateSystemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystem
    {

        private string nameField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemNominalTransform nominalTransformField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemInternalCADCoordinateSystemId internalCADCoordinateSystemIdField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemExternalCADCoordinateSystemId externalCADCoordinateSystemIdField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperations alignmentOperationsField;

        private uint sequenceNumberField;

        private uint idField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemNominalTransform NominalTransform
        {
            get
            {
                return this.nominalTransformField;
            }
            set
            {
                this.nominalTransformField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemInternalCADCoordinateSystemId InternalCADCoordinateSystemId
        {
            get
            {
                return this.internalCADCoordinateSystemIdField;
            }
            set
            {
                this.internalCADCoordinateSystemIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemExternalCADCoordinateSystemId ExternalCADCoordinateSystemId
        {
            get
            {
                return this.externalCADCoordinateSystemIdField;
            }
            set
            {
                this.externalCADCoordinateSystemIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperations AlignmentOperations
        {
            get
            {
                return this.alignmentOperationsField;
            }
            set
            {
                this.alignmentOperationsField = value;
            }
        }

        /// <remarks/>
        public uint SequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemNominalTransform
    {

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemNominalTransformRotation rotationField;

        private string originField;

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemNominalTransformRotation Rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }

        /// <remarks/>
        public string Origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemNominalTransformRotation
    {

        private string xDirectionField;

        private string yDirectionField;

        private string zDirectionField;

        /// <remarks/>
        public string XDirection
        {
            get
            {
                return this.xDirectionField;
            }
            set
            {
                this.xDirectionField = value;
            }
        }

        /// <remarks/>
        public string YDirection
        {
            get
            {
                return this.yDirectionField;
            }
            set
            {
                this.yDirectionField = value;
            }
        }

        /// <remarks/>
        public string ZDirection
        {
            get
            {
                return this.zDirectionField;
            }
            set
            {
                this.zDirectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemInternalCADCoordinateSystemId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemExternalCADCoordinateSystemId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperations
    {

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignment primaryAlignmentField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignment secondaryAlignmentField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffset measurementOffsetField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsBaseCoordinateSystemId baseCoordinateSystemIdField;

        private uint nField;

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignment PrimaryAlignment
        {
            get
            {
                return this.primaryAlignmentField;
            }
            set
            {
                this.primaryAlignmentField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignment SecondaryAlignment
        {
            get
            {
                return this.secondaryAlignmentField;
            }
            set
            {
                this.secondaryAlignmentField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffset MeasurementOffset
        {
            get
            {
                return this.measurementOffsetField;
            }
            set
            {
                this.measurementOffsetField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsBaseCoordinateSystemId BaseCoordinateSystemId
        {
            get
            {
                return this.baseCoordinateSystemIdField;
            }
            set
            {
                this.baseCoordinateSystemIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignment
    {

        private uint sequenceNumberField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignmentPrimaryEntity primaryEntityField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignmentPrimaryAxis primaryAxisField;

        /// <remarks/>
        public uint SequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignmentPrimaryEntity PrimaryEntity
        {
            get
            {
                return this.primaryEntityField;
            }
            set
            {
                this.primaryEntityField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignmentPrimaryAxis PrimaryAxis
        {
            get
            {
                return this.primaryAxisField;
            }
            set
            {
                this.primaryAxisField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignmentPrimaryEntity
    {

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignmentPrimaryEntityDatumDefinitionId datumDefinitionIdField;

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignmentPrimaryEntityDatumDefinitionId DatumDefinitionId
        {
            get
            {
                return this.datumDefinitionIdField;
            }
            set
            {
                this.datumDefinitionIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignmentPrimaryEntityDatumDefinitionId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsPrimaryAlignmentPrimaryAxis
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignment
    {

        private uint sequenceNumberField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentSecondaryEntity secondaryEntityField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentSecondaryAxis secondaryAxisField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentRotationAxis rotationAxisField;

        /// <remarks/>
        public uint SequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentSecondaryEntity SecondaryEntity
        {
            get
            {
                return this.secondaryEntityField;
            }
            set
            {
                this.secondaryEntityField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentSecondaryAxis SecondaryAxis
        {
            get
            {
                return this.secondaryAxisField;
            }
            set
            {
                this.secondaryAxisField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentRotationAxis RotationAxis
        {
            get
            {
                return this.rotationAxisField;
            }
            set
            {
                this.rotationAxisField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentSecondaryEntity
    {

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentSecondaryEntityDatumDefinitionId datumDefinitionIdField;

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentSecondaryEntityDatumDefinitionId DatumDefinitionId
        {
            get
            {
                return this.datumDefinitionIdField;
            }
            set
            {
                this.datumDefinitionIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentSecondaryEntityDatumDefinitionId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentSecondaryAxis
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsSecondaryAlignmentRotationAxis
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffset
    {

        private uint sequenceNumberField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOrigin[] originField;

        private uint nField;

        /// <remarks/>
        public uint SequenceNumber
        {
            get
            {
                return this.sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Origin")]
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOrigin[] Origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOrigin
    {

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOriginOriginEntity originEntityField;

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOriginOriginDirection originDirectionField;

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOriginOriginEntity OriginEntity
        {
            get
            {
                return this.originEntityField;
            }
            set
            {
                this.originEntityField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOriginOriginDirection OriginDirection
        {
            get
            {
                return this.originDirectionField;
            }
            set
            {
                this.originDirectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOriginOriginEntity
    {

        private QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOriginOriginEntityDatumDefinitionId datumDefinitionIdField;

        /// <remarks/>
        public QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOriginOriginEntityDatumDefinitionId DatumDefinitionId
        {
            get
            {
                return this.datumDefinitionIdField;
            }
            set
            {
                this.datumDefinitionIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOriginOriginEntityDatumDefinitionId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsMeasurementOffsetOriginOriginDirection
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

        private string validityField;

        private string xDecimalPlacesField;

        private string xSignificantFiguresField;

        private string xValidityField;

        private string yDecimalPlacesField;

        private string ySignificantFiguresField;

        private string yValidityField;

        private string zDecimalPlacesField;

        private string zSignificantFiguresField;

        private string zValidityField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string linearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string decimalPlaces
        {
            get
            {
                return this.decimalPlacesField;
            }
            set
            {
                this.decimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string significantFigures
        {
            get
            {
                return this.significantFiguresField;
            }
            set
            {
                this.significantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string validity
        {
            get
            {
                return this.validityField;
            }
            set
            {
                this.validityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xDecimalPlaces
        {
            get
            {
                return this.xDecimalPlacesField;
            }
            set
            {
                this.xDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string xSignificantFigures
        {
            get
            {
                return this.xSignificantFiguresField;
            }
            set
            {
                this.xSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xValidity
        {
            get
            {
                return this.xValidityField;
            }
            set
            {
                this.xValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string yDecimalPlaces
        {
            get
            {
                return this.yDecimalPlacesField;
            }
            set
            {
                this.yDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ySignificantFigures
        {
            get
            {
                return this.ySignificantFiguresField;
            }
            set
            {
                this.ySignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string yValidity
        {
            get
            {
                return this.yValidityField;
            }
            set
            {
                this.yValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zDecimalPlaces
        {
            get
            {
                return this.zDecimalPlacesField;
            }
            set
            {
                this.zDecimalPlacesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string zSignificantFigures
        {
            get
            {
                return this.zSignificantFiguresField;
            }
            set
            {
                this.zSignificantFiguresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string zValidity
        {
            get
            {
                return this.zValidityField;
            }
            set
            {
                this.zValidityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCoordinateSystemDefinitionsCoordinateSystemAlignmentOperationsBaseCoordinateSystemId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsCommonCoordinateSystemId
    {

        private byte asmPathIdField;

        private byte asmPathXIdField;

        private byte xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsMachineCoordinateSystem
    {

        private QIFDocumentCoordinateSystemsMachineCoordinateSystemCoordinateSystemId coordinateSystemIdField;

        private QIFDocumentCoordinateSystemsMachineCoordinateSystemMeasurementDeviceId measurementDeviceIdField;

        /// <remarks/>
        public QIFDocumentCoordinateSystemsMachineCoordinateSystemCoordinateSystemId CoordinateSystemId
        {
            get
            {
                return this.coordinateSystemIdField;
            }
            set
            {
                this.coordinateSystemIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentCoordinateSystemsMachineCoordinateSystemMeasurementDeviceId MeasurementDeviceId
        {
            get
            {
                return this.measurementDeviceIdField;
            }
            set
            {
                this.measurementDeviceIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsMachineCoordinateSystemCoordinateSystemId
    {

        private uint asmPathIdField;

        private uint asmPathXIdField;

        private uint xIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathId
        {
            get
            {
                return this.asmPathIdField;
            }
            set
            {
                this.asmPathIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint asmPathXId
        {
            get
            {
                return this.asmPathXIdField;
            }
            set
            {
                this.asmPathXIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentCoordinateSystemsMachineCoordinateSystemMeasurementDeviceId
    {

        private uint xIdField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint xId
        {
            get
            {
                return this.xIdField;
            }
            set
            {
                this.xIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

}
