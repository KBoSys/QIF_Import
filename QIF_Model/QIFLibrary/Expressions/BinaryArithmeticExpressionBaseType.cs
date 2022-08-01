namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DividedByType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MinusType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class BinaryArithmeticExpressionBaseType : ArithmeticExpressionBaseType
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
    public partial class DividedByType : BinaryArithmeticExpressionBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MinusType : BinaryArithmeticExpressionBaseType
    {
    }

}
