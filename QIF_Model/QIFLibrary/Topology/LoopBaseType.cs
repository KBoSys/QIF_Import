/*! \file LoopBaseType.cs
    \brief abstract base type for loops.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The LoopBaseType is the abstract base type for loops. 
    /// A loop represents a circuit of edges bounding a face.</remarks>
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

    /// <remarks> The LoopMeshType is the b-rep mesh loop type - a topological entity.It is a circuit of edges bounding a face.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LoopMeshType : LoopBaseType
    {
        /// <remarks> The CoEdgesMesh is an array of mesh co-edges that forms mesh loop.</remarks>
        public CoEdgesMeshType CoEdgesMesh { get; set; }
    }

    /// <remarks> The CoEdgesMeshType is an array of mesh co-edges.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoEdgesMeshType
    {
        /// <remarks> Each CoEdgeMesh element is a mesh co-edge.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CoEdgeMesh")]
        public CoEdgeMeshType[] Items { get; set; }

        /// <remarks> The required n attribute is the number of mesh co-edges in this array.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks> The CoEdgeMeshType represents the part of mesh face trimming loop.
    /// A mesh co-edge defines a mesh curve(i.e.the projection of an
    /// underlying 3D Curve of an oriented Edge onto an underlying mesh surface of a mesh face).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoEdgeMeshType
    {
        /// <remarks> The EdgeOriented element is a reference to edge with a given orientation.</remarks>
        public EdgeOrientedType EdgeOriented { get; set; }

        /// <remarks> The optional CurveMesh element is a reference to mesh curve.
        /// This is projection of underlying 3D Curve of an oriented Edge onto an underlying mesh surface of a mesh face.</remarks>
        public ElementReferenceType CurveMesh { get; set; }
    }

    /// <remarks> The LoopType is the b-rep parametric loop type - a topological entity.
    /// It is a circuit of edges bounding a face.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LoopType : LoopBaseType
    {
        /// <remarks> The CoEdges is an array of co-edges that forms loop.</remarks>
        public CoEdgesType CoEdges { get; set; }

        /// <remarks> The optional form attribute specifies the loop type which can
        /// take one of the following values: 'UNKNOWN', 'OUTER', 'INNER' or 'SLIT'.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        [System.ComponentModel.DefaultValueAttribute(LoopFormEnumType.UNKNOWN)]
        public LoopFormEnumType Form { get; set; } = LoopFormEnumType.UNKNOWN;
    }

    /// <remarks> The CoEdgesType is an array of co-edges.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoEdgesType
    {
        /// <remarks> Each CoEdge element is a co-edge.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CoEdge")]
        public CoEdgeType[] Items { get; set; }

        /// <remarks> The required n attribute is the number of mesh co-edges in this array.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks> The CoEdgeType represents the part of face trimming loop. A
    /// co-edge defines a parameter space curve(i.e.the projection
    /// of an underlying 3D Curve of an oriented Edge onto an underlying surface of a face).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoEdgeType
    {
        /// <remarks> The EdgeOriented element is a reference to edge with a given orientation.</remarks>
        public EdgeOrientedType EdgeOriented { get; set; }

        /// <remarks> The optional Curve12 element is a reference to 2D curve.
        /// This is projection of underlying 3D Curve of an oriented Edge onto an underlying surface of a face.</remarks>
        public ElementReferenceType Curve12 { get; set; }
    }

    /// <remarks> The LoopBaseTypeType enumerates values that describe the loop type.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LoopFormEnumType
    {
        /// <remarks></remarks>
        UNKNOWN,

        /// <remarks></remarks>
        OUTER,

        /// <remarks></remarks>
        INNER,

        /// <remarks></remarks>
        SLIT,

        /// <remarks></remarks>
        VERTEX,
    }
}
