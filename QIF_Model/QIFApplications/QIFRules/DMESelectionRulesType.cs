/*! \file DMESelectionRulesType.cs
    \brief The DMESelectionRulesType is a set of rules for deciding what DMEs to select or not select.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Expressions;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks The DMESelectionRulesType is a set of rules for deciding what DMEs to select or not select./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMESelectionRulesType
    {
        /// <remarks Each DMEDecisionRule element is a rule constraining the selection of a DME./>
        [System.Xml.Serialization.XmlElementAttribute("DMEDecisionRule")]
        public IfThenDMERuleType[] DMEDecisionRules { get; set; }

        /// <remarks The optional defaultDesirability attribute is the default value
        /// of the desirability of a DMEDecisionRule/DMEThen/DMEDecision/May
        /// in the range[0...1] to be used if no explicit desirability value
        /// is assigned in the 'May'. If no explicit value is provided for
        /// this element, its default value is 1./>
        [System.Xml.Serialization.XmlAttributeAttribute("defaultDesirability")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double DefaultDesirability { get; set; } = 1D;

        /// <remarks The required n attribute is the number of rules in the set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Cont
        {
            get => (uint)this.DMEDecisionRules.Length;
            set { }
        }
    }

    /// <remarks The IfThenDMERuleType defines a rule containing an optional 'if'
    /// part and a required 'then' part.The 'then' part of the rule
    /// applies if the 'if' part does not exist or evaluates to true./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class IfThenDMERuleType : QIFRuleBaseType
    {
        /// <remarks The optional BooleanExpression element is the 'if' part of the rule./>
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

        /// <remarks The DMEThen element is set of constraints on the decision about one or more DMEs./>
        public DMEThenType DMEThen { get; set; }
    }

    /// <remarks The DMEThenType is the 'then' part of a DME decision rule. 
    /// It contains requirements that particular types of DME or particular
    /// classes of DME may, must, or must not be used./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEThenType
    {
        /// <remarks Each DMEDecision element indicates whether a particular DME or
        /// class of DME must be selected, must not be selected, or may be selected./>
        [System.Xml.Serialization.XmlElementAttribute("DMEDecisionClass", typeof(DMEDecisionClassType))]
        [System.Xml.Serialization.XmlElementAttribute("DMEDecisionId", typeof(DMEDecisionIdType))]
        [System.Xml.Serialization.XmlElementAttribute("DMEDecisionMakeModel", typeof(DMEDecisionMakeModelType))]
        public DMEDecisionBaseType[] DMEDecisions { get; set; }

        /// <remarks The required n attribute is the number of DMEDecisions./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.DMEDecisions.Length;
            set { }
        }
    }

    /// <remarks The DMEDecisionBaseType is the base type for making a decision on a DME./>
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
        /// <remarks The Applicability element indicates whether a DME must be selected, must not be selected, or may be selected./>
        [System.Xml.Serialization.XmlElementAttribute("Must", typeof(QIFMustType))]
        [System.Xml.Serialization.XmlElementAttribute("MustNot", typeof(QIFMustNotType))]
        [System.Xml.Serialization.XmlElementAttribute("May", typeof(QIFMayType))]
        public ApplicabilityBaseType Applicability { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEDecisionMakeModelType : DMEDecisionBaseType
    {

        private string manufacturerField;

        private string modelNumberField;

        private string serialNumberField;

        /// <remarks/>
        public string Manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        public string ModelNumber
        {
            get
            {
                return this.modelNumberField;
            }
            set
            {
                this.modelNumberField = value;
            }
        }

        /// <remarks/>
        public string SerialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEDecisionIdType : DMEDecisionBaseType
    {

        private QIFReferenceType dMEIdField;

        /// <remarks/>
        public QIFReferenceType DMEId
        {
            get
            {
                return this.dMEIdField;
            }
            set
            {
                this.dMEIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEDecisionClassType : DMEDecisionBaseType
    {

        private DMEClassNameEnumType dMEClassNameField;

        private DMEParameterConstraintSetType parameterConstraintsField;

        /// <remarks/>
        public DMEClassNameEnumType DMEClassName
        {
            get
            {
                return this.dMEClassNameField;
            }
            set
            {
                this.dMEClassNameField = value;
            }
        }

        /// <remarks/>
        public DMEParameterConstraintSetType ParameterConstraints
        {
            get
            {
                return this.parameterConstraintsField;
            }
            set
            {
                this.parameterConstraintsField = value;
            }
        }
    }
}
