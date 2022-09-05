/*! \file ActualProductTraceabilityType.cs
    \brief defines traceability information for a part or assembly.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Traceability
{
    /// <remarks> The ActualProductTraceabilityType defines traceability information for a part or assembly.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ActualProductTraceabilityType
    {
        /// <remarks> The optional SampleNumber element is the number assigned to a
        /// product with less restriction than Serial Number.e.g. in a
        /// Factorial Designed Experiment each product will be assigned a 'run number'.</remarks>
        public string SampleNumber { get; set; }

        /// <remarks> The optional LotNumber element is the number of the lot from which the sample is drawn.</remarks>
        public string LotNumber { get; set; }

        /// <remarks> The optional ReportNumber element is the number assigned to the
        /// report corresponding to the reported data.If AS9102A or
        /// AS9102B forms are being used, this may be used as the value of
        /// the FAI (First Article Inspection) Report Number field.</remarks>
        public string ReportNumber { get; set; }

        /// <remarks> The optional ManufacturingProcessId element is a reference to
        /// the traceability information for the manufacturing process used to create the product.</remarks>
        public QIFReferenceType ManufacturingProcessId { get; set; }

        /// <remarks> The optional FixtureId element is a QIF reference to a fixture used to create the product.</remarks>
        public QIFReferenceType FixtureId { get; set; }

        /// <remarks> The optional NotableEventIds element is a list of QIF ids of notable events.</remarks>
        public ArrayReferenceType NotableEventIds { get; set; }

        /// <remarks> The optional NotedEventIds element is a list of QIF ids of noted events that occurred during creation of the product.</remarks>
        public ArrayReferenceType NotedEventIds { get; set; }

        /// <remarks> The optional InspectionStart element is the date and time in GMT(not local time) when the inspection started.</remarks>
        public System.DateTime InspectionStart { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InspectionStartSpecified { get; set; }

        /// <remarks> The optional InspectionEnd element is the date and time in GMT
        /// (not local time) when the inspection of the product completed.
        /// For systems that do both inspection and analysis, it would
        /// imply completion of both inspection and the analysis.</remarks>
        public System.DateTime InspectionEnd { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InspectionEndSpecified { get; set; }

        /// <remarks> The optional InspectionSoftwareItems element is a list of software used in the inspection.</remarks>
        public InspectionSoftwareItemsType InspectionSoftwareItems { get; set; }

        /// <remarks> The optional InspectionProgram element gives information about
        /// a program(such as a CMM program) used or to inspect the product.</remarks>
        public InspectionProgramType InspectionProgram { get; set; }

        /// <remarks> The optional InspectionOperator element gives information about
        /// the person who operated the inspection device that gathered the data being reported.</remarks>
        public IntermediatesPMI.EmployeeType InspectionOperator { get; set; }

        /// <remarks> The optional MeasurementDeviceIds element is a list of
        /// references to the measurement devices used in the inspection.</remarks>
        public ArrayReferenceType MeasurementDeviceIds { get; set; }

        /// <remarks> The optional ProductEnvironments element is a list of environments recorded during the inspection.</remarks>
        public EnvironmentsType ProductEnvironments { get; set; }

        /// <remarks> The optional Errors element is a list of any errors that occurred during the measurement process.</remarks>
        public ErrorsType Errors { get; set; }

        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }
    }

    /// <remarks> The EnvironmentsType defines a list of environment instances.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EnvironmentsType : ArrayBaseType<EnvironmentType>
    {
        /// <remarks> Each Environment element gives information about an environment record instance.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Environment")]
        public EnvironmentType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The EnvironmentType defines information about the temperature and/or humidity at a particular time during a measurement process.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EnvironmentType
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }

        /// <remarks> The optional ObjectTemperature element is the temperature of
        /// the product or feature to which an environment instance is attached.</remarks>
        public MeasuredTemperatureValueType ObjectTemperature { get; set; }

        /// <remarks> The optional AmbientTemperature element is the temperature of
        /// the air in the area in which the inspection is performed.</remarks>
        public MeasuredTemperatureValueType AmbientTemperature { get; set; }

        /// <remarks> The optional RelativeHumidity element is the relative humidity
        /// of the air in the area in which the inspection is performed.
        /// The RelativeHumidity value must be between 0 and 100.</remarks>
        public MeasuredDecimalType RelativeHumidity { get; set; }

        /// <remarks> The DateAndTime element gives the date and time at which the environment data is recorded.</remarks>
        public System.DateTime DateAndTime { get; set; }

        /// <remarks> The optional TimeDescription element gives the time, relative
        /// to the inspection, at which the environment data is measured.</remarks>
        public TimeDescriptionType TimeDescription { get; set; }
    }

    /// <remarks> The TimeDescriptionType defines the time, relative to the
    /// inspection, at which the environment data are measured.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TimeDescriptionType
    {
        /// <remarks> The TimeDescriptionEnum element describes an often-used relative time.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("OtherTimeDescription", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TimeDescriptionEnum", typeof(TimeDescriptionEnumType))]
        public object Item { get; set; }
    }

    /// <remarks> The TimeDescriptionEnumType enumerates values that describe the
    /// time, relative to the inspection, at which the environment data are
    /// measured. INTERMEDIATE means between INSPECTION_START and INSPECTION_END.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum TimeDescriptionEnumType
    {
        /// <remarks></remarks>
        INSPECTION_START,

        /// <remarks></remarks>
        INSPECTION_END,

        /// <remarks></remarks>
        INTERMEDIATE,
    }
}

