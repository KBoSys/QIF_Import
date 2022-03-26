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
    public partial class QIFDocumentStandardsDefinitions
    {

        private QIFDocumentStandardsDefinitionsStandard[] standardField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Standard")]
        public QIFDocumentStandardsDefinitionsStandard[] Standard
        {
            get
            {
                return this.standardField;
            }
            set
            {
                this.standardField = value;
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
    public partial class QIFDocumentStandardsDefinitionsStandard
    {

        private QIFDocumentStandardsDefinitionsStandardOrganization organizationField;

        private string designatorField;

        private string yearField;

        private string titleField;

        private string descriptionField;

        private string uRIField;

        private string iSBNField;

        private QIFDocumentStandardsDefinitionsStandardReferencedStandardIds referencedStandardIdsField;

        private uint idField;

        /// <remarks/>
        public QIFDocumentStandardsDefinitionsStandardOrganization Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        public string Designator
        {
            get
            {
                return this.designatorField;
            }
            set
            {
                this.designatorField = value;
            }
        }

        /// <remarks/>
        public string Year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
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
        public string ISBN
        {
            get
            {
                return this.iSBNField;
            }
            set
            {
                this.iSBNField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentStandardsDefinitionsStandardReferencedStandardIds ReferencedStandardIds
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
    public partial class QIFDocumentStandardsDefinitionsStandardOrganization
    {

        private string standardsOrganizationEnumField;

        /// <remarks/>
        public string StandardsOrganizationEnum
        {
            get
            {
                return this.standardsOrganizationEnumField;
            }
            set
            {
                this.standardsOrganizationEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentStandardsDefinitionsStandardReferencedStandardIds
    {

        private QIFDocumentStandardsDefinitionsStandardReferencedStandardIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentStandardsDefinitionsStandardReferencedStandardIdsID[] Id
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
    public partial class QIFDocumentStandardsDefinitionsStandardReferencedStandardIdsID
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
