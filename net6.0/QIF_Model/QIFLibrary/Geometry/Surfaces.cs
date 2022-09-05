/*! \file Surfaces.cs
	\brief The SurfaceBaseType is the abstract base type for all geometric
        surfaces (R2->R3) present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Geometry
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Torus23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Sphere23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cylinder23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cone23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Plane23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Offset23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ruled23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Extrude23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Revolution23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline23Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs23Type))]
    /// <remarks> The SurfaceBaseType is the abstract base type for all geometric surfaces(R2->R3) present in the CAD scene.</remarks>
    public abstract class SurfaceBaseType : GeometryBaseType
    {
        /// <remarks> The optional Transform element is the identifier of a three dimensional transformation matrix.</remarks>
        public ElementReferenceType? Transform { get; set; }
    }

    /// <remarks> The Torus23Type defines the geometric entity
    /// 'toroidal_surface(u,v):R2->R3'. Any surface can have an additional transformation matrix.
    /// The center of the torus is at the AxisPoint of the Axis, and the axis of the torus is the Axis.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Torus23Type : SurfaceBaseType
    {
        /// <remarks> The Torus23Core element defines the mathematical core of this surface type.</remarks>
        public Torus23CoreType? Torus23Core { get; set; }
    }

    /// <remarks> The Sphere23Type defines the geometric entity
    /// 'spherical_surface(u,v):R2->R3'. Any surface can have an additional transformation matrix.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Sphere23Type : SurfaceBaseType
    {
        /// <remarks> The Sphere23Core element defines the mathematical core of this surface type.</remarks>
        public Sphere23CoreType? Sphere23Core { get; set; }
    }

    /// <remarks> The Cylinder23Type defines the geometric entity
    /// 'cylindrical_surface(u,v):R2->R3'. Any surface can have an
    /// additional transformation matrix.The
    /// cylinder is bounded below by a plane passing through the
    /// AxisPoint of the axis and normal to the axis.The cylinder is
    /// bound above by a plane that (1) passes through a point on the
    /// axis a distance Length along the axis from the axis point in
    /// the direction of the axis and(2) is normal to the axis.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Cylinder23Type : SurfaceBaseType
    {
        /// <remarks> The Cylinder23Core element defines the mathematical core of this surface type.</remarks>
        public Cylinder23CoreType? Cylinder23Core { get; set; }
    }

    /// <remarks> The Cone23Type defines the geometric entity
    /// 'conical_surface(u,v):R2->R3'. Any surface can have an
    /// additional transformation matrix.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Cone23Type : SurfaceBaseType
    {
        /// <remarks> The Cone23Core element defines the mathematical core of this surface type.</remarks>
        public Cone23CoreType? Cone23Core { get; set; }
    }

    /// <remarks> The Plane23Type defines the geometric entity 'planar_surface(u,v):R2->R3'. 
    /// Any surface can have an additional transformation matrix.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Plane23Type : SurfaceBaseType
    {
        /// <remarks> The Plane23Core element defines the mathematical core of this surface type.</remarks>
        public Plane23CoreType? Plane23Core { get; set; }
    }

    /// <remarks> The Offset23Type defines the geometric entity
    /// 'offset_surface(u,v):R2->R3'. Any surface can have an
    /// additional transformation matrix.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Offset23Type : SurfaceBaseType
    {
        /// <remarks> The Offset23Core element defines the mathematical core of this surface type.</remarks>
        public Offset23CoreType? Offset23Core { get; set; }
    }

    /// <remarks> The Ruled23Type defines the geometric entity
    /// 'ruled_surface(u,v):R2->R3'. Any surface can have an additional transformation matrix.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Ruled23Type : SurfaceBaseType
    {
        /// <remarks> The Ruled23Core element defines the mathematical core of this surface type.</remarks>
        public Ruled23CoreType? Ruled23Core { get; set; }
    }

    /// <remarks> The Extrude23Type defines the geometric entity 'surface_of_extrusion(u,v):R2->R3'. 
    /// Any surface can have an additional transformation matrix.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Extrude23Type : SurfaceBaseType
    {
        /// <remarks> The Extrude23Core element defines the mathematical core of this surface type.</remarks>
        public Extrude23CoreType? Extrude23Core { get; set; }
    }

    /// <remarks> The Revolution23Type defines the geometric entity
    /// 'surface_of_revolution(u,v):R2->R3'. Any surface can have an
    /// additional transformation matrix.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Revolution23Type : SurfaceBaseType
    {
        /// <remarks> The Revolution23Core element defines the mathematical core of this surface type.</remarks>
        public Revolution23CoreType Revolution23Core { get; set; } = new Revolution23CoreType();
    }

    /// <remarks> The Spline23Type defines the geometric entity 'spline_surface(u,v):R2->R3'. 
    /// Any surface can have an additional transformation matrix.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Spline23Type : SurfaceBaseType
    {
        /// <remarks> The Spline23Core element defines the mathematical core of this surface type.</remarks>
        public Spline23CoreType Spline23Core { get; set; } = new Spline23CoreType();
    }

    /// <remarks> The Nurbs23Type defines the geometric entity 'NURBS_surface(u,v):R2->R3'. 
    /// Any surface can have an additional transformation matrix.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Nurbs23Type : SurfaceBaseType
    {
        /// <remarks> The Nurbs23Core element defines the mathematical core of this surface type.</remarks>
        public Nurbs23CoreType Nurbs23Core { get; set; } = new Nurbs23CoreType();
    }
}
