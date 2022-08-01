/*! \file SamplingMethodType.cs
    \brief defines a method for sample selection.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The SamplingMethodType defines a method for sample selection./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SamplingMethodType
    {
        /// <remarks The SampleSize element specifies the number of samples x to be
        /// used in a statistical evaluation, the last x samples collected with be used in the calculation./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SampleSize { get; set; }

        /// <remarks 
        /// The SamplingPeriod element specifies the sampling period x, every xth part is measured.
        /// The SamplingFrequency element specifies the sampling frequency x, x parts are measured in each sampling interval.
        /// The SamplingInterval element specifies the sampling interval./>
        [System.Xml.Serialization.XmlElementAttribute("SamplingFrequency", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("SamplingInterval", typeof(SamplingIntervalType))]
        [System.Xml.Serialization.XmlElementAttribute("SamplingPeriod", typeof(uint))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("SamplingElementName")]
        public object[] Sampling { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SamplingElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SamplingChoiceType[] SamplingElementName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum SamplingChoiceType
    {

        /// <remarks/>
        SamplingFrequency,

        /// <remarks/>
        SamplingInterval,

        /// <remarks/>
        SamplingPeriod,
    }
}
