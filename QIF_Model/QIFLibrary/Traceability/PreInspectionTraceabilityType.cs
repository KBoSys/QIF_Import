/*! \file PreInspectionTraceabilityType.cs

        The PreInspectionTraceabilityType defines information to support
        traceability of the inspection report.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Traceability
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PreInspectionTraceabilityType
    {
        public PreInspectionTraceabilityType () { }

        /// <summary>
        /// The optional InspectingOrganization element gives information
        /// about the organization that generated the data in the report.
        /// The name of the inspecting organization is the 'Organization
        /// Name' required by AS9102A and AS9102B.
        /// </summary>
        [XmlElement]
        public IntermediatesPMI.OrganizationType InspectingOrganization { get; set; }

        /// <summary>
        /// The optional CustomerOrganization element gives information
        /// about the organization that is the customer for the data in the report.
        /// </summary>
        [XmlElement]
        public IntermediatesPMI.CustomerOrganizationType CustomerOrganization { get; set; }

        /// <summary>
        /// The optional SupplierCode element is a number given by the
        /// Customer to the organization that generated the XML file in
        /// which this information appears. From the customer's point of
        /// view, the supplier code identifies a specific supplier.
        /// Supplier code is sometimes called Vendor Code, Vendor
        /// Identification Number, Supplier Number, etc.
        /// </summary>
        [XmlElement]
        public string SupplierCode { get; set; }

        /// <summary>
        /// The optional PurchaseOrderNumber element is an identifier
        /// assigned by the customer to a purchase order.A purchase order
        /// is a contract between the supplier and the customer that
        /// commits the customer and supplier to specific prices for
        /// specific goods (and possibly specific amounts of goods). A
        /// purchase order may be a standing agreement under which a number
        /// of specific orders are made over a period of time.
        /// </summary>
        [XmlElement]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The optional OrderNumber element is an identifier assigned by
        /// the customer to an order.Where there is a standing purchase
        /// order, there may be several order numbers for specific
        /// purchases over a period of time.
        /// </summary>
        [XmlElement]
        public string OrderNumber { get; set; }

        /// <remarks The optional AsmPathIds element is the list of AsmPath QIF ids./>
        [XmlElement]
        public Primitives.ArrayReferenceType AsmPathIds { get; set; }

        /// <summary>
        /// The optional ReportNumber element is the number to be assigned
        /// to the report corresponding to the reported data.If AS9102A or
        /// AS9102B forms are being used, this may be used as the value of
        /// the FAI(First Article Inspection) Report Number field.
        /// </summary>
        [XmlElement]
        public string ReportNumber { get; set; }

        /// <summary>
        /// The optional, enumerated InspectionScope element is the scope
        /// of a first article inspection as used in AS9102A and AS9102B.
        /// </summary>
        [XmlElement]
        public InspectionScopeEnumType InspectionScope { get; set; }

        /// <summary>
        /// The optional, enumerated InspectionMode element is the mode of
        /// a first article inspection as used in AS9102A and AS9102B.
        /// </summary>
        [XmlElement]
        public InspectionModeEnumType InspectionMode { get; set; }

        /// <summary>
        /// The optional PartialInspection element gives the rationale for
        /// a partial inspection.It should be used if the value of the
        /// InspectionMode element is FAI_Partial and may be used for any
        /// other partial inspection.
        /// </summary>
        [XmlElement]
        public PartialInspectionType PartialInspection { get; set; }

        /// <summary>
        /// The optional NotableEvents element is a list of notable events
        /// associated with the inspection.
        /// </summary>
        [XmlElement]
        public IntermediatesPMI.NotableEventsType NotableEvents { get; set; }

        /// <summary>
        /// The optional InspectionSoftwateItems element is a list of
        /// information describing the software to be used in model
        /// creation, inspection and data analysis.
        /// </summary>
        [XmlElement]
        public InspectionSoftwareItemsType InspectionSoftwareItems { get; set; }

        /// <summary>
        /// The optional InspectionProgram element gives information about
        /// a program(such as a CMM program) to be used to in the inspection.
        /// </summary>
        [XmlElement]
        public InspectionProgramType InspectionProgram { get; set; }

        /// <summary>
        /// The optional SecurityClassification element gives the security classification of the inspection report.
        /// </summary>
        [XmlElement]
        public PrimitivesPMI.SecurityClassificationType SecurityClassification { get; set; }

        /// <summary>
        /// The optional PlantLocation element gives information about the
        /// location of the plant where the inspection was performed.
        /// </summary>
        [XmlElement]
        public IntermediatesPMI.LocationType PlantLocation { get; set; }

        //! The ReferencedQIFPlanInstance element identifies the plan that was used in preparing this file.
        [XmlElement("ReferencedQIFPlanInstance", typeof(Primitives.QPIdFullReferenceType))]
        //! The ReferencedQIFPlanInstance element identifies the plan that was used in preparing this file.
        [XmlElement("ReferencedQIFPlan", typeof(string))]
        /// <summary>
        /// This optional compositor allows a choice between identifying a
        /// separate file containing the QIF Plans file that was used in
        /// preparing this file or identifying the plan in this file as the
        /// one that was used in preparing this file.This is relevant if
        /// the file contains results.
        /// </summary>
        public object PlanType { get; set; }

        /// <summary>
        /// The FormalStandardId element is the id of the standard or
        /// specification against which the inspection characteristics are
        /// to be evaluated.
        /// </summary>
        [XmlElement]
        public Primitives.QIFReferenceType FormalStandardId { get; set; }

        /// <summary>
        /// The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured).
        /// </summary>
        [XmlElement]
        public Primitives.AttributesType Attributes { get; set; }
    }
}
