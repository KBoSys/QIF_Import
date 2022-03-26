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
    public partial class QIFDocumentSoftwareDefinitions
    {

        private QIFDocumentSoftwareDefinitionsSoftware[] softwareField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Software")]
        public QIFDocumentSoftwareDefinitionsSoftware[] Software
        {
            get
            {
                return this.softwareField;
            }
            set
            {
                this.softwareField = value;
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
    public partial class QIFDocumentSoftwareDefinitionsSoftware
    {

        private string vendorNameField;

        private string applicationNameField;

        private string versionField;

        private string descriptionField;

        private string uRIField;

        private QIFDocumentSoftwareDefinitionsSoftwareReferencedStandardIds referencedStandardIdsField;

        private uint idField;

        /// <remarks/>
        public string VendorName
        {
            get
            {
                return this.vendorNameField;
            }
            set
            {
                this.vendorNameField = value;
            }
        }

        /// <remarks/>
        public string ApplicationName
        {
            get
            {
                return this.applicationNameField;
            }
            set
            {
                this.applicationNameField = value;
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
        public QIFDocumentSoftwareDefinitionsSoftwareReferencedStandardIds ReferencedStandardIds
        {
            get
            {
                return this.referencedStandardIdsField;
            }
            set
            {
                this.referencedStandardIdsField = value;
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
    public partial class QIFDocumentSoftwareDefinitionsSoftwareReferencedStandardIds
    {

        private QIFDocumentSoftwareDefinitionsSoftwareReferencedStandardIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentSoftwareDefinitionsSoftwareReferencedStandardIdsID[] Id
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
    public partial class QIFDocumentSoftwareDefinitionsSoftwareReferencedStandardIdsID
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
