﻿/*! \file StatisticalStudiesResultsType.cs
    \brief defines a list of statistical study results.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks> The StatisticalStudiesResultsType defines a list of statistical study results.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatisticalStudiesResultsType : ArrayBaseType<StatisticalStudyResultsBaseType>
    {
        /// <remarks></remarks>
        // MANEDIT [System.Xml.Serialization.XmlElementAttribute("StatisticalStudyResults")] replace with substitutions to base class
        [System.Xml.Serialization.XmlElementAttribute("FirstArticleStudyResults", typeof(FirstArticleStudyResultsType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearityStudyResults", typeof(LinearityStudyResultsType))]
        [System.Xml.Serialization.XmlElementAttribute("SimpleStudyResults", typeof(SimpleStudyResultsType))]
        [System.Xml.Serialization.XmlElementAttribute("BiasStudyResults", typeof(BiasStudyResultsType))]
        [System.Xml.Serialization.XmlElementAttribute("StabilityStudyResults", typeof(StabilityStudyResultsType))]
        [System.Xml.Serialization.XmlElementAttribute("CapabilityStudyResults", typeof(CapabilityStudyResultsType))]
        [System.Xml.Serialization.XmlElementAttribute("ProcessDifferenceStudyResults", typeof(ProcessDifferenceStudyResultsType))]
        [System.Xml.Serialization.XmlElementAttribute("GageRandRStudyResults", typeof(GageRandRStudyResultsType))]
        [System.Xml.Serialization.XmlElementAttribute("ProductionStudyResults", typeof(ProductionStudyResultsType))]
        public StatisticalStudyResultsBaseType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
