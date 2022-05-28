/*! \file WhileActionGroupType.cs
    \brief WhileActionGroupType represents a loop.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <remarks 
    /// The WhileActionGroupType represents a loop. 
    /// To execute a WhileActionGroupType, evaluate the BooleanExpression.
    /// If the BooleanExpression evaluates to true, execute the PlanElement.
    /// Repeat evaluating and executing as long as the BooleanExpression
    /// evaluates to true. The first time the BooleanExpression evaluates
    /// to false, return. If the BooleanExpression evaluates to false the
    /// first time it is evaluated, the PlanElement is never executed./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WhileActionGroupType : ActionGroupBaseType
    {
        /// <remarks/>
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

        /// <remarks/>
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
