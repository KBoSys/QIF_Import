﻿/*! \file CorrectiveActionPlansType.cs
    \brief defines a list of corrective action plans.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Statistics;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks> The CorrectiveActionPlansType defines a list of corrective action plans.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CorrectiveActionPlansType : ArrayBaseType<CorrectiveActionPlanType>
    {
        /// <remarks> Each CorrectiveActionPlan element defines a corrective action plan.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CorrectiveActionPlan")]
        public CorrectiveActionPlanType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The CorrectiveActionPlanType defines a corrective action plan as lists of assignable causes and corrective actions.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CorrectiveActionPlanType
    {
        /// <remarks> The optional Version element gives version information about the statistics.</remarks>
        public VersionType Version { get; set; }

        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }

        /// <remarks> The AssignableCauses element defines one or more assignable causes.</remarks>
        public AssignableCausesType AssignableCauses { get; set; }

        /// <remarks> The CorrectiveActions element defines one or more corrective actions.</remarks>
        public CorrectiveActionsType CorrectiveActions { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }
}
