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
    public partial class QIFDocumentPreInspectionTraceability
    {

        private QIFDocumentPreInspectionTraceabilityInspectingOrganization inspectingOrganizationField;

        private QIFDocumentPreInspectionTraceabilityCustomerOrganization customerOrganizationField;

        private string supplierCodeField;

        private string purchaseOrderNumberField;

        private string orderNumberField;

        private QIFDocumentPreInspectionTraceabilityAsmPathIds asmPathIdsField;

        private string reportNumberField;

        private string inspectionScopeField;

        private string inspectionModeField;

        private QIFDocumentPreInspectionTraceabilityPartialInspection partialInspectionField;

        private QIFDocumentPreInspectionTraceabilityNotableEvents notableEventsField;

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItems inspectionSoftwareItemsField;

        private QIFDocumentPreInspectionTraceabilityInspectionProgram inspectionProgramField;

        private QIFDocumentPreInspectionTraceabilitySecurityClassification securityClassificationField;

        private QIFDocumentPreInspectionTraceabilityPlantLocation plantLocationField;

        private QIFDocumentPreInspectionTraceabilityReferencedQIFPlanInstance referencedQIFPlanInstanceField;

        private QIFDocumentPreInspectionTraceabilityFormalStandardId formalStandardIdField;

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectingOrganization InspectingOrganization
        {
            get
            {
                return this.inspectingOrganizationField;
            }
            set
            {
                this.inspectingOrganizationField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityCustomerOrganization CustomerOrganization
        {
            get
            {
                return this.customerOrganizationField;
            }
            set
            {
                this.customerOrganizationField = value;
            }
        }

        /// <remarks/>
        public string SupplierCode
        {
            get
            {
                return this.supplierCodeField;
            }
            set
            {
                this.supplierCodeField = value;
            }
        }

        /// <remarks/>
        public string PurchaseOrderNumber
        {
            get
            {
                return this.purchaseOrderNumberField;
            }
            set
            {
                this.purchaseOrderNumberField = value;
            }
        }

        /// <remarks/>
        public string OrderNumber
        {
            get
            {
                return this.orderNumberField;
            }
            set
            {
                this.orderNumberField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityAsmPathIds AsmPathIds
        {
            get
            {
                return this.asmPathIdsField;
            }
            set
            {
                this.asmPathIdsField = value;
            }
        }

        /// <remarks/>
        public string ReportNumber
        {
            get
            {
                return this.reportNumberField;
            }
            set
            {
                this.reportNumberField = value;
            }
        }

        /// <remarks/>
        public string InspectionScope
        {
            get
            {
                return this.inspectionScopeField;
            }
            set
            {
                this.inspectionScopeField = value;
            }
        }

        /// <remarks/>
        public string InspectionMode
        {
            get
            {
                return this.inspectionModeField;
            }
            set
            {
                this.inspectionModeField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityPartialInspection PartialInspection
        {
            get
            {
                return this.partialInspectionField;
            }
            set
            {
                this.partialInspectionField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityNotableEvents NotableEvents
        {
            get
            {
                return this.notableEventsField;
            }
            set
            {
                this.notableEventsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItems InspectionSoftwareItems
        {
            get
            {
                return this.inspectionSoftwareItemsField;
            }
            set
            {
                this.inspectionSoftwareItemsField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectionProgram InspectionProgram
        {
            get
            {
                return this.inspectionProgramField;
            }
            set
            {
                this.inspectionProgramField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilitySecurityClassification SecurityClassification
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
        public QIFDocumentPreInspectionTraceabilityPlantLocation PlantLocation
        {
            get
            {
                return this.plantLocationField;
            }
            set
            {
                this.plantLocationField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityReferencedQIFPlanInstance ReferencedQIFPlanInstance
        {
            get
            {
                return this.referencedQIFPlanInstanceField;
            }
            set
            {
                this.referencedQIFPlanInstanceField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityFormalStandardId FormalStandardId
        {
            get
            {
                return this.formalStandardIdField;
            }
            set
            {
                this.formalStandardIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectingOrganization
    {

        private string nameField;

        private QIFDocumentPreInspectionTraceabilityInspectingOrganizationAddress addressField;

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
        public QIFDocumentPreInspectionTraceabilityInspectingOrganizationAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectingOrganizationAddress
    {

        private QIFDocumentPreInspectionTraceabilityInspectingOrganizationAddressDescription descriptionField;

        private string internalLocationField;

        private string streetNumberField;

        private string streetField;

        private string postalBoxField;

        private string townField;

        private string regionField;

        private string postalCodeField;

        private string countryField;

        private string facsimileNumberField;

        private string telephoneNumberField;

        private string electronicMailAddressField;

        private string telexNumberField;

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectingOrganizationAddressDescription Description
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
        public string InternalLocation
        {
            get
            {
                return this.internalLocationField;
            }
            set
            {
                this.internalLocationField = value;
            }
        }

        /// <remarks/>
        public string StreetNumber
        {
            get
            {
                return this.streetNumberField;
            }
            set
            {
                this.streetNumberField = value;
            }
        }

        /// <remarks/>
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string PostalBox
        {
            get
            {
                return this.postalBoxField;
            }
            set
            {
                this.postalBoxField = value;
            }
        }

        /// <remarks/>
        public string Town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }

        /// <remarks/>
        public string Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string FacsimileNumber
        {
            get
            {
                return this.facsimileNumberField;
            }
            set
            {
                this.facsimileNumberField = value;
            }
        }

        /// <remarks/>
        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumberField;
            }
            set
            {
                this.telephoneNumberField = value;
            }
        }

        /// <remarks/>
        public string ElectronicMailAddress
        {
            get
            {
                return this.electronicMailAddressField;
            }
            set
            {
                this.electronicMailAddressField = value;
            }
        }

        /// <remarks/>
        public string TelexNumber
        {
            get
            {
                return this.telexNumberField;
            }
            set
            {
                this.telexNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectingOrganizationAddressDescription
    {

        private string addressDescriptionEnumField;

        /// <remarks/>
        public string AddressDescriptionEnum
        {
            get
            {
                return this.addressDescriptionEnumField;
            }
            set
            {
                this.addressDescriptionEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityCustomerOrganization
    {

        private string nameField;

        private QIFDocumentPreInspectionTraceabilityCustomerOrganizationAddress addressField;

        private string customerNumberField;

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
        public QIFDocumentPreInspectionTraceabilityCustomerOrganizationAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string CustomerNumber
        {
            get
            {
                return this.customerNumberField;
            }
            set
            {
                this.customerNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityCustomerOrganizationAddress
    {

        private QIFDocumentPreInspectionTraceabilityCustomerOrganizationAddressDescription descriptionField;

        private string internalLocationField;

        private string streetNumberField;

        private string streetField;

        private string postalBoxField;

        private string townField;

        private string regionField;

        private string postalCodeField;

        private string countryField;

        private string facsimileNumberField;

        private string telephoneNumberField;

        private string electronicMailAddressField;

        private string telexNumberField;

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityCustomerOrganizationAddressDescription Description
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
        public string InternalLocation
        {
            get
            {
                return this.internalLocationField;
            }
            set
            {
                this.internalLocationField = value;
            }
        }

        /// <remarks/>
        public string StreetNumber
        {
            get
            {
                return this.streetNumberField;
            }
            set
            {
                this.streetNumberField = value;
            }
        }

        /// <remarks/>
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string PostalBox
        {
            get
            {
                return this.postalBoxField;
            }
            set
            {
                this.postalBoxField = value;
            }
        }

        /// <remarks/>
        public string Town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }

        /// <remarks/>
        public string Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string FacsimileNumber
        {
            get
            {
                return this.facsimileNumberField;
            }
            set
            {
                this.facsimileNumberField = value;
            }
        }

        /// <remarks/>
        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumberField;
            }
            set
            {
                this.telephoneNumberField = value;
            }
        }

        /// <remarks/>
        public string ElectronicMailAddress
        {
            get
            {
                return this.electronicMailAddressField;
            }
            set
            {
                this.electronicMailAddressField = value;
            }
        }

        /// <remarks/>
        public string TelexNumber
        {
            get
            {
                return this.telexNumberField;
            }
            set
            {
                this.telexNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityCustomerOrganizationAddressDescription
    {

        private string addressDescriptionEnumField;

        /// <remarks/>
        public string AddressDescriptionEnum
        {
            get
            {
                return this.addressDescriptionEnumField;
            }
            set
            {
                this.addressDescriptionEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityAsmPathIds
    {

        private QIFDocumentPreInspectionTraceabilityAsmPathIdsID[] idField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentPreInspectionTraceabilityAsmPathIdsID[] Id
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
    public partial class QIFDocumentPreInspectionTraceabilityAsmPathIdsID
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityPartialInspection
    {

        private string baselineProductNumberField;

        private string baselineProductVersionField;

        private string reasonForPartialInspectionField;

        /// <remarks/>
        public string BaselineProductNumber
        {
            get
            {
                return this.baselineProductNumberField;
            }
            set
            {
                this.baselineProductNumberField = value;
            }
        }

        /// <remarks/>
        public string BaselineProductVersion
        {
            get
            {
                return this.baselineProductVersionField;
            }
            set
            {
                this.baselineProductVersionField = value;
            }
        }

        /// <remarks/>
        public string ReasonForPartialInspection
        {
            get
            {
                return this.reasonForPartialInspectionField;
            }
            set
            {
                this.reasonForPartialInspectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityNotableEvents
    {

        private QIFDocumentPreInspectionTraceabilityNotableEventsNotableEvent[] notableEventField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotableEvent")]
        public QIFDocumentPreInspectionTraceabilityNotableEventsNotableEvent[] NotableEvent
        {
            get
            {
                return this.notableEventField;
            }
            set
            {
                this.notableEventField = value;
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
    public partial class QIFDocumentPreInspectionTraceabilityNotableEventsNotableEvent
    {

        private string descriptionField;

        private bool activeField;

        private uint idField;

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
        public bool Active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
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
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItems
    {

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramGenerationSoftware inspectionProgramGenerationSoftwareField;

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramExecutionSoftware inspectionProgramExecutionSoftwareField;

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsAnalysisSoftware analysisSoftwareField;

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsCADSoftware cADSoftwareField;

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsDMESoftware dMESoftwareField;

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramGenerationSoftware InspectionProgramGenerationSoftware
        {
            get
            {
                return this.inspectionProgramGenerationSoftwareField;
            }
            set
            {
                this.inspectionProgramGenerationSoftwareField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramExecutionSoftware InspectionProgramExecutionSoftware
        {
            get
            {
                return this.inspectionProgramExecutionSoftwareField;
            }
            set
            {
                this.inspectionProgramExecutionSoftwareField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsAnalysisSoftware AnalysisSoftware
        {
            get
            {
                return this.analysisSoftwareField;
            }
            set
            {
                this.analysisSoftwareField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsCADSoftware CADSoftware
        {
            get
            {
                return this.cADSoftwareField;
            }
            set
            {
                this.cADSoftwareField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsDMESoftware DMESoftware
        {
            get
            {
                return this.dMESoftwareField;
            }
            set
            {
                this.dMESoftwareField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramGenerationSoftware
    {

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramGenerationSoftwareID[] idField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramGenerationSoftwareID[] Id
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
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramGenerationSoftwareID
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramExecutionSoftware
    {

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramExecutionSoftwareID[] idField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramExecutionSoftwareID[] Id
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
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsInspectionProgramExecutionSoftwareID
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsAnalysisSoftware
    {

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsAnalysisSoftwareID[] idField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsAnalysisSoftwareID[] Id
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
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsAnalysisSoftwareID
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsCADSoftware
    {

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsCADSoftwareID[] idField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsCADSoftwareID[] Id
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
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsCADSoftwareID
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsDMESoftware
    {

        private QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsDMESoftwareID[] idField;

        private byte nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsDMESoftwareID[] Id
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
    public partial class QIFDocumentPreInspectionTraceabilityInspectionSoftwareItemsDMESoftwareID
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectionProgram
    {

        private QIFDocumentPreInspectionTraceabilityInspectionProgramFile fileField;

        private string descriptionField;

        private QIFDocumentPreInspectionTraceabilityInspectionProgramFormalStandardId formalStandardIdField;

        private QIFDocumentPreInspectionTraceabilityInspectionProgramAuthor authorField;

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectionProgramFile File
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
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
        public QIFDocumentPreInspectionTraceabilityInspectionProgramFormalStandardId FormalStandardId
        {
            get
            {
                return this.formalStandardIdField;
            }
            set
            {
                this.formalStandardIdField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityInspectionProgramAuthor Author
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectionProgramFile
    {

        private string nameField;

        private string versionField;

        private QIFDocumentPreInspectionTraceabilityInspectionProgramFileFormat formatField;

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
        public QIFDocumentPreInspectionTraceabilityInspectionProgramFileFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectionProgramFileFormat
    {

        private string digitalModelFormatEnumField;

        /// <remarks/>
        public string DigitalModelFormatEnum
        {
            get
            {
                return this.digitalModelFormatEnumField;
            }
            set
            {
                this.digitalModelFormatEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityInspectionProgramFormalStandardId
    {

        private byte xIdField;

        private byte valueField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
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
    public partial class QIFDocumentPreInspectionTraceabilityInspectionProgramAuthor
    {

        private string nameField;

        private string employeeIdField;

        private string shiftField;

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
        public string EmployeeId
        {
            get
            {
                return this.employeeIdField;
            }
            set
            {
                this.employeeIdField = value;
            }
        }

        /// <remarks/>
        public string Shift
        {
            get
            {
                return this.shiftField;
            }
            set
            {
                this.shiftField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilitySecurityClassification
    {

        private string securityClassificationEnumField;

        /// <remarks/>
        public string SecurityClassificationEnum
        {
            get
            {
                return this.securityClassificationEnumField;
            }
            set
            {
                this.securityClassificationEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityPlantLocation
    {

        private string locationDescriptionField;

        private QIFDocumentPreInspectionTraceabilityPlantLocationAddress addressField;

        private byte idField;

        /// <remarks/>
        public string LocationDescription
        {
            get
            {
                return this.locationDescriptionField;
            }
            set
            {
                this.locationDescriptionField = value;
            }
        }

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityPlantLocationAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
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
    public partial class QIFDocumentPreInspectionTraceabilityPlantLocationAddress
    {

        private QIFDocumentPreInspectionTraceabilityPlantLocationAddressDescription descriptionField;

        private string internalLocationField;

        private string streetNumberField;

        private string streetField;

        private string postalBoxField;

        private string townField;

        private string regionField;

        private string postalCodeField;

        private string countryField;

        private string facsimileNumberField;

        private string telephoneNumberField;

        private string electronicMailAddressField;

        private string telexNumberField;

        /// <remarks/>
        public QIFDocumentPreInspectionTraceabilityPlantLocationAddressDescription Description
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
        public string InternalLocation
        {
            get
            {
                return this.internalLocationField;
            }
            set
            {
                this.internalLocationField = value;
            }
        }

        /// <remarks/>
        public string StreetNumber
        {
            get
            {
                return this.streetNumberField;
            }
            set
            {
                this.streetNumberField = value;
            }
        }

        /// <remarks/>
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string PostalBox
        {
            get
            {
                return this.postalBoxField;
            }
            set
            {
                this.postalBoxField = value;
            }
        }

        /// <remarks/>
        public string Town
        {
            get
            {
                return this.townField;
            }
            set
            {
                this.townField = value;
            }
        }

        /// <remarks/>
        public string Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string FacsimileNumber
        {
            get
            {
                return this.facsimileNumberField;
            }
            set
            {
                this.facsimileNumberField = value;
            }
        }

        /// <remarks/>
        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumberField;
            }
            set
            {
                this.telephoneNumberField = value;
            }
        }

        /// <remarks/>
        public string ElectronicMailAddress
        {
            get
            {
                return this.electronicMailAddressField;
            }
            set
            {
                this.electronicMailAddressField = value;
            }
        }

        /// <remarks/>
        public string TelexNumber
        {
            get
            {
                return this.telexNumberField;
            }
            set
            {
                this.telexNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityPlantLocationAddressDescription
    {

        private string addressDescriptionEnumField;

        /// <remarks/>
        public string AddressDescriptionEnum
        {
            get
            {
                return this.addressDescriptionEnumField;
            }
            set
            {
                this.addressDescriptionEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityReferencedQIFPlanInstance
    {

        private string itemQPIdField;

        private string[] documentQPIdField;

        /// <remarks/>
        public string ItemQPId
        {
            get
            {
                return this.itemQPIdField;
            }
            set
            {
                this.itemQPIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentQPId")]
        public string[] DocumentQPId
        {
            get
            {
                return this.documentQPIdField;
            }
            set
            {
                this.documentQPIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFDocumentPreInspectionTraceabilityFormalStandardId
    {

        private byte xIdField;

        private byte valueField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
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
