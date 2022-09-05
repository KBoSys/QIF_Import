/*! \file DMESelectionRulesType.cs
    \brief The DMESelectionRulesType is a set of rules for deciding what DMEs to select or not select.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Expressions;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Visualization;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks> The DMESelectionRulesType is a set of rules for deciding what DMEs to select or not select.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMESelectionRulesType : ArrayBaseType<IfThenDMERuleType>
    {
        /// <remarks> Each DMEDecisionRule element is a rule constraining the selection of a DME.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DMEDecisionRule")]
        public IfThenDMERuleType[]? Items { get => base.itemsField; set => base.itemsField = value; }

        /// <remarks> The optional defaultDesirability attribute is the default value
        /// of the desirability of a DMEDecisionRule/DMEThen/DMEDecision/May
        /// in the range[0...1] to be used if no explicit desirability value
        /// is assigned in the 'May'. If no explicit value is provided for
        /// this element, its default value is 1.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("defaultDesirability")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double DefaultDesirability { get; set; } = 1D;
    }

    /// <remarks> The IfThenDMERuleType defines a rule containing an optional 'if'
    /// part and a required 'then' part.The 'then' part of the rule
    /// applies if the 'if' part does not exist or evaluates to true.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenDMERuleType : QIFRuleBaseType
    {
        /// <remarks> The optional BooleanExpression element is the 'if' part of the rule.</remarks>
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
        public BooleanExpressionBaseType? BooleanExpression { get; set; }

        /// <remarks> The DMEThen element is set of constraints on the decision about one or more DMEs.</remarks>
        public DMEThenType? DMEThen { get; set; }
    }

    /// <remarks> The DMEThenType is the 'then' part of a DME decision rule. 
    /// It contains requirements that particular types of DME or particular
    /// classes of DME may, must, or must not be used.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEThenType : ArrayBaseType<DMEDecisionBaseType>
    {
        /// <remarks> Each DMEDecision element indicates whether a particular DME or
        /// class of DME must be selected, must not be selected, or may be selected.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DMEDecisionClass", typeof(DMEDecisionClassType))]
        [System.Xml.Serialization.XmlElementAttribute("DMEDecisionId", typeof(DMEDecisionIdType))]
        [System.Xml.Serialization.XmlElementAttribute("DMEDecisionMakeModel", typeof(DMEDecisionMakeModelType))]
        public DMEDecisionBaseType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The DMEDecisionBaseType is the base type for making a decision on a DME.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DMEDecisionMakeModelType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DMEDecisionIdType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DMEDecisionClassType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class DMEDecisionBaseType
    {
        /// <remarks> The Applicability element indicates whether a DME must be selected, must not be selected, or may be selected.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Must", typeof(QIFMustType))]
        [System.Xml.Serialization.XmlElementAttribute("MustNot", typeof(QIFMustNotType))]
        [System.Xml.Serialization.XmlElementAttribute("May", typeof(QIFMayType))]
        public ApplicabilityBaseType? Applicability { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEDecisionMakeModelType : DMEDecisionBaseType
    {
        /// <remarks></remarks>
        public string? Manufacturer { get; set; }

        /// <remarks></remarks>
        public string? ModelNumber { get; set; }

        /// <remarks></remarks>
        public string? SerialNumber { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEDecisionIdType : DMEDecisionBaseType
    {
        /// <remarks></remarks>
        public QIFReferenceType? DMEId { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEDecisionClassType : DMEDecisionBaseType
    {
        /// <remarks></remarks>
        public DMEClassNameEnumType? DMEClassName { get; set; }

        /// <remarks></remarks>
        public DMEParameterConstraintSetType? ParameterConstraints { get; set; }
    }
}
