/*! \file StringValuesType.cs
    \brief defines a list of string values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics
{
    /// <remarks The StringValuesType defines a list of string values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class StringValuesType
    {
        /// <remarks Each StringValue element is a string./>
        [System.Xml.Serialization.XmlElementAttribute("StringValue")]
        public string[] StringValues { get; set; }

        /// <remarks The required n attribute is the number of strings in this list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count 
        { 
            get => (uint)this.StringValues.Length; 
            set {}
        }
    }
}
