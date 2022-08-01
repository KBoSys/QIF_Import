/*! \file ArrayBinaryType.cs
	\brief represents an array of Base64-encoded binary elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <summary>
    /// The ArrayBinaryType represents an array of Base64-encoded binary elements. 
    /// For base64Binary data the entire binary stream is encoded using the Base64 Alphabet in RFC 2045.
    /// </summary>
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArrayBinaryType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value { get; set; }

        /// <remarks The required count attribute is the number of elements in this array./>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public uint Count { get; set; }

        /// <remarks The required sizeElement attribute shows the size (in bytes)
        /// of one element stored in the array.The total size of the
        /// binary array can be calculated as: count* sizeElement./>
        [System.Xml.Serialization.XmlAttributeAttribute("sizeElement")]
        public uint SizeElement { get; set; }
    }
}
