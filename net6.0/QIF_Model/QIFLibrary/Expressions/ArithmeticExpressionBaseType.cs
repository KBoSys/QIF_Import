/*! \file ArithmeticExpressionBaseType.cs
    \brief base type for arithmetic expressions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ArithmeticComparisonEnumType
    {

        /// <remarks></remarks>
        EQUAL,

        /// <remarks></remarks>
        GREATER,

        /// <remarks></remarks>
        GREATEROREQUAL,

        /// <remarks></remarks>
        LESS,

        /// <remarks></remarks>
        LESSOREQUAL,
    }

    /// <remarks> The ArithmeticExpressionBaseType defines the base type for arithmetic expressions.
    /// All derived types of ArithmeticExpressionBaseType evaluate to an xs:decimal.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureSizeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureAreaType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureLengthType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CharacteristicToleranceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticParameterBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticPartParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticDMEParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticCharacteristicParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticFeatureParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticParameterValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VariableValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyadicArithmeticExpressionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MaxType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryArithmeticExpressionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DividedByType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticConstantType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ArithmeticExpressionBaseType
    {
    }

    /// <remarks>
    /// The FeatureSizeType defines an arithmetic expression representing
    /// the relevant linear size of a feature.The author of any set of
    /// rules that uses feature size should provide a definition of feature
    /// size for each combination of feature type and characteristic
    /// covered by the rules.For example, for a cylindrical hole, the
    /// feature size for a diameter characteristic might be the diameter,
    /// for a length characteristic might be the length, and for a
    /// cylindricity characteristic might be the maximum distance between
    /// any two points on the cylinder.The units for size are the length units used in the file.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureSizeType : ArithmeticExpressionBaseType
    {
    }

    /// <remarks> The FeatureAreaType defines an arithmetic expression representing
    /// the area of a feature.The FeatureAreaType evaluates to the area of
    /// the feature being processed.The units for area are the area units used in the file.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureAreaType : ArithmeticExpressionBaseType
    {
    }

    /// <remarks> The FeatureLengthType defines an arithmetic expression representing
    /// the length of a feature.The FeatureLengthType evaluates to the
    /// length of the feature being processed.The length of a curve is its
    /// curve length.The length of a surface is the largest distance
    /// between any two points on the surface.The units for length are the linear units used in the file.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureLengthType : ArithmeticExpressionBaseType
    {
    }

    /// <remarks> The CharacteristicToleranceType defines an arithmetic expression
    /// representing the tolerance range of a characteristic.The
    /// CharacteristicToleranceType evaluates to the difference between the MaxValue and MinValue given in the tolerance of the characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicToleranceType : ArithmeticExpressionBaseType
    {
    }

    /// <remarks>
    /// The ArithmeticParameterValueType defines an arithmetic expression
    /// that represents the value of an arithmetic parameter of a QIF
    /// object with a QIF id(e.g., the ToleranceValue of a geometric
    /// tolerance). If the identified object does not have the given
    /// parameter, the result is undefined.If a parameter value is given
    /// in units that are not the units in use, the evaluating system must
    /// convert to the units in use and use the converted value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticParameterValueType : ArithmeticExpressionBaseType
    {
        /// <remarks> The Parameter element is the xpath starting from the object
        /// (e.g., a feature or characteristic) and ending in name of
        /// the arithmetic parameter whose value is to be obtained --
        /// for example, Diameter for a Circle or Sweep/Angle for a
        /// Circular Arc.The type of the value of the parameter must
        /// be xs:decimal or the value must be convertible to
        /// xs:decimal without loss of accuracy.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string? Parameter { get; set; }

        /// <remarks> The ObjectId element identifies the object from which the
        /// parameter value is to be extracted.</remarks>
        public Primitives.QIFReferenceFullType? ObjectId { get; set; }
    }

    /// <remarks> The VariableValueType represents the value of a variable. The value
    /// of a VariableValueType is the value of the named variable at the
    /// time the variable is used(as in standard programming languages).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VariableValueType : ArithmeticExpressionBaseType
    {
        /// <remarks> The VariableName element is the name of a variable.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "IDREF")]
        public string? VariableName { get; set; }
    }

    /// <remarks> The NegateType defines an arithmetic operations that changes the
    /// sign of a number.The value of a NegateType is the negative of the
    /// value of the ArithmeticExpression element.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class NegateType : ArithmeticExpressionBaseType
    {
        /// <remarks> The ArithmeticExpression element is the expression whose value is negated.</remarks>
        public ArithmeticExpressionBaseType? ArithmeticExpression { get; set; }
    }

    /// <remarks> The ArithmeticConstantType defines an arithmetic constant.
    /// The value of an ArithmeticConstant is the value of the val attribute.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticConstantType : ArithmeticExpressionBaseType
    {
        /// <remarks> The required val attribute is an arithmetic constant.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("val")]
        public decimal Value { get; set; }
    }
}
