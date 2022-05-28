using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks/>
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

        private ArithmeticExpressionBaseType[] arithmeticExpressionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArithmeticExpression")]
        public ArithmeticExpressionBaseType[] ArithmeticExpression
        {
            get
            {
                return this.arithmeticExpressionField;
            }
            set
            {
                this.arithmeticExpressionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TimesType : PolyadicArithmeticExpressionBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MinType : PolyadicArithmeticExpressionBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MaxType : PolyadicArithmeticExpressionBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlusType : PolyadicArithmeticExpressionBaseType
    {
    }

}
