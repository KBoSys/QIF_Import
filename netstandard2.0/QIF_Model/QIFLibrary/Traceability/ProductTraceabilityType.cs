/*! \file ProductTraceabilityType.cs
	\brief Defines traceability information for a part or assembly.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Traceability
{
    /// <remarks> The ProductTraceabilityType defines traceability information for a part or assembly.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ProductTraceabilityType
    {
        /// <remarks> The optional ReportNumber element is the number to be assigned
        /// to the report corresponding to the reported data.If AS9102A or
        /// AS9102B forms are being used, this may be used as the value of
        /// the FAI (First Article Inspection) Report Number field.</remarks>
        public string ReportNumber { get; set; }

        /// <remarks> The optional ManufacturingProcessId element is a reference to
        /// the traceability information for the manufacturing process to
        /// be used to create the product.</remarks>
        public QIFReferenceType ManufacturingProcessId { get; set; }

        /// <remarks> The optional FixtureId element is a QIF reference to a fixture
        /// defined to be used in the setup of a measurement plan.</remarks>
        public QIFReferenceType FixtureId { get; set; }

        /// <remarks> The optional NotableEventIds element is a list of QIF ids of notable events.</remarks>
        public ArrayReferenceType NotableEventIds { get; set; }

        /// <remarks> The optional InspectionSoftwareItems element is a list of software to be used in the inspection.</remarks>
        public InspectionSoftwareItemsType InspectionSoftwareItems { get; set; }

        /// <remarks> The optional InspectionProgram element gives information abouta program(such as a CMM program) to be used to inspect the product.</remarks>
        public InspectionProgramType InspectionProgram { get; set; }

        /// <remarks> The optional MeasurementDeviceIds element is a list of references to the measurement devices to be used in the inspection.</remarks>
        public ArrayReferenceType MeasurementDeviceIds { get; set; }

        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }
    }
}
