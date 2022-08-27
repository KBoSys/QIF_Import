﻿/*! \file OrType.cs
    \brief defines an 'or' Boolean expression.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks>
    /// The OrType defines an 'or' Boolean expression. The OrType evaluates
    /// to true if any of the BooleanExpression elements it contains
    /// evaluate to true. Otherwise, it evaluates to false. The
    /// BooleanExpression elements must be evaluated in order.If any
    /// BooleanExpression element evaluates to true, the remaining
    /// BooleanExpression elements must not be evaluated.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OrType : BooleanExpressionBaseType
    {
        /// <remarks> Each Boolean Expression element is one of the Boolean expressions in the OrType expression.
        /// minOccurs="2"</remarks>
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
        public BooleanExpressionBaseType[] Expressions { get; set; }

        /// <remarks> The required n attribute is the number of boolean expressions in the OrType expression.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Expressions.Length;
            set { }
        }
    }
}
