/*! \file ArithmeticComparisonBaseType.cs
    \brief defines the base type for arithmetic comparisons.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks 
    /// The ArithmeticComparisonBaseType defines the base type for
    /// arithmetic comparisons. The evaluation environment for
    /// arithmetic comparisons must include the arithmetic constant, ComparisonTiny./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LessOrEqualType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LessThanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GreaterOrEqualType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GreaterThanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticEqualType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ArithmeticComparisonBaseType : BooleanExpressionBaseType
    {
        /// <remarks Each ArithmeticExpression element is one two arithmetic expressions to be compared./>
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
        public ArithmeticExpressionBaseType[] Expressions { get; set; }
    }
}
