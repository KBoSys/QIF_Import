/*! \file DMEParameterConstraintSetType.cs
    \brief a set of constraints on parameters of the DME.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks The DMEParameterConstraintSetType is a set of constraints on parameters of the DME./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEParameterConstraintSetType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DMEParameterConstraint")]
        public DMEParameterConstraintType[] DMEParameterConstraints { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.DMEParameterConstraints.Length;
            set { }
        }
    }

    /// <remarks The DMEParameterConstraintType is a constraint on a parameter of the DME being considered. 
    /// For a DME to satisfy the rule, the named parameter of the DME must satisfy the enumerated comparison with
    /// the evaluated arithmetic expression. The parameter name must be the name of a parameter of the class of DMEs named in the
    /// DMEDecisionClass in which the constraint is found.For example if the the DME class name is CALIPER, the parameter is
    /// LinearResolution, the comparison is LESS, and the arithmetic expression is 0.01, then the resolution of a caliper being
    /// considered must be less than(i.e., better than) 0.01./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DMEParameterConstraintType
    {
        /// <remarks The ParameterName element is the xpath to a numerical-valued
        /// parameter of the class of DME being considered.
        /// For example if the class of DME is UNIVERSAL_DEVICE, the ParameterName could
        /// be CartesianWorkingVolume/XAxisLength, the value of which would
        /// be length of the X axis of the CartesianWorkingVolume of the
        /// instance of UniversalDeviceType being considered./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string ParameterName { get; set; }

        /// <remarks The Comparison element is the comparison to perform between
        /// the value of the named parameter of a DME and the value of the ComparedTo expression./>
        public ArithmeticComparisonEnumType Comparison { get; set; }

        /// <remarks The ArithmeticExpression element is the expression whose value
        /// is to be compared to the value of the named parameter./>
        public ArithmeticExpressionBaseType ArithmeticExpression { get; set; }
    }
}
