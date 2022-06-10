using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPD
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuxiliaryPlaneBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneReferenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineAuxiliaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointAuxiliaryType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class AuxiliaryBaseType : DrawableBaseType
    {
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlaneReferenceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class AuxiliaryPlaneBaseType : AuxiliaryBaseType
    {

        private PlaneType planeField;

        /// <remarks/>
        public PlaneType Plane
        {
            get
            {
                return this.planeField;
            }
            set
            {
                this.planeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PlaneReferenceType : AuxiliaryPlaneBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineAuxiliaryType : AuxiliaryBaseType
    {

        private string startPointField;

        private string endPointField;

        private LineStyleType lineStyleField;

        /// <remarks/>
        public string StartPoint
        {
            get
            {
                return this.startPointField;
            }
            set
            {
                this.startPointField = value;
            }
        }

        /// <remarks/>
        public string EndPoint
        {
            get
            {
                return this.endPointField;
            }
            set
            {
                this.endPointField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointAuxiliaryType : AuxiliaryBaseType
    {

        private PointType xYZField;

        /// <remarks/>
        public PointType XYZ
        {
            get
            {
                return this.xYZField;
            }
            set
            {
                this.xYZField = value;
            }
        }
    }

}
