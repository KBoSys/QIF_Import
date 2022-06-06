﻿/*! \file StatsBaseType.cs
    \brief abstract base type that defines various results of statistical evaluations common to numerical and non- numerical characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The StatsBaseType is the abstract base type that defines various
    /// results of statistical evaluations common to numerical and non- numerical characteristics./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsPassFailType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class StatsBaseType
    {
        /// <remarks/>
        public AttributesType Attributes { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TotalNumber", typeof(StatsNonNegativeIntegerType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupTotalNumbers", typeof(SubgroupIntegersType))]
        [System.Xml.Serialization.XmlElementAttribute("EffectiveNumber", typeof(StatsNonNegativeIntegerType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupEffectiveNumbers", typeof(SubgroupIntegersType))]
        [System.Xml.Serialization.XmlElementAttribute("NumberSubgroups", typeof(StatsNonNegativeIntegerType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public StatsWithReferenceBaseType[] CommonStatsValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceTypeCommonStatsValue[] ItemElementName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ItemChoiceTypeCommonStatsValue
    {
        /// <remarks/>
        TotalNumber,

        /// <remarks/>
        SubgroupTotalNumbers,

        /// <remarks/>
        EffectiveNumber,

        /// <remarks/>
        SubgroupEffectiveNumbers,

        /// <remarks/>
        NumberSubgroups,
    }

    /// <remarks The StatsPassFailType defines various results of statistical
    /// evaluations involving pass/fail conditions rather than numerical    values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsPassFailType : StatsBaseType
    {
        /// <remarks Each PassFailStatsValue element is a statistical value for a pass-fail characteristic./>
        [System.Xml.Serialization.XmlElementAttribute("FailurePercentage", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("NumberFailures", typeof(StatsNonNegativeIntegerType))]
        public StatsWithReferenceBaseType[] PassFailStatsValue { get; set; }
    }

}