/*! \file MultipleProductInstanceStudyPlanBaseType.cs
    \brief abstract base type that defines information common to all statistical studies involving multiple part measurements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Statistics;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks The MultipleProductInstanceStudyPlanBaseType is the abstract
    /// base type that defines information common to all statistical
    /// studies involving multiple part measurements./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductionStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CapabilityStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiasStudyPlanType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class MultipleProductInstanceStudyPlanBaseType : StatisticalStudyPlanBaseType
    {
        /// <remarks The NumberOfSamples element specifies the number of samples to be used in the statistical study./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfSamples { get; set; }

        /// <remarks The optional SubgroupSize element defines the size of each
        /// subgroup. The number of subgroups is determined by dividing
        /// the number of samples by the subgroup size.The subgroup
        /// size must be specified if control limits, Cp, Cpk or the
        /// estimated standard deviation are to be calculated./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SubgroupSize { get; set; }
    }

    /// <remarks The ProductionStudyPlanType defines information that is related to
    /// an ongoing production statistical study where samples are measured
    /// for statistical process control to ensure the ongoing stability or
    /// capability of a manufacturing process./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ProductionStudyPlanType : MultipleProductInstanceStudyPlanBaseType
    {
        /// <remarks The SamplingMethod element defines a method of sample selection./>
        public SamplingMethodType SamplingMethod { get; set; }

        /// <remarks The ControlMethods element defines a list of control
        /// methods to detect process instability or lack of capability./>
        public ControlMethodsType ControlMethods { get; set; }
    }

    /// <remarks The CapabilityStudyPlanType defines information that is related to
    /// a capability statistical study where a number of part samples are
    /// measured to establish the capability of a manufacturing process./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CapabilityStudyPlanType : MultipleProductInstanceStudyPlanBaseType
    {
        /// <remarks This compositor provides a choice between the two values
        /// used to determine process capability: Cpk or Ppk./>
        [System.Xml.Serialization.XmlElementAttribute("CpkThreshold", typeof(CriterionDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("PpkThreshold", typeof(CriterionDecimalType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ProcessCapabilityElementName")]
        public CriterionDecimalType ProcessCapability { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ProcessCapabilityChoiceType ProcessCapabilityElementName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ProcessCapabilityChoiceType
    {
        /// <remarks/>
        CpkThreshold,

        /// <remarks/>
        PpkThreshold,
    }

    /// <remarks The SimpleStudyPlanType defines information that is related to a
    /// simple statistical study where multiple samples are measured for
    /// the purpose of averaging features for process adjustment or reverse engineering./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SimpleStudyPlanType : MultipleProductInstanceStudyPlanBaseType
    {
    }

    /// <remarks The BiasStudyPlanType defines information that is related to a
    /// bias statistical study where the bias(measured value versus
    /// actual value) of a measurement system is determined./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BiasStudyPlanType : MultipleProductInstanceStudyPlanBaseType
    {
        /// <remarks The optional MeasurementDeviceIds element is a list of
        /// the ids of one or more measurement devices in the
        /// measurement system to be studied./>
        public ArrayReferenceType MeasurementDeviceIds { get; set; }
    }
}
