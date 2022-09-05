/*! \file StatisticsType.cs
    \brief defines the container element that holds all statistical plan and/or results.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks> The StatisticsType defines the container element that holds all statistical plan and/or results.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatisticsType
    {
        /// <remarks> The optional StatisticalStudyPlans element defines one or more statistical study plans.</remarks>
        public StatisticalStudyPlansType? StatisticalStudyPlans { get; set; }

        /// <remarks> The optional StatisticalStudiesResults element defines one or more statistical study results.</remarks>
        public StatisticalStudiesResultsType? StatisticalStudiesResults { get; set; }

        /// <remarks> The optional CorrectiveActionPlans element defines one or more corrective action plans.</remarks>
        public CorrectiveActionPlansType? CorrectiveActionPlans { get; set; }
    }
}
