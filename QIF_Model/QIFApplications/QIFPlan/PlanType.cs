/*! \file PlanType.cs
    \brief The PlanType defines information about a measurement plan.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Expressions;
using System.Xml.Serialization;

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <summary>
    /// The PlanType defines information about a measurement plan.
    /// </summary>
    public class PlanType
    {
        /// <remarks The optional Version element gives version information about the measurement plan./>
        [XmlElement()]
        public QIFLibrary.IntermediatesPMI.VersionType Version { get; set; }

        /// <remarks The optional RulesUsedQPId element gives the QPId of the rules
        /// that were used in creating the plan.The rules may be in the
        /// same QIFDocument as the plan, or in a separate QIFDocument, or
        /// both(in which case the two sets of rules must be identical)./>
        [XmlElement()]
        public QIFLibrary.Primitives.QPIdFullReferenceType RulesUsedQPId { get; set; }

        /// <remarks The optional RulesToUseQPId element gives the QPId of the rules
        /// to be used in making a more detailed plan from the plan or in
        /// generating a program from the plan(a DMIS program, for
        /// example). The rules may be in the same QIFDocument as the plan,
        /// or in a separate QIFDocument, or both(in which case the two sets of rules must be identical)./>
        [XmlElement()]
        public QIFLibrary.Primitives.QPIdFullReferenceType RulesToUseQPId { get; set; }

        /// <remarks The optional WorkInstructions element captures any instructions
        /// necessary for executing the Plan./>
        [XmlElement()]
        public WorkInstructionsType WorkInstructions { get; set; }

        /// <remarks The optional ActionMethods element captures any action methods
        /// necessary for executing the Plan./>
        [XmlElement()]
        public ActionMethodsType ActionMethods { get; set; }

        /// <remarks The optional Measurands element captures any measurands used in the Plan./>
        [XmlElement()]
        public MeasurandsType Measurands { get; set; }

        /// <remarks The optional LocalVariables element declares local variables and sets their initial values./>
        [XmlElement()]
        public LocalVariablesType LocalVariables { get; set; }

        /// <remarks The PlanRoot element gives information about the activities to
        /// be carried out in executing the measurement plan and how
        /// execution of the measurement plan is to be controlled.
        /// Structurally, the PlanRoot is at the top of an (upside down)
        /// plan tree of PlanElements. All PlanElement instances occur within the tree./>
        [XmlElement(ElementName = "OrderedPlanRoot", Type = typeof(OrderedActionGroupType))]
        [XmlElement(ElementName = "UnorderedPlanRoot", Type = typeof(UnorderedActionGroupType))]
        [XmlElement(ElementName = "PartiallyOrderedPlanRoot", Type = typeof(PartiallyOrderedActionGroupType))]
        [XmlElement(ElementName = "OneOfPlanRoot", Type = typeof(OneOfActionGroupType))]
        [XmlElement(ElementName = "PickSomePlanRoot", Type = typeof(PickSomeActionGroupType))]
        public ActionGroupBaseType PlanRoot { get; set; }
    }

    /// <remarks The PlanElementBaseType defines the abstract base type that defines
    /// plan element types.Plan elements are of two types: actions and action groups./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PlanElementBaseType
    {
        /// <remarks The optional WorkInstructionIds element gives the QIF ids of work instructions required to execute the plan element./>
        public QIFLibrary.Primitives.ArrayReferenceType WorkInstructionIds { get; set; }

        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public QIFLibrary.Primitives.AttributesType Attributes { get; set; }
    }

    /// <remarks The VariableSetType represents the setting of a variable./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VariableSetType : PlanElementBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string VariableName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticFeatureParameter", typeof(ArithmeticFeatureParameterType))]
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticCharacteristicParameter", typeof(ArithmeticCharacteristicParameterType))]
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticDMEParameter", typeof(ArithmeticDMEParameterType))]
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticPartParameter", typeof(ArithmeticPartParameterType))]
        [System.Xml.Serialization.XmlElementAttribute("CharacteristicTolerance", typeof(CharacteristicToleranceType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureLength", typeof(FeatureLengthType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureArea", typeof(FeatureAreaType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureSize", typeof(FeatureSizeType))]
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticConstant", typeof(ArithmeticConstantType))]
        [System.Xml.Serialization.XmlElementAttribute("Plus", typeof(PlusType))]
        [System.Xml.Serialization.XmlElementAttribute("Max", typeof(MaxType))]
        [System.Xml.Serialization.XmlElementAttribute("Min", typeof(MinType))]
        [System.Xml.Serialization.XmlElementAttribute("Minus", typeof(MinusType))]
        [System.Xml.Serialization.XmlElementAttribute("Negate", typeof(NegateType))]
        [System.Xml.Serialization.XmlElementAttribute("Times", typeof(TimesType))]
        [System.Xml.Serialization.XmlElementAttribute("DividedBy", typeof(DividedByType))]
        [System.Xml.Serialization.XmlElementAttribute("VariableValue", typeof(VariableValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticParameterValue", typeof(ArithmeticParameterValueType))]
        public QIFLibrary.Expressions.ArithmeticExpressionBaseType ArithmeticExpression { get; set; }
    }
}
