/*! \file StringValuesType.cs
    \brief defines a list of string values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <remarks> The StringValuesType defines a list of string values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class StringValuesType : ArrayBaseType<string>
    {
        /// <remarks> Each StringValue element is a string.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("StringValue")]
        public string[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
