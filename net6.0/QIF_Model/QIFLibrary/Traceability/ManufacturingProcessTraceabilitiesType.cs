/*! \file ManufacturingProcessTraceabilitiesType.cs
    \brief Defines a list of manufacturing traceabilities that can be referenced by their QIF Id.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Traceability
{
    /// <remarks> The ManufacturingProcessTraceabilitiesType defines a list of
    /// manufacturing traceabilities that can be referenced by their QIF Id.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ManufacturingProcessTraceabilitiesType : ArrayBaseType<ManufacturingProcessTraceabilityType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturingProcessTraceability")]
        public ManufacturingProcessTraceabilityType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The ManufacturingProcessTraceabilityType defines traceability information for a manufacturing process.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ManufacturingProcessTraceabilityType
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType? Attributes { get; set; }

        /// <remarks> The optional Description element gives the manufacturing process.</remarks>
        public string? Description { get; set; }

        /// <remarks> The optional Job element is the job number for the manufacturing process.</remarks>
        public string? Job { get; set; }

        /// <remarks> The optional Revision element is the revision number of the manufacturing process(NC cutter tape for example).</remarks>
        public string? Revision { get; set; }

        /// <remarks> The optional PreviousOperationId element identifies an instance
        /// of ManufacturingProcessTraceabilityType giving the
        /// manufacturing process traceability information for the previous manufacturing operation.</remarks>
        public QIFReferenceType? PreviousOperationId { get; set; }

        /// <remarks> The optional Path element gives the physical route used in a manufacturing process, e.g. "Line 3/Drilling machine #7/Spindle #2".</remarks>
        public string? Path { get; set; }

        /// <remarks> The optional MachineManufacturerName element is the name of the company manufacturing the machine tool used in the process.</remarks>
        public string? MachineManufacturerName { get; set; }

        /// <remarks> The optional MachineIdentifier element is the identifier for the machine tool used in the process.</remarks>
        public string? MachineIdentifier { get; set; }

        /// <remarks> The optional OperatorIdentifier element gives an identifier for the person operating the machine tool used in the process.</remarks>
        public string? OperatorIdentifier { get; set; }

        /// <remarks> The optional Shift element gives the shift in which this manufacturing process took place.</remarks>
        public string? Shift { get; set; }

        /// <remarks> The optional Department element is the name of the department undertaking the manufacturing process.</remarks>
        public string? Department { get; set; }

        /// <remarks> The optional ResponsibilityIdentifier element gives an identifier for the entity responsible for this manufacturing process.</remarks>
        public string? ResponsibilityIdentifier { get; set; }

        /// <remarks> The optional PlantSector element is the plant sector in which the manufacturing process takes place.</remarks>
        public string? PlantSector { get; set; }

        /// <remarks> The optional ProcessParameters element gives the type and value of process parameters used in the manufacturing process.</remarks>
        public ProcessParametersType ProcessParameters { get; set; }

        /// <remarks> The optional AssociatedTraceabilityId element identifies an
        /// instance of ManufacturingProcessTraceabilityType giving
        /// manufacturing process traceability information associated with
        /// this manufacturing operation.Some traceability information
        /// like Department and PlantSector can apply to many items; this
        /// sort of data can be stored in one instance and referenced by
        /// other traceability instances.</remarks>
        public QIFReferenceType? AssociatedTraceabilityId { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        #region QIFIdType
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; } = new QIFApplications.QIFIdType();

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
        #endregion
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ProcessParametersType : ArrayBaseType<ProcessParameterType>
    { 
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ProcessParameterType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ProcessParameterType
    {
        /// <remarks></remarks>
        public string? ParameterType { get; set; }

        /// <remarks></remarks>
        public string? ParameterValue { get; set; }
    }
}
