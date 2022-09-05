﻿/*! \file RunoutCharacteristicStatsEvalBaseType.cs
    \brief abstract base type that defines the results of a statistical evaluation of measured runout characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The RunoutCharacteristicStatsEvalBaseType is the abstract base type
    /// that defines the results of a statistical evaluation of measured runout characteristics.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalRunoutCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularRunoutCharacteristicStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class RunoutCharacteristicStatsEvalBaseType : GeometricCharacteristicStatsEvalType
    {
        /// <remarks> The optional CapabilityCalculationMethod element is the
        /// method used to calculate process capability for this one-sided tolerance.</remarks>
        public OneSidedCapabilityCalculationEnumType CapabilityCalculationMethod { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapabilityCalculationMethodSpecified { get; set; }

        /// <remarks> The optional DatumsOkStats element is the result of a statistical evaluation of DatumsOk flags.</remarks>
        public StatsPassFailType DatumsOkStats { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TotalRunoutCharacteristicStatsEvalType : RunoutCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularRunoutCharacteristicStatsEvalType : RunoutCharacteristicStatsEvalBaseType
    {
    }

}
