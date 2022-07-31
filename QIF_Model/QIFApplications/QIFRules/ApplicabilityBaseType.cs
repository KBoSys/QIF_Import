/*! \file ApplicabilityBaseType.cs
    \brief base class for types that describe whether a 'then' must apply, must not apply, or may apply.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks The ApplicabilityBaseType is the base class for types that describe whether a 'then' must apply, must not apply, or may apply./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QIFMayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QIFMustNotType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QIFMustType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ApplicabilityBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFMayType : ApplicabilityBaseType
    {

        private double desirabilityField;

        private bool desirabilityFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double desirability
        {
            get
            {
                return this.desirabilityField;
            }
            set
            {
                this.desirabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool desirabilitySpecified
        {
            get
            {
                return this.desirabilityFieldSpecified;
            }
            set
            {
                this.desirabilityFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFMustNotType : ApplicabilityBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class QIFMustType : ApplicabilityBaseType
    {
    }
}
