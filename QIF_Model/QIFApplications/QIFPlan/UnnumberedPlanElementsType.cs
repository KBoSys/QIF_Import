/*! \file UnnumberedPlanElementsType.cs
    \brief defines a set of plan elements without sequence numbers.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <remarks The UnnumberedPlanElementsType defines a set of plan elements without sequence numbers./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UnnumberedPlanElementsType
    {
        /// <remarks Each PlanElement element is one member of the set of unnumbered plan elements./>
        [System.Xml.Serialization.XmlElementAttribute("OrderedActionGroup", typeof(OrderedActionGroupType))]
        [System.Xml.Serialization.XmlElementAttribute("UnorderedActionGroup", typeof(UnorderedActionGroupType))]
        [System.Xml.Serialization.XmlElementAttribute("PartiallyOrderedActionGroup", typeof(PartiallyOrderedActionGroupType))]
        [System.Xml.Serialization.XmlElementAttribute("OneOfActionGroup", typeof(OneOfActionGroupType))]
        [System.Xml.Serialization.XmlElementAttribute("PickSomeActionGroup", typeof(PickSomeActionGroupType))]
        [System.Xml.Serialization.XmlElementAttribute("MeasureEvaluateAll", typeof(MeasureEvaluateAllActionType))]
        [System.Xml.Serialization.XmlElementAttribute("MeasureEvaluateSpecified", typeof(MeasureEvaluateSpecifiedActionType))]
        [System.Xml.Serialization.XmlElementAttribute("EvaluateSpecifiedCharacteristics", typeof(EvaluateSpecifiedCharacteristicsActionType))]
        [System.Xml.Serialization.XmlElementAttribute("Halt", typeof(HaltActionType))]
        [System.Xml.Serialization.XmlElementAttribute("MeasureSpecifiedFeatures", typeof(MeasureSpecifiedFeaturesActionType))]
        [System.Xml.Serialization.XmlElementAttribute("MeasureSpecifiedMeasurands", typeof(MeasureSpecifiedMeasurandsActionType))]
        [System.Xml.Serialization.XmlElementAttribute("IfActionGroup", typeof(IfActionGroupType))]
        [System.Xml.Serialization.XmlElementAttribute("WhileActionGroup", typeof(WhileActionGroupType))]
        [System.Xml.Serialization.XmlElementAttribute("VariableSet", typeof(VariableSetType))]
        public PlanElementBaseType[] PlanElements { get; set; }

        /// <remarks The required n attribute is the number of plan elements in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.PlanElements.Length;
            set { }
        }
    }
}
