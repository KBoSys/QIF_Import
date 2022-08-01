/*! \file IfActionGroupType.cs
    \brief represents an If-ElseIf-Else construct with zero to many Else-Ifs and an optional Else.

        If is a test to evaluate and the plan element to execute if the
        test evaluates to true.
 
        Each optional ElseIf is a test to evaluate and the plan
        element to execute if the test evaluates to true.
 
        The optional ElseDo is a plan element to execute if none
        of the If or ElseIf tests evaluates to true.
 
        To execute an IfActionGroupType:
        1. Evaluate the test in the If. If it evaluates to true,
           execute the plan element in the If and return.
 
        2. Otherwise, evaluate the test in the next ElseIf if there is one.
           If it evaluates to true, execute the plan element in the ElseIf
           and return. Repeat until either return occurs or there are no
           more ElseIfs.
 
        3. Otherwise, if there is an ElseDo, execute the plan element
        in the ElseDo and return.
 
        4. Otherwise, return.
 
        It is possible that no plan element will be executed when an
        IfActionGroupType is executed.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Expressions;

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <remarks represents an If-ElseIf-Else construct with zero to many Else-Ifs and an optional Else./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfActionGroupType : ActionGroupBaseType
    {
        /// <remarks The If element is the first test and plan element./>
        public TestAndPlanElementType If { get; set; }

        /// <remarks Each optional ElseIf element is an additional test and plan element./>
        [System.Xml.Serialization.XmlElementAttribute("ElseIf")]
        public TestAndPlanElementType[] ElseIf { get; set; }

        /// <remarks The optional ElseDo element is a plan element to execute if the ElseDo is reached./>
        public ElseDoType ElseDo { get; set; }
    }

    /// <remarks The TestAndPlanElementType represents a test to evaluate and a plan element to execute if the test evaluates to true./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TestAndPlanElementType
    {
        /// <remarks The BooleanExpression element is a boolean expression to evaluate./>
        [System.Xml.Serialization.XmlElementAttribute("SamplingCategoryIs", typeof(SamplingCategoryIsType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureIsDatum", typeof(FeatureIsDatumType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureIsInternal", typeof(FeatureIsInternalType))]
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicIs", typeof(CharacteristicIsType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureTypeIs", typeof(FeatureTypeIsType))]
        [System.Xml.Serialization.XmlElementAttribute("ShapeClassIs", typeof(ShapeClassIsType))]
        [System.Xml.Serialization.XmlElementAttribute("Not", typeof(NotType))]
        [System.Xml.Serialization.XmlElementAttribute("And", typeof(AndType))]
        [System.Xml.Serialization.XmlElementAttribute("Or", typeof(OrType))]
        [System.Xml.Serialization.XmlElementAttribute("BooleanEqual", typeof(BooleanEqualType))]
        [System.Xml.Serialization.XmlElementAttribute("ConstantIs", typeof(ConstantIsType))]
        [System.Xml.Serialization.XmlElementAttribute("TokenEqual", typeof(TokenEqualType))]
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticEqual", typeof(ArithmeticEqualType))]
        [System.Xml.Serialization.XmlElementAttribute("GreaterThan", typeof(GreaterThanType))]
        [System.Xml.Serialization.XmlElementAttribute("GreaterOrEqual", typeof(GreaterOrEqualType))]
        [System.Xml.Serialization.XmlElementAttribute("LessThan", typeof(LessThanType))]
        [System.Xml.Serialization.XmlElementAttribute("LessOrEqual", typeof(LessOrEqualType))]
        public BooleanExpressionBaseType BooleanExpression { get; set; }

        /// <remarks The PlanElement element is the plan element to execute if the BooleanExpression evaluates to true./>
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

    /// <remarks The ElseDoType represents the 'Else' part of an If-ElseIf-Else construct./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ElseDoType
    {
        /// <remarks The PlanElement element is the plan element to execute./>
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
