/*! \file LocalVariablesType.cs
    \brief a set of variable declarations

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFApplications.QIFPlan
{
    /// <remarks> The LocalVariablesType is a set of variable declarations. The variables are local to the plan.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LocalVariablesType
    {
        /// <remarks> Each Variable element declares a variable and sets its initial value.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Variable")]
        public VariableDeclarationType[] Variables { get; set; }

        /// <remarks> The required n attribute is the number of variables in the set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Variables.Length;
            set { }
        }
    }

    /// <remarks> The VariableDeclarationType represents declaring a numerical
    /// variable.Val is the initial value of the variable.The value may
    /// be reset using a VariableSetType.The value may be used using a VariableValueType.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VariableDeclarationType
    {
        /// <remarks> The Name element is the name of the variable.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "ID")]
        public string Name { get; set; }

        /// <remarks> The Val element is the value of the variable.</remarks>
        public decimal Val { get; set; }
    }
}
