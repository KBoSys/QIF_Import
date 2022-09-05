/*! \file DMEParameterConstraintSetType.cs
    \brief a set of constraints on parameters of the DME.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Expressions;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks> The DMEParameterConstraintSetType is a set of constraints on parameters of the DME.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEParameterConstraintSetType : ArrayBaseType<DMEParameterConstraintType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DMEParameterConstraint")]
        public DMEParameterConstraintType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The DMEParameterConstraintType is a constraint on a parameter of the DME being considered. 
    /// For a DME to satisfy the rule, the named parameter of the DME must satisfy the enumerated comparison with
    /// the evaluated arithmetic expression. The parameter name must be the name of a parameter of the class of DMEs named in the
    /// DMEDecisionClass in which the constraint is found.For example if the the DME class name is CALIPER, the parameter is
    /// LinearResolution, the comparison is LESS, and the arithmetic expression is 0.01, then the resolution of a caliper being
    /// considered must be less than(i.e., better than) 0.01.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEParameterConstraintType
    {
        /// <remarks> The ParameterName element is the xpath to a numerical-valued
        /// parameter of the class of DME being considered.
        /// For example if the class of DME is UNIVERSAL_DEVICE, the ParameterName could
        /// be CartesianWorkingVolume/XAxisLength, the value of which would
        /// be length of the X axis of the CartesianWorkingVolume of the
        /// instance of UniversalDeviceType being considered.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string? ParameterName { get; set; }

        /// <remarks> The Comparison element is the comparison to perform between
        /// the value of the named parameter of a DME and the value of the ComparedTo expression.</remarks>
        public ArithmeticComparisonEnumType Comparison { get; set; }

        /// <remarks> The ArithmeticExpression element is the expression whose value
        /// is to be compared to the value of the named parameter.</remarks>
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
        public ArithmeticExpressionBaseType? ArithmeticExpression { get; set; }
    }
}
