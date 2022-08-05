/*! \file FunctionDiscreteType.cs
	\brief Describes a mathematical function whose domain and range are arrays of double values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Primitives
{
    /// <remarks The FunctionDiscreteType describes a mathematical function whose domain and range are arrays of double values.
    /// The function is represented by matching pairs of values from the domain and range./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleFunctionDiscreteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthFunctionDiscreteType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FunctionDiscreteType
    {
        /// <remarks The DomainValues element gives the values in the domain./>
        public ListDoubleTypeBase DomainValues { get; set; }

        /// <remarks The RangeValues element gives the values in the range./>
        public ListDoubleTypeBase RangeValues { get; set; }

        /// <remarks The required n attribute gives the number of values in the domain and range./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => DomainValues != null && DomainValues.Value != null ? (uint)this.DomainValues.Value.Length : 0;
            set { }
        }
    }

    /// <remarks The AngleFunctionDiscreteType describes a discrete function
    /// whose domain is an array of values representing distances and
    /// whose range is an array of values representing angles./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngleFunctionDiscreteType : FunctionDiscreteType
    {
        /// <remarks The DomainLinearUnit element gives the name of the linear unit for the domain.
        /// This must be the name of a defined linear unit./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string DomainLinearUnit { get; set; }

        /// <remarks The RangeAngularUnit element gives the name of the angular unit for the range.
        /// This must be the name of a defined angular unit./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string RangeAngularUnit { get; set; }
    }

    /// <remarks The LengthFunctionDiscreteType describes a discrete function
    /// whose domain is an array of values representing distances and
    /// whose range is an array of values representing distances./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LengthFunctionDiscreteType : FunctionDiscreteType
    {
        /// <remarks The DomainLinearUnit element gives the name of the linear unit for the domain.
        /// This must be the name of a defined linear unit./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string DomainLinearUnit { get; set; }

        /// <remarks The RangeLinearUnit element gives the name of the linear unit for the range.
        /// This must be the name of a defined linear unit./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string RangeLinearUnit { get; set; }
    }
}
