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
    public partial class QIFDocumentHeader
    {

        private QIFDocumentHeaderApplication applicationField;

        private QIFDocumentHeaderAuthor authorField;

        private QIFDocumentHeaderApplicationSource applicationSourceField;

        private string descriptionField;

        private string scopeField;

        /// <remarks/>
        public QIFDocumentHeaderApplication Application
        {
            get
            {
                return this.applicationField;
            }
            set
            {
                this.applicationField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentHeaderAuthor Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentHeaderApplicationSource ApplicationSource
        {
            get
            {
                return this.applicationSourceField;
            }
            set
            {
                this.applicationSourceField = value;
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
        public string Scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentHeaderApplication
    {

        private string nameField;

        private string organizationField;

        private string addonNameField;

        private string addonOrganizationField;

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
        public string Organization
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
        public string AddonName
        {
            get
            {
                return this.addonNameField;
            }
            set
            {
                this.addonNameField = value;
            }
        }

        /// <remarks/>
        public string AddonOrganization
        {
            get
            {
                return this.addonOrganizationField;
            }
            set
            {
                this.addonOrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentHeaderAuthor
    {

        private string nameField;

        private string organizationField;

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
        public string Organization
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentHeaderApplicationSource
    {

        private string nameField;

        private string organizationField;

        private string addonNameField;

        private string addonOrganizationField;

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
        public string Organization
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
        public string AddonName
        {
            get
            {
                return this.addonNameField;
            }
            set
            {
                this.addonNameField = value;
            }
        }

        /// <remarks/>
        public string AddonOrganization
        {
            get
            {
                return this.addonOrganizationField;
            }
            set
            {
                this.addonOrganizationField = value;
            }
        }
    }

}
