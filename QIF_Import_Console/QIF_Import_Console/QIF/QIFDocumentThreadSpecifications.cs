using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Import_Console.QIF
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentThreadSpecifications
    {

        private QIFDocumentThreadSpecificationsThreadSpecification[] threadSpecificationField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ThreadSpecification")]
        public QIFDocumentThreadSpecificationsThreadSpecification[] ThreadSpecification
        {
            get
            {
                return this.threadSpecificationField;
            }
            set
            {
                this.threadSpecificationField = value;
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
    public partial class QIFDocumentThreadSpecificationsThreadSpecification
    {

        private QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecification singleLeadSpecificationField;

        /// <remarks/>
        public QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecification SingleLeadSpecification
        {
            get
            {
                return this.singleLeadSpecificationField;
            }
            set
            {
                this.singleLeadSpecificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecification
    {

        private QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationDiameter diameterField;

        private QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadSeries threadSeriesField;

        private QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadToleranceClass threadToleranceClassField;

        private QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationCrestDiameterToleranceClass crestDiameterToleranceClassField;

        private bool leftHandedField;

        private bool modifiedThreadField;

        private QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadLengthEngagement threadLengthEngagementField;

        private QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadDensity threadDensityField;

        private uint idField;

        /// <remarks/>
        public QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationDiameter Diameter
        {
            get
            {
                return this.diameterField;
            }
            set
            {
                this.diameterField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadSeries ThreadSeries
        {
            get
            {
                return this.threadSeriesField;
            }
            set
            {
                this.threadSeriesField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadToleranceClass ThreadToleranceClass
        {
            get
            {
                return this.threadToleranceClassField;
            }
            set
            {
                this.threadToleranceClassField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationCrestDiameterToleranceClass CrestDiameterToleranceClass
        {
            get
            {
                return this.crestDiameterToleranceClassField;
            }
            set
            {
                this.crestDiameterToleranceClassField = value;
            }
        }

        /// <remarks/>
        public bool LeftHanded
        {
            get
            {
                return this.leftHandedField;
            }
            set
            {
                this.leftHandedField = value;
            }
        }

        /// <remarks/>
        public bool ModifiedThread
        {
            get
            {
                return this.modifiedThreadField;
            }
            set
            {
                this.modifiedThreadField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadLengthEngagement ThreadLengthEngagement
        {
            get
            {
                return this.threadLengthEngagementField;
            }
            set
            {
                this.threadLengthEngagementField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadDensity ThreadDensity
        {
            get
            {
                return this.threadDensityField;
            }
            set
            {
                this.threadDensityField = value;
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
    public partial class QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationDiameter
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

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
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
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
    public partial class QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadSeries
    {

        private string threadSeriesEnumField;

        /// <remarks/>
        public string ThreadSeriesEnum
        {
            get
            {
                return this.threadSeriesEnumField;
            }
            set
            {
                this.threadSeriesEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadToleranceClass
    {

        private string threadClassEnumField;

        /// <remarks/>
        public string ThreadClassEnum
        {
            get
            {
                return this.threadClassEnumField;
            }
            set
            {
                this.threadClassEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationCrestDiameterToleranceClass
    {

        private string threadClassEnumField;

        /// <remarks/>
        public string ThreadClassEnum
        {
            get
            {
                return this.threadClassEnumField;
            }
            set
            {
                this.threadClassEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadLengthEngagement
    {

        private string linearUnitField;

        private string decimalPlacesField;

        private string significantFiguresField;

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
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
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
    public partial class QIFDocumentThreadSpecificationsThreadSpecificationSingleLeadSpecificationThreadDensity
    {

        private string decimalPlacesField;

        private string significantFiguresField;

        private string valueField;

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
        [System.Xml.Serialization.XmlTextAttribute(DataType = "integer")]
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
