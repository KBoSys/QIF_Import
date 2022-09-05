/*! \file TokenExpressionBaseType.cs
    \brief defines the base type for token expressions.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks> The TokenExpressionBaseType defines the base type for token
    /// expressions. All derived types of TokenExpressionBaseType evaluate to an xs:token.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class TokenExpressionBaseType
    {
    }

    /// <remarks> The TokenParameterValueType defines a token expression that
    /// represents the value of a token parameter of a QIF object with a
    /// QIF id(e.g., the InternalExternal of a circle feature). If the
    /// identified object does not have the given parameter, the result is undefined.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TokenParameterValueType : TokenExpressionBaseType
    {
        /// <remarks> 
        /// The Parameter element is the xpath starting from the object
        /// (e.g., a feature or characteristic) and ending in name of
        /// the token parameter whose value is to be obtained -
        /// for example, InternalExternal of a circle.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string? Parameter { get; set; }

        /// <remarks> The ObjectId element identifies the object from which the parameter value is to be extracted.</remarks>
        public Primitives.QIFReferenceFullType? ObjectId { get; set; } = new Primitives.QIFReferenceFullType();
    }

    /// <remarks> The TokenConstantType defines an token (i.e., well-behaved string)
    /// constant.The value of a TokenConstant is the value of the val attribute.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TokenConstantType : TokenExpressionBaseType
    {
        /// <remarks> The required val attribute is a token constant.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("val", DataType = "token")]
        public string? Value { get; set; } = "";
    }
}
