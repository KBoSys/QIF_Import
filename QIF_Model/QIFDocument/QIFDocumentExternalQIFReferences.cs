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
    public partial class QIFDocumentExternalQIFReferences
    {

        private QIFDocumentExternalQIFReferencesExternalQIFDocument[] externalQIFDocumentField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExternalQIFDocument")]
        public QIFDocumentExternalQIFReferencesExternalQIFDocument[] ExternalQIFDocument
        {
            get
            {
                return this.externalQIFDocumentField;
            }
            set
            {
                this.externalQIFDocumentField = value;
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
    public partial class QIFDocumentExternalQIFReferencesExternalQIFDocument
    {

        private string qPIdField;

        private string uRIField;

        private string descriptionField;

        private uint idField;

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
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
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
}
