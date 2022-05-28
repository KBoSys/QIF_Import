/*! \file NumberedPlanElementsType.cs
    \brief defines a set of numbered plan elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFPlan
{
	/// <remarks The NumberedPlanElementsType defines a set of numbered plan elements./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
	public partial class NumberedPlanElementsType
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("NumberedPlanElement")]
		public NumberedPlanElementType[] NumberedPlanElements { get; set; }

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute("n")]
		public uint Count
		{
			get => (uint)this.NumberedPlanElements.Length;
			set { }
		}
	}

    /// <remarks The NumberedPlanElementType defines a single ordered plan element./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class NumberedPlanElementType
    {
        /// <remarks The SequenceNumber element is a positive integer used in
        /// determining either the order within a set of PlanElements in
        /// which a plan element should be executed or which plan element
        /// in the set should be executed./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SequenceNumber { get; set; }

        /// <remarks The PlanElement element is the plan element associated with the SequenceNumber./>
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
        public PlanElementBaseType PlanElement { get; set; }
    }
}
