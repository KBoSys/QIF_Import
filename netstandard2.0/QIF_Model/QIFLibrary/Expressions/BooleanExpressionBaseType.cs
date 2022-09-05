/*! \file BooleanExpressionBaseType.cs
    \brief WhileActionGroupType represents a loop.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks> The BooleanConstantEnumType enumerates values of the two
    /// Boolean constants. (The names are of these enumerated values are
    /// chosen to avoid conflicts with reserved words and macro definitions in common computer languages.)</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum BooleanConstantEnumType
    {
        QIF_TRUE,
        QIF_FALSE,
    }

    /// <remarks> The BooleanExpressionBaseType defines the base type for Boolean
    /// expressions.All derived types of BooleanExpressionBaseType evaluate to true or false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class BooleanExpressionBaseType
    {
    }

    /// <remarks>
    /// The ShapeClassIsType defines a Boolean expression representing a
    /// test of whether a part is in a given shape class. The
    /// ShapeClassIsType evaluates to true if the val is the primary shape
    /// class of the part containing the feature for which the number of
    /// points is being set.Otherwise, it evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ShapeClassIsType : BooleanExpressionBaseType
    {
        /// <remarks> The required val attribute is the shape class type against
        /// which to test the shape class of the part on which the feature is located.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("val")]
        public PrimitivesPMI.ShapeClassEnumType Value { get; set; }
    }

    /// <remarks>
    /// The FeatureTypeIsType defines a Boolean expression representing a
    /// test of whether a feature is of a given type.The FeatureTypeIsType
    /// evaluates to true if the val is the feature type of the feature for
    /// which a DME is being selected. Otherwise, it evaluates to false.
    /// The FeatureTypeIsType should not be used in boolean expressions in
    /// the FeatureRules of the QIFRulesType since those rules are already feature specific.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureTypeIsType : BooleanExpressionBaseType
    {
        /// <remarks> The required val attribute is the feature type against which to test the feature type of the feature.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("val")]
        public FeatureTypeEnumType Value { get; set; }
    }

    /// <remarks>
    /// The CharacteristicIsType defines a Boolean expression representing
    /// a test of whether a characteristic is of a given type.The
    /// CharacteristicIsType evaluates to true if the val is the
    /// characteristic type of the characteristic for which hit points are
    /// being selected or a DME is being selected. Otherwise, it evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CharacteristicIsType : BooleanExpressionBaseType
    {
        /// <remarks> The required val attribute is the characteristic type against which to test the characteristic type of the feature.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("val")]
        public CharacteristicTypeEnumType Value { get; set; }
    }

    /// <remarks> The FeatureIsInternalType defines a Boolean expression representing
    /// a test of whether a feature is internal. The FeatureIsInternalType
    /// evaluates to true if the feature for which hit points are being
    /// selected is an internal feature.Otherwise, it evaluates to false,
    /// which means either the feature is external or the feature is neither internal nor external.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureIsInternalType : BooleanExpressionBaseType
    {
    }

    /// <remarks> The FeatureIsDatumType defines a Boolean expression representing a
    /// test of whether a feature is a datum.The FeatureIsDatumType
    /// evaluates to true if the feature for which hit points are being
    /// selected is used as a datum. Otherwise, it evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureIsDatumType : BooleanExpressionBaseType
    {
    }

    /// <remarks> The SamplingCategoryIsType defines a Boolean expression
    /// representing a test of sampling category.The
    /// SamplingCategoryIsType evaluates to true if the val is the point
    /// level in the environment in which the SamplingCategoryIsType is
    /// evaluated.Otherwise, it evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SamplingCategoryIsType : BooleanExpressionBaseType
    {
        /// <remarks> The required val attribute is the value against which to
        /// test the sampling category in the environment.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("val")]
        public uint Value { get; set; }
    }

    /// <remarks> The TokenEqualType defines a test if the two TokenExpression
    /// elements are equal.The TokenEqualType evaluates to true if the two
    /// tokens are the same length and corresponding characters of the two tokens are the same.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TokenEqualType : BooleanExpressionBaseType
    {
        /// <remarks> Each TokenExpression element is one of two token expressions to be tested for equality.
        /// minOccurs="2";  maxOccurs="2" </remarks>
        [System.Xml.Serialization.XmlElementAttribute("TokenConstant", typeof(TokenConstantType))]
        [System.Xml.Serialization.XmlElementAttribute("TokenParameterValue", typeof(TokenParameterValueType))]
        public TokenExpressionBaseType[] TokenExpression { get; set; }
    }

    /// <remarks> The LessOrEqualType defines a test if the first
    /// ArithmeticExpression element is less than or equal to the second
    /// ArithmeticExpression element.The LessOrEqualType evaluates to true
    /// if the value of the first ArithmeticExpression element is less than
    /// the value of the second ArithmeticExpression element plus
    /// ComparisonTiny.Otherwise, it evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LessOrEqualType : ArithmeticComparisonBaseType
    {
    }

    /// <remarks> The LessThanType defines a test if the first ArithmeticExpression
    /// element is less than the second ArithmeticExpression element.The
    /// LessThanType evaluates to true if the value of the first
    /// ArithmeticExpression element is less than or equal to the value of
    /// the second ArithmeticExpression element minus ComparisonTiny. Otherwise, it evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LessThanType : ArithmeticComparisonBaseType
    {
    }

    /// <remarks> The GreaterOrEqualType defines a test if the first
    /// ArithmeticExpression element is greater than or equal to the second
    /// ArithmeticExpression element.The GreaterOrEqualType evaluates to
    /// true if the value of the first ArithmeticExpression element is
    /// greater than the value of the second ArithmeticExpression element
    /// minus ComparisonTiny.Otherwise, it evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class GreaterOrEqualType : ArithmeticComparisonBaseType
    {
    }

    /// <remarks> The GreaterThanType defines a test if the first
    /// ArithmeticExpression element is greater than the second
    /// ArithmeticExpression element.The GreaterThanType evaluates to true
    /// if the value of the first ArithmeticExpression element is greater
    /// than or equal to the value of the second ArithmeticExpression
    /// element plus ComparisonTiny. Otherwise, it evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class GreaterThanType : ArithmeticComparisonBaseType
    {
    }

    /// <remarks> The ArithmeticEqualType defines a test if the two
    /// ArithmeticExpression elements are equal.The ArithmeticEqualType
    /// evaluates to true if the first ArithmeticExpression element is (1)
    /// less than the second ArithmeticExpression element plus
    /// ComparisonTiny and(2) greater then the second ArithmeticExpression
    /// element minus ComparisonTiny.Otherwise, it evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticEqualType : ArithmeticComparisonBaseType
    {
    }

    /// <remarks> The ConstantIsType evaluates to true if the val is QIF_TRUE and evaluates to false if the val is QIF_FALSE.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConstantIsType : BooleanExpressionBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("val")]
        public BooleanConstantEnumType Value { get; set; }
    }

    /// <remarks> The BooleanEqualType defines a test of whether two Boolean
    /// expressions are the same.The BooleanEqualType evaluates to true if
    /// the two BooleanExpression elements both evaluate to true or both
    /// evaluate to false. Otherwise, the BooleanEqualType evaluates to false.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BooleanEqualType : BinaryBooleanExpressionBaseType
    {
    }
}
