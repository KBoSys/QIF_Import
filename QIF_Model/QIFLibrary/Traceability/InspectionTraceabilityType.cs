/*! \file InspectionTraceabilityType.cs
	\brief defines information to support traceability of the inspection report.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Traceability
{
    /// <remarks> The InspectionTraceabilityType defines information to support traceability of the inspection report.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class InspectionTraceabilityType
    {
        /// <remarks> The optional InspectingOrganization element gives information
        /// about the organization that generated the data in the report.
        /// The name of the inspecting organization is the 'Organization
        /// Name' required by AS9102A and AS9102B.</remarks>
        public IntermediatesPMI.OrganizationType InspectingOrganization { get; set; }

        /// <remarks> The optional CustomerOrganization element gives information
        /// about the organization that is the customer for the data in the report.</remarks>
        public IntermediatesPMI.CustomerOrganizationType CustomerOrganization { get; set; }

        /// <remarks> The optional SupplierCode element is a number given by the
        /// Customer to the organization that generated the XML file in
        /// which this information appears. From the customer's point of
        /// view, the supplier code identifies a specific supplier.
        /// Supplier code is sometimes called Vendor Code, Vendor
        /// Identification Number, Supplier Number, etc.</remarks>
        public string SupplierCode { get; set; }

        /// <remarks> The optional PurchaseOrderNumber element is an identifier
        /// assigned by the customer to a purchase order.A purchase order
        /// is a contract between the supplier and the customer that
        /// commits the customer and supplier to specific prices for
        /// specific goods (and possibly specific amounts of goods). A
        /// purchase order may be a standing agreement under which a number
        /// of specific orders are made over a period of time.</remarks>
        public string PurchaseOrderNumber { get; set; }

        /// <remarks> The optional OrderNumber element is an identifier assigned by
        /// the customer to an order.Where there is a standing purchase
        /// order, there may be several order numbers for specific
        /// purchases over a period of time.</remarks>
        public string OrderNumber { get; set; }

        /// <remarks> The optional ReportNumber element is the number assigned to the
        /// report corresponding to the reported data.If AS9102A or
        /// AS9102B forms are being used, this may be used as the value of
        /// the FAI (First Article Inspection) Report Number field.</remarks>
        public string ReportNumber { get; set; }

        /// <remarks> The optional, enumerated InspectionScope element is the scope
        /// of a first article inspection as used in AS9102A and AS9102B.</remarks>
        public InspectionScopeEnumType InspectionScope { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InspectionScopeSpecified { get; set; }

        /// <remarks> The optional, enumerated InspectionMode element is the mode of
        /// a first article inspection as used in AS9102A and AS9102B.</remarks>
        public InspectionModeEnumType InspectionMode { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InspectionModeSpecified { get; set; }

        /// <remarks> The optional PartialInspection element gives the rationale for
        /// a partial inspection.It should be used if the value of the
        /// InspectionMode element is FAI_Partial and may be used for any other partial inspection.</remarks>
        public PartialInspectionType PartialInspection { get; set; }

        /// <remarks> The optional NotableEvents element is a list of notable events associated with the inspection.</remarks>
        public IntermediatesPMI.NotableEventsType NotableEvents { get; set; }

        /// <remarks> The optional NotedEvents element is a list of noted events associated with the inspection.</remarks>
        public IntermediatesPMI.NotedEventsType NotedEvents { get; set; }

        /// <remarks> The optional InspectionStart element is the date and time in GMT(not local time) when the inspection started.</remarks>
        public System.DateTime InspectionStart { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InspectionStartSpecified { get; set; }

        /// <remarks> The optional InspectionEnd element is the date and time in GMT
        /// (not local time) when the inspection completed.For systems
        /// that do both inspection and analysis, it would imply completion
        /// of both inspection and the analysis.</remarks>
        public System.DateTime InspectionEnd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InspectionEndSpecified { get; set; }

        /// <remarks> The optional InspectionSoftwateItems element is a list of
        /// information describing the software used in model creation,
        /// inspection and data analysis.</remarks>
        public InspectionSoftwareItemsType InspectionSoftwareItems { get; set; }

        /// <remarks> The optional InspectionProgram element gives information about
        /// a program(such as a CMM program) used or to be used to in the inspection.</remarks>
        public InspectionProgramType InspectionProgram { get; set; }

        /// <remarks> The optional InspectionOperator element gives information about
        /// the person who operated the inspection device that gathered the data being reported.</remarks>
        public IntermediatesPMI.EmployeeType InspectionOperator { get; set; }

        /// <remarks> The optional ReportPreparer element gives information about the
        /// person who prepared the inspection report(an AS9102A or
        /// AS9102B first article inspection report, for example).</remarks>
        public IntermediatesPMI.EmployeeType ReportPreparer { get; set; }

        /// <remarks> The optional ReportPreparationDate element is the date and time
        /// in GMT(not local time) when the report was completed.</remarks>
        public System.DateTime ReportPreparationDate { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportPreparationDateSpecified { get; set; }

        /// <remarks> The optional ReportType element is the type of inspection report.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string ReportType { get; set; }

        /// <remarks> The optional SecurityClassification element gives the security classification of the inspection report.</remarks>
        public PrimitivesPMI.SecurityClassificationType SecurityClassification { get; set; }

        /// <remarks> The optional PlantLocation element gives information about the location of the plant where the inspection was performed.</remarks>
        public IntermediatesPMI.LocationType PlantLocation { get; set; }

        /// <remarks> This optional compositor allows a choice between identifying a
        /// plan in a separate file that was used in preparing this file or
        /// identifying the plan in this file as the one that was used in
        /// preparing this file.This is relevant if the file contains results.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ReferencedQIFPlan", typeof(string), DataType = "NMTOKEN")]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedQIFPlanInstance", typeof(Primitives.QPIdFullReferenceType))]
        public object Item { get; set; }

        /// <remarks> The optional Errors element is a list of any errors that occurred during the measurement process.</remarks>
        public ErrorsType Errors { get; set; }

        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public Primitives.AttributesType Attributes { get; set; }
    }

    /// <remarks> The ErrorsType defines a list of errors that occurred during the measurement process.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ErrorsType
    {
        /// <remarks> Each Error element describes an error that occurred during the measurement process.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Error")]
        public string[] Errors { get; set; }

        /// <remarks> The required n attribute is the number of Error elements in the set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Errors.Length;
            set { }
        }
    }
}
