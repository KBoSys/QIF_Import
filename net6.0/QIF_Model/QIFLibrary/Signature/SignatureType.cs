/*! \file SignatureType.cs
    \brief Defines the Signature

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Signature
{
    /// <remarks> Defines the Signature</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SignatureType
    {
        /// <remarks></remarks>
        public SignedInfoType? SignedInfo { get; set; }

        /// <remarks></remarks>
        public SignatureValueType? SignatureValue { get; set; }

        /// <remarks></remarks>
        public KeyInfoType? KeyInfo { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Object")]
        public ObjectType[]? Object { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string? Id { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SignedInfoType
    {
        /// <remarks></remarks>
        public CanonicalizationMethodType? CanonicalizationMethod { get; set; }

        /// <remarks></remarks>
        public SignatureMethodType? SignatureMethod { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public ReferenceType[]? Reference { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string? Id { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SignatureValueType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string? Id { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[]? Value { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class KeyInfoType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("KeyName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("KeyValue", typeof(KeyValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MgmtData", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PGPData", typeof(PGPDataType))]
        [System.Xml.Serialization.XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType))]
        [System.Xml.Serialization.XmlElementAttribute("SPKIData", typeof(SPKIDataType))]
        [System.Xml.Serialization.XmlElementAttribute("X509Data", typeof(X509DataType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public KeyInfoItemsChoiceType[]? ItemsElementName { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[]? Text { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string? Id { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum KeyInfoItemsChoiceType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks></remarks>
        KeyName,

        /// <remarks></remarks>
        KeyValue,

        /// <remarks></remarks>
        MgmtData,

        /// <remarks></remarks>
        PGPData,

        /// <remarks></remarks>
        RetrievalMethod,

        /// <remarks></remarks>
        SPKIData,

        /// <remarks></remarks>
        X509Data,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ObjectType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[]? Any { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string? Id { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string? MimeType { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string? Encoding { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class KeyValueType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValueType))]
        [System.Xml.Serialization.XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValueType))]
        public object? Item { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[]? Text { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DSAKeyValueType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? P { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? Q { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? G { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? Y { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? J { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? Seed { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? PgenCounter { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class RSAKeyValueType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? Modulus { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? Exponent { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CanonicalizationMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[]? Any { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string? Algorithm { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SignatureMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? HMACOutputLength { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[]? Any { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string? Algorithm { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ReferenceType
    {
        /// <remarks></remarks>
        public DsTransformsType? Transforms { get; set; }

        /// <remarks></remarks>
        public DigestMethodType? DigestMethod { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[]? DigestValue { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string? Id { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string? URI { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string? Type { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PGPDataType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public PGPDataItemsChoiceType[]? ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum PGPDataItemsChoiceType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks></remarks>
        PGPKeyID,

        /// <remarks></remarks>
        PGPKeyPacket,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class RetrievalMethodType
    {
        /// <remarks></remarks>
        public DsTransformsType? Transforms { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string? URI { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string? Type { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DsTransformsType
    {
        /// <remarks></remarks>
        public DsTransformType? Transform { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DsTransformType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("XPath", typeof(string))]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[]? Text { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string? Algorithm { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SPKIDataType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType = "base64Binary")]
        public byte[][]? SPKISexp { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement? Any { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class X509DataType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("X509CRL", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType))]
        [System.Xml.Serialization.XmlElementAttribute("X509SKI", typeof(byte[]), DataType = "base64Binary")]
        [System.Xml.Serialization.XmlElementAttribute("X509SubjectName", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public X509DataItemsChoiceType[]? ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum X509DataItemsChoiceType
    {

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,

        /// <remarks></remarks>
        X509CRL,

        /// <remarks></remarks>
        X509Certificate,

        /// <remarks></remarks>
        X509IssuerSerial,

        /// <remarks></remarks>
        X509SKI,

        /// <remarks></remarks>
        X509SubjectName,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DigestMethodType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[]? Any { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string? Algorithm { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class X509IssuerSerialType
    {
        /// <remarks></remarks>
        public string? X509IssuerName { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? X509SerialNumber { get; set; }
    }
}
