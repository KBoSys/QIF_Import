/*! \file CorrectiveActionPlansType.cs
    \brief defines a list of corrective action plans.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Statistics;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks The CorrectiveActionPlansType defines a list of corrective action plans./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CorrectiveActionPlansType
    {
        /// <remarks Each CorrectiveActionPlan element defines a corrective action plan./>
        [System.Xml.Serialization.XmlElementAttribute("CorrectiveActionPlan")]
        public CorrectiveActionPlanType[] CorrectiveActionPlans { get; set; }

        /// <remarks The required n attribute is the number of corrective action plans in this list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.CorrectiveActionPlans.Length;
            set { }
        }
    }

    /// <remarks The CorrectiveActionPlanType defines a corrective action plan as lists of assignable causes and corrective actions./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CorrectiveActionPlanType
    {
        /// <remarks The optional Version element gives version information about the statistics./>
        public VersionType Version { get; set; }

        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks The AssignableCauses element defines one or more assignable causes./>
        public AssignableCausesType AssignableCauses { get; set; }

        /// <remarks The CorrectiveActions element defines one or more corrective actions./>
        public CorrectiveActionsType CorrectiveActions { get; set; }

        /// <remarks The QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The id attribute is the QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }
}
