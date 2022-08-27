namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks></remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaxType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlusType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PolyadicArithmeticExpressionBaseType : ArithmeticExpressionBaseType
    {
        /// <remarks></remarks>
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
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticExpression")]
        public ArithmeticExpressionBaseType[] ArithmeticExpression { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TimesType : PolyadicArithmeticExpressionBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MinType : PolyadicArithmeticExpressionBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MaxType : PolyadicArithmeticExpressionBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlusType : PolyadicArithmeticExpressionBaseType
    {
    }

}
