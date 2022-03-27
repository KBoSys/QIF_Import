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
    public partial class QIFDocumentDatumDefinitions
    {

        private QIFDocumentDatumDefinitionsDatumDefinition[] datumDefinitionField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DatumDefinition")]
        public QIFDocumentDatumDefinitionsDatumDefinition[] DatumDefinition
        {
            get
            {
                return this.datumDefinitionField;
            }
            set
            {
                this.datumDefinitionField = value;
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
    public partial class QIFDocumentDatumDefinitionsDatumDefinition
    {

        private string datumLabelField;

        private QIFDocumentDatumDefinitionsDatumDefinitionDatumTargetIds datumTargetIdsField;

        private QIFDocumentDatumDefinitionsDatumDefinitionFeatureNominalIds featureNominalIdsField;

        private uint idField;

        /// <remarks/>
        public string DatumLabel
        {
            get
            {
                return this.datumLabelField;
            }
            set
            {
                this.datumLabelField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumDefinitionsDatumDefinitionDatumTargetIds DatumTargetIds
        {
            get
            {
                return this.datumTargetIdsField;
            }
            set
            {
                this.datumTargetIdsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumDefinitionsDatumDefinitionFeatureNominalIds FeatureNominalIds
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
    public partial class QIFDocumentDatumDefinitionsDatumDefinitionDatumTargetIds
    {

        private QIFDocumentDatumDefinitionsDatumDefinitionDatumTargetIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentDatumDefinitionsDatumDefinitionDatumTargetIdsID[] Id
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
    public partial class QIFDocumentDatumDefinitionsDatumDefinitionDatumTargetIdsID
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
    public partial class QIFDocumentDatumDefinitionsDatumDefinitionFeatureNominalIds
    {

        private QIFDocumentDatumDefinitionsDatumDefinitionFeatureNominalIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentDatumDefinitionsDatumDefinitionFeatureNominalIdsID[] Id
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
    public partial class QIFDocumentDatumDefinitionsDatumDefinitionFeatureNominalIdsID
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
    public partial class QIFDocumentDatumTargetDefinitions
    {

        private QIFDocumentDatumTargetDefinitionsDatumTarget[] datumTargetField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DatumTarget")]
        public QIFDocumentDatumTargetDefinitionsDatumTarget[] DatumTarget
        {
            get
            {
                return this.datumTargetField;
            }
            set
            {
                this.datumTargetField = value;
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
    public partial class QIFDocumentDatumTargetDefinitionsDatumTarget
    {

        private string datumTargetLabelField;

        private QIFDocumentDatumTargetDefinitionsDatumTargetFeatureNominalId featureNominalIdField;

        private QIFDocumentDatumTargetDefinitionsDatumTargetTargetZoneId targetZoneIdField;

        private QIFDocumentDatumTargetDefinitionsDatumTargetMovableDatumTarget movableDatumTargetField;

        private uint idField;

        /// <remarks/>
        public string DatumTargetLabel
        {
            get
            {
                return this.datumTargetLabelField;
            }
            set
            {
                this.datumTargetLabelField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumTargetDefinitionsDatumTargetFeatureNominalId FeatureNominalId
        {
            get
            {
                return this.featureNominalIdField;
            }
            set
            {
                this.featureNominalIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumTargetDefinitionsDatumTargetTargetZoneId TargetZoneId
        {
            get
            {
                return this.targetZoneIdField;
            }
            set
            {
                this.targetZoneIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentDatumTargetDefinitionsDatumTargetMovableDatumTarget MovableDatumTarget
        {
            get
            {
                return this.movableDatumTargetField;
            }
            set
            {
                this.movableDatumTargetField = value;
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
    public partial class QIFDocumentDatumTargetDefinitionsDatumTargetFeatureNominalId
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
    public partial class QIFDocumentDatumTargetDefinitionsDatumTargetTargetZoneId
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
    public partial class QIFDocumentDatumTargetDefinitionsDatumTargetMovableDatumTarget
    {

        private QIFDocumentDatumTargetDefinitionsDatumTargetMovableDatumTargetDatumTargetTranslationDirection datumTargetTranslationDirectionField;

        /// <remarks/>
        public QIFDocumentDatumTargetDefinitionsDatumTargetMovableDatumTargetDatumTargetTranslationDirection DatumTargetTranslationDirection
        {
            get
            {
                return this.datumTargetTranslationDirectionField;
            }
            set
            {
                this.datumTargetTranslationDirectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentDatumTargetDefinitionsDatumTargetMovableDatumTargetDatumTargetTranslationDirection
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
}
