/*! \file ProcessDifferenceStudyPlanType.cs
    \brief defines information that is related to a difference statistical study where the same part is
        measured before and after a manufacturing process to determine any
        part distortion caused by that process.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks> The ProcessDifferenceStudyPlanType defines information that is
    /// related to a difference statistical study where the same part is
    /// measured before and after a manufacturing process to determine any
    /// part distortion caused by that process.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ProcessDifferenceStudyPlanType : StatisticalStudyPlanBaseType
    {
        /// <remarks> The NumberOfSamples element specifies the number of samples
        /// to be used in the statistical study.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfSamples { get; set; }

        /// <remarks> The SubgroupSize element fixes the size of each subgroup to 2. 
        /// The first item in each subgroup is the result of
        /// measurement before the manufacturing process and the second
        /// item is the result of measurement after the process.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SubgroupSize { get; set; } = 2;

        /// <remarks> The optional ManufacturingProcessId element is a reference
        /// to the traceability information for the process on which
        /// the study is to be based.</remarks>
        public QIFReferenceType? ManufacturingProcessId { get; set; }

        /// <remarks> This compositor provides a choice between the two methods
        /// (absolute and relative) used to determine maximum allowed differences.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AbsoluteDifferences", typeof(AbsoluteLimitsByUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeDifference", typeof(decimal))]
        public object? Method { get; set; }
    }

    /// <remarks> The AbsoluteLimitsByUnitType defines a list of limits for various
    /// units types.This reusable type is used to define absolute
    /// minimums, maximums and differences for various units types.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AbsoluteLimitsByUnitType : ArrayBaseType<UserDefinedUnitValueType>
    {
        /// <remarks> The optional LinearLimit element defines the limit that a linear characteristic must achieve.</remarks>
        public LinearValueType? LinearLimit { get; set; }

        /// <remarks> The optional AngularLimit element defines the limit that an angular characteristic must achieve.</remarks>
        public AngularValueType? AngularLimit { get; set; }

        /// <remarks> The optional AreaLimit element defines the limit that an area characteristic must achieve.</remarks>
        public AreaValueType? AreaLimit { get; set; }

        /// <remarks> The optional ForceLimit element defines the limit that a force characteristic must achieve.</remarks>
        public ForceValueType? ForceLimit { get; set; }

        /// <remarks> The optional MassLimit element defines the limit that a mass characteristic must achieve.</remarks>
        public MassValueType? MassLimit { get; set; }

        /// <remarks> The optional PressureLimit element defines the limit that a pressure characteristic must achieve.</remarks>
        public PressureValueType? PressureLimit { get; set; }

        /// <remarks> The optional SpeedLimit element defines the limit that a speed characteristic must achieve.</remarks>
        public SpeedValueType? SpeedLimit { get; set; }

        /// <remarks> The optional TemperatureLimit element defines the limit that a temperature characteristic must achieve.</remarks>
        public TemperatureValueType? TemperatureLimit { get; set; }

        /// <remarks> The optional TimeLimit element defines the limit that a time characteristic must achieve.</remarks>
        public TimeValueType? TimeLimit { get; set; }

        /// <remarks> Each optional UserDefinedUnitLimit element defines the limit a
        /// device measuring a user-defined unit characteristic must
        /// achieve. This element is not to be used to define a limit with
        /// units available in another element.In particular this element
        /// is not to be used to define a limit with linear units, angular
        /// units, or units of temperature, area, force, mass, pressure, speed, or time.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitLimit")]
        public UserDefinedUnitValueType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
