/*! \file TopologyBaseType.cs
    \brief abstract base type for all topology elements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPD;

namespace QIF_Model.QIFLibrary.Topology
{
    /// <remarks> The TopologyBaseType is the abstract base type for all topology elements.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointCloudType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BodyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShellType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceMeshType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopMeshType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoopType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EdgeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VertexType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class TopologyBaseType : DrawableBaseType
    {
    }

    /// <remarks> The BodyType is the b-rep body type - a solid represented as a set of one outer and zero to many inner shells.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BodyType : TopologyBaseType
    {
        /// <remarks> The optional Validation is a set of body validation properties.</remarks>
        public ValidationBodyType? Validation { get; set; }

        /// <remarks> The optional Transform element is an identifier of the transformation matrix.</remarks>
        public ElementReferenceType? Transform { get; set; }

        /// <remarks> The optional ShellIds element is an array of shell identifiers participating in forming this body.</remarks>
        public ArrayReferenceType? ShellIds { get; set; }

        /// <remarks> The optional FaceIds element is an array of face identifiers participating in forming this body.</remarks>
        public ArrayReferenceType? FaceIds { get; set; }

        /// <remarks> The optional LoopIds element is an array of loop identifiers participating in forming this body.</remarks>
        public ArrayReferenceType? LoopIds { get; set; }

        /// <remarks> The optional EdgeIds element is an array of edge identifiers participating in forming this body.</remarks>
        public ArrayReferenceType? EdgeIds { get; set; }

        /// <remarks> The optional VertexIds element is an array of vertex identifiers participating in forming this body.</remarks>
        public ArrayReferenceType? VertexIds { get; set; }

        /// <remarks> The optional form attribute specifies how the body is represented.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        [System.ComponentModel.DefaultValueAttribute(BodyFormEnumType.UNDEFINED)]
        public BodyFormEnumType Form { get; set; } = BodyFormEnumType.UNDEFINED;

        /// <remarks> The optional materialIndex attribute specifies a material index in the material library.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("materialIndex")]
        public uint MaterialIndex { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaterialIndexSpecified { get; set; }
    }

    /// <remarks> The ShellType is the b-rep shell type - a set of connected faces.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ShellType : TopologyBaseType
    {
        /// <remarks> The optional FaceIds element is an array of connected faces which form this shell.</remarks>
        public ArrayReferenceType? FaceIds { get; set; }

        /// <remarks> The optional turned attribute shows if the shell orientation
        /// must be reversed from the orientation of the component faces.
        /// If the value is true, the shell orientation must be
        /// opposite the faces orientation.If the value is false, the
        /// two orientations must be the same.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("turned")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Turned { get; set; } = false;

        /// <remarks> The optional closed attribute shows if the shell is a closed
        /// one(there are no gaps or open contours).</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("closed")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Closed { get; set; } = false;

        /// <remarks> The optional form attribute specifies the shell type which
        /// can take one of the following values: 'UNKNOWN', 'OUTER' or 'INNER'.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        [System.ComponentModel.DefaultValueAttribute(ShellFormEnumType.UNKNOWN)]
        public ShellFormEnumType Form { get; set; } = ShellFormEnumType.UNKNOWN;
    }

    /// <remarks> The ShellFormEnumType enumerates values that describe the shell type.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ShellFormEnumType
    {
        /// <remarks></remarks>
        UNKNOWN,

        /// <remarks></remarks>
        OUTER,

        /// <remarks></remarks>
        INNER,
    }

    /// <remarks> The EdgeType is the b-rep edge type - a topological entity. 
    /// It represents a bounded piece of a 3D curve.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EdgeType : TopologyBaseType
    {
        /// <remarks> The optional Validation element is a set of edge validation properties.</remarks>
        public ValidationEdgeType? Validation { get; set; }

        /// <remarks> The Curve element is the identifier of a 3D curve that is the underlying geometry of this edge.</remarks>
        public ElementReferenceType? Curve { get; set; }

        /// <remarks> The VertexBeg element is the identifier of the vertex which
        /// bounds this edge at the beginning of the edge.The
        /// 'underlying' parameter of VertexBeg must be less then the
        /// 'underlying' parameter of VertexEnd.Or, in other words,
        /// the edge always follows the natural parameterization of the
        /// underlying 3D curve.If there is a need to pass an edge in
        /// the opposite (to the natural parameterization of the
        /// underlying curve) direction then the corresponding flag
        /// must be defined on the loop level.</remarks>
        public ElementReferenceType? VertexBeg { get; set; }

        /// <remarks> The VertexEnd element is the identifier of the vertex which
        /// bounds this edge at the end of the edge.The 'underlying'
        /// parameter of VertexEnd must be bigger then the 'underlying'
        /// parameter of VertexBeg.Or, in other words, the edge always
        /// follows the natural parameterization of the underlying 3D
        /// curve.If there is a need to pass an edge in the opposite
        /// (to the natural parameterization of the underlying curve)
        /// direction then the corresponding flag must be defined on the loop level.</remarks>
        public ElementReferenceType? VertexEnd { get; set; }

        /// <remarks> The optional tolerance attribute specifies the edge tolerance for the case of tolerant body.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("tolerance")]
        public double Tolerance { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ToleranceSpecified { get; set; }
    }

    /// <remarks> The ValidationEdgeType defines a set of edge validation properties.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ValidationEdgeType
    {
        /// <remarks> The optional Length element is the edge length.</remarks>
        public double Length { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LengthSpecified { get; set; }

        /// <remarks> The optional Centroid element is the edge center of mass.</remarks>
        public PointSimpleType? Centroid { get; set; }

        /// <remarks> The optional Box element is the edge bounding box.</remarks>
        public BoundingBoxAxisAlignedType? Box { get; set; }

        /// <remarks> The optional Points element is a set of points that lie on the edge.</remarks>
        public ValidationPointsType? Points { get; set; }
    }

    /// <remarks> The VertexType is the b-rep vertex type - a topological entity.
    /// Each instance of VertexType lies at a point and is normally used to bound an edge.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VertexType : TopologyBaseType
    {
        /// <remarks> The Point element is the identifier of a 3D point - the underlying geometry of the vertex.</remarks>
        public ElementReferenceType? Point { get; set; }

        /// <remarks> The optional tolerance attribute specifies the maximum
        /// distance from the vertex underlying geometry(3D point) to
        /// the ends of all the adjacent edges that are terminated in
        /// the neighborhood of this vertex.This value can be defined only for the case of the tolerant body.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("tolerance")]
        public double Tolerance { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ToleranceSpecified { get; set; }
    }

    /// <remarks> The BodyFormEnumType enumerates values that describe the body </remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum BodyFormEnumType
    {
        /// <remarks> undefined</remarks>
        UNDEFINED,

        /// <remarks> a one-face body which does not have any
        /// topology information (normally restored from legacy formats like IGES)</remarks>
        TRIMMED_SURFACE,

        /// <remarks> a body consisting entirely of wire regions</remarks>
        WIRE,

        /// <remarks> a body consisting entirely of solid regions</remarks>
        SOLID,

        /// <remarks> a body consisting entirely of sheet regions</remarks>
        SHEET,

        /// <remarks> a body containing some combination of regions</remarks>
        MIXED,
    }
}
