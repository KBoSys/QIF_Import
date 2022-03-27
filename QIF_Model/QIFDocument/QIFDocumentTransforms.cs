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
    public partial class QIFDocumentTransforms
    {

        private QIFDocumentTransformsTransform[] transformField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transform")]
        public QIFDocumentTransformsTransform[] Transform
        {
            get
            {
                return this.transformField;
            }
            set
            {
                this.transformField = value;
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
    public partial class QIFDocumentTransformsTransform
    {

        private QIFDocumentTransformsTransformRotation rotationField;

        private string originField;

        private string nameField;

        private uint idField;

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
        public QIFDocumentTransformsTransformRotation Rotation
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
    public partial class QIFDocumentTransformsTransformRotation
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
}
