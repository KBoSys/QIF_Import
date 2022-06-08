/*! \file StabilityStudyPlanType.cs
    \brief 
        Defines information that is related to a stability statistical study where the same part or artifact is
        measured over time to assess the stability of a measurement system.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks The StabilityStudyPlanType defines information that is related to a
    /// stability statistical study where the same part or artifact is
    /// measured over time to assess the stability of a measurement system./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StabilityStudyPlanType : StatisticalStudyPlanBaseType
    {
        /// <remarks The optional MeasurementDeviceIds element is a list of
        /// the ids of one or more measurement devices in the
        /// measurement system to be studied./>
        public ArrayReferenceType MeasurementDeviceIds { get; set; }

        /// <remarks The SampleSize element specifies the number of samples to be used in the statistical study./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SampleSize { get; set; }

        /// <remarks The SampleFrequency element specifies the sampling
        /// frequency n, n parts are measured in each sampling interval./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SampleFrequency { get; set; }

        /// <remarks The SamplingInterval element specifies the sampling interval./>
        public QIFLibrary.Statistics.SamplingIntervalType SamplingInterval { get; set; }
    }
}
