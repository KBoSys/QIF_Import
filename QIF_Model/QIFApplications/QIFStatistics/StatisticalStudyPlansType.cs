/*! \file StatisticalStudyPlansType.cs
    \brief defines a list of statistical study plans.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks The StatisticalStudyPlansType defines a list of statistical study plans./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatisticalStudyPlansType
    {
        /// <remarks Each StatisticalStudyPlan element gives information about a statistical study plan./>
        [System.Xml.Serialization.XmlElementAttribute("FirstArticleStudyPlan", typeof(FirstArticleStudyPlanType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearityStudyPlan", typeof(LinearityStudyPlanType))]
        [System.Xml.Serialization.XmlElementAttribute("SimpleStudyPlan", typeof(SimpleStudyPlanType))]
        [System.Xml.Serialization.XmlElementAttribute("BiasStudyPlan", typeof(BiasStudyPlanType))]
        [System.Xml.Serialization.XmlElementAttribute("StabilityStudyPlan", typeof(StabilityStudyPlanType))]
        [System.Xml.Serialization.XmlElementAttribute("ProcessDifferenceStudyPlan", typeof(ProcessDifferenceStudyPlanType))]
        [System.Xml.Serialization.XmlElementAttribute("CapabilityStudyPlan", typeof(CapabilityStudyPlanType))]
        [System.Xml.Serialization.XmlElementAttribute("GageRandRStudyPlan", typeof(GageRandRStudyPlanType))]
        [System.Xml.Serialization.XmlElementAttribute("ProductionStudyPlan", typeof(ProductionStudyPlanType))]
        public StatisticalStudyPlanBaseType[] Items { get; set; }

        /// <remarks The required n attribute is the number of statistical study plans in this list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }
}
