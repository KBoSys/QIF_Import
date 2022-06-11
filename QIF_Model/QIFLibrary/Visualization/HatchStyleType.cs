/*! \file HatchStyleType.cs
	\brief defines a hatch style.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPD;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Visualization
{
    /// <remarks The HatchStyleType defines a hatch style./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchStyleType : NodeWithIdBaseType
    {

        private HatchStyleFormEnumType formField;

        private string colorField;

        private HatchPatternsType patternsField;

        /// <remarks/>
        public HatchStyleFormEnumType Form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public HatchPatternsType Patterns
        {
            get
            {
                return this.patternsField;
            }
            set
            {
                this.patternsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum HatchStyleFormEnumType
    {

        /// <remarks/>
        NONE,

        /// <remarks/>
        PATTERN,

        /// <remarks/>
        FILL,

        /// <remarks/>
        ERASED,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchPatternsType
    {

        private HatchPatternType[] patternField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Pattern")]
        public HatchPatternType[] Pattern
        {
            get
            {
                return this.patternField;
            }
            set
            {
                this.patternField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HatchPatternType
    {

        private LineStyleType lineStyleField;

        private string firstLineOriginField;

        private string secondLineOriginField;

        private AngularValueType angleField;

        private string colorField;

        /// <remarks/>
        // CODEGEN Warning: DefaultValue attribute on members of type LineStyleType is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='SOLID' attribute.
        public LineStyleType LineStyle
        {
            get
            {
                return this.lineStyleField;
            }
            set
            {
                this.lineStyleField = value;
            }
        }

        /// <remarks/>
        public string FirstLineOrigin
        {
            get
            {
                return this.firstLineOriginField;
            }
            set
            {
                this.firstLineOriginField = value;
            }
        }

        /// <remarks/>
        public string SecondLineOrigin
        {
            get
            {
                return this.secondLineOriginField;
            }
            set
            {
                this.secondLineOriginField = value;
            }
        }

        /// <remarks/>
        public AngularValueType Angle
        {
            get
            {
                return this.angleField;
            }
            set
            {
                this.angleField = value;
            }
        }

        /// <remarks/>
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
    }
}
