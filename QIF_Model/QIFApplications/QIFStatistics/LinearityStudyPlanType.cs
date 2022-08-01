/*! \file LinearityStudyPlanType.cs
    \brief 
        Defines information that is related to a linearity statistical study where an artifact or artifacts are
        measured to determine the linearity of a measurement system.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks The LinearityStudyPlanType defines information that is related to a
    /// linearity statistical study where an artifact or artifacts are
    /// measured to determine the linearity of a measurement system./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinearityStudyPlanType : StatisticalStudyPlanBaseType
    {
        /// <remarks The optional MeasurementDeviceIds element is a list of
        /// the ids of one or more measurement devices in the measurement system to be studied./>
        public ArrayReferenceType MeasurementDeviceIds { get; set; }

        /// <remarks The optional GoodnessOfFitThreshold element is the minimum
        /// goodness of fit(R-squared) that must be achieved for the measurement device to pass./>
        public decimal GoodnessOfFitThreshold { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GoodnessOfFitThresholdSpecified { get; set; }

        /// <remarks This compositor provides a choice between the two methods
        /// (absolute and relative) used to determine minimum allowed linearity./>
        [System.Xml.Serialization.XmlElementAttribute("AbsoluteMinimums", typeof(AbsoluteLimitsByUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeLinearityMinimum", typeof(decimal))]
        public object Method { get; set; }
    }
}
