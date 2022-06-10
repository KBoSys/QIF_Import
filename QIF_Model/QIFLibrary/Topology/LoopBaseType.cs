using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopMeshType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class LoopBaseType : TopologyBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LoopMeshType : LoopBaseType
    {

        private CoEdgesMeshType coEdgesMeshField;

        /// <remarks/>
        public CoEdgesMeshType CoEdgesMesh
        {
            get
            {
                return this.coEdgesMeshField;
            }
            set
            {
                this.coEdgesMeshField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoEdgesMeshType
    {

        private CoEdgeMeshType[] coEdgeMeshField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoEdgeMesh")]
        public CoEdgeMeshType[] CoEdgeMesh
        {
            get
            {
                return this.coEdgeMeshField;
            }
            set
            {
                this.coEdgeMeshField = value;
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
    public partial class CoEdgeMeshType
    {

        private EdgeOrientedType edgeOrientedField;

        private ElementReferenceType curveMeshField;

        /// <remarks/>
        public EdgeOrientedType EdgeOriented
        {
            get
            {
                return this.edgeOrientedField;
            }
            set
            {
                this.edgeOrientedField = value;
            }
        }

        /// <remarks/>
        public ElementReferenceType CurveMesh
        {
            get
            {
                return this.curveMeshField;
            }
            set
            {
                this.curveMeshField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LoopType : LoopBaseType
    {

        private CoEdgesType coEdgesField;

        private LoopFormEnumType formField;

        public LoopType()
        {
            this.formField = LoopFormEnumType.UNKNOWN;
        }

        /// <remarks/>
        public CoEdgesType CoEdges
        {
            get
            {
                return this.coEdgesField;
            }
            set
            {
                this.coEdgesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LoopFormEnumType.UNKNOWN)]
        public LoopFormEnumType form
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoEdgesType
    {

        private CoEdgeType[] coEdgeField;

        private uint nField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoEdge")]
        public CoEdgeType[] CoEdge
        {
            get
            {
                return this.coEdgeField;
            }
            set
            {
                this.coEdgeField = value;
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
    public partial class CoEdgeType
    {

        private EdgeOrientedType edgeOrientedField;

        private ElementReferenceType curve12Field;

        /// <remarks/>
        public EdgeOrientedType EdgeOriented
        {
            get
            {
                return this.edgeOrientedField;
            }
            set
            {
                this.edgeOrientedField = value;
            }
        }

        /// <remarks/>
        public ElementReferenceType Curve12
        {
            get
            {
                return this.curve12Field;
            }
            set
            {
                this.curve12Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LoopFormEnumType
    {

        /// <remarks/>
        UNKNOWN,

        /// <remarks/>
        OUTER,

        /// <remarks/>
        INNER,

        /// <remarks/>
        SLIT,

        /// <remarks/>
        VERTEX,
    }

}
