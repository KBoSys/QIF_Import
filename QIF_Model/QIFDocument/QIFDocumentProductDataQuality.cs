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
    public partial class QIFDocumentProductDataQuality
    {

        private bool checksPerformedField;

        private bool checksApprovedField;

        private string declarationField;

        private QIFDocumentProductDataQualityProductDataQualityChecks productDataQualityChecksField;

        /// <remarks/>
        public bool ChecksPerformed
        {
            get
            {
                return this.checksPerformedField;
            }
            set
            {
                this.checksPerformedField = value;
            }
        }

        /// <remarks/>
        public bool ChecksApproved
        {
            get
            {
                return this.checksApprovedField;
            }
            set
            {
                this.checksApprovedField = value;
            }
        }

        /// <remarks/>
        public string Declaration
        {
            get
            {
                return this.declarationField;
            }
            set
            {
                this.declarationField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductDataQualityProductDataQualityChecks ProductDataQualityChecks
        {
            get
            {
                return this.productDataQualityChecksField;
            }
            set
            {
                this.productDataQualityChecksField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductDataQualityProductDataQualityChecks
    {

        private QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheck[] productDataQualityCheckField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductDataQualityCheck")]
        public QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheck[] ProductDataQualityCheck
        {
            get
            {
                return this.productDataQualityCheckField;
            }
            set
            {
                this.productDataQualityCheckField = value;
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
    public partial class QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheck
    {

        private QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckType typeField;

        private string descriptionField;

        private string requirementsField;

        private string sourceOfRequirednessField;

        private QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckApplicationTool applicationToolField;

        private string xsltFileField;

        private string resultStatementField;

        private string resultStatusField;

        /// <remarks/>
        public QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
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
        public string Requirements
        {
            get
            {
                return this.requirementsField;
            }
            set
            {
                this.requirementsField = value;
            }
        }

        /// <remarks/>
        public string SourceOfRequiredness
        {
            get
            {
                return this.sourceOfRequirednessField;
            }
            set
            {
                this.sourceOfRequirednessField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckApplicationTool ApplicationTool
        {
            get
            {
                return this.applicationToolField;
            }
            set
            {
                this.applicationToolField = value;
            }
        }

        /// <remarks/>
        public string XsltFile
        {
            get
            {
                return this.xsltFileField;
            }
            set
            {
                this.xsltFileField = value;
            }
        }

        /// <remarks/>
        public string ResultStatement
        {
            get
            {
                return this.resultStatementField;
            }
            set
            {
                this.resultStatementField = value;
            }
        }

        /// <remarks/>
        public string ResultStatus
        {
            get
            {
                return this.resultStatusField;
            }
            set
            {
                this.resultStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckType
    {

        private string areaEnumField;

        /// <remarks/>
        public string AreaEnum
        {
            get
            {
                return this.areaEnumField;
            }
            set
            {
                this.areaEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckApplicationTool
    {

        private string vendorNameField;

        private string applicationNameField;

        private string versionField;

        private string descriptionField;

        private string uRIField;

        private QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckApplicationToolReferencedStandardIds referencedStandardIdsField;

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
        public QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckApplicationToolReferencedStandardIds ReferencedStandardIds
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
    public partial class QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckApplicationToolReferencedStandardIds
    {

        private QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckApplicationToolReferencedStandardIdsID[] idField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckApplicationToolReferencedStandardIdsID[] Id
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
    public partial class QIFDocumentProductDataQualityProductDataQualityChecksProductDataQualityCheckApplicationToolReferencedStandardIdsID
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
