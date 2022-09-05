/*! \file FirstArticleStudyPlanType.cs
    \brief 
            Defines information that is related to a first article statistical study where the number
            and severity of non-conforming characteristics determines product acceptance.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks> The FirstArticleStudyPlanType defines information that is
    /// related to a first article statistical study where the number
    /// and severity of non-conforming characteristics determines product acceptance.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FirstArticleStudyPlanType : StatisticalStudyPlanBaseType
    {
        /// <remarks> The InSpecRatio element specifies the fraction of inspected
        /// characteristics which must be within specification limits for the product to pass expressed as a number between 0 and 1.</remarks>
        public decimal InSpecRatio { get; set; }

        /// <remarks> This compositor provides a choice between the two methods
        /// (absolute and relative) used to determine maximum allowed deviation.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AbsoluteMaximums", typeof(AbsoluteLimitsByUnitType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeMaximum", typeof(decimal))]
        public object? Method { get; set; }
    }
}
