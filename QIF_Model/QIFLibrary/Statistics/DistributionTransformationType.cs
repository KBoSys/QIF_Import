/*! \file DistributionTransformationType.cs
    \brief defines the distribution transformation

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The DistributionTransformationType defines the distribution transformation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DistributionTransformationType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BoxCoxTransformation", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("DistributionTransformationEnum", typeof(DistributionTransformationEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherDistributionTransformation", typeof(string))]
        public object Item { get; set; }
    }

    /// <remarks The DistributionTransformationEnumType enumerates values that
    /// describe a transformation applied to a raw statistical distribution./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DistributionTransformationEnumType
    {
        /// <remarks/>
        LOGNORMAL,

        /// <remarks/>
        BOUNDED,

        /// <remarks/>
        UNBOUNDED,
    }
}
