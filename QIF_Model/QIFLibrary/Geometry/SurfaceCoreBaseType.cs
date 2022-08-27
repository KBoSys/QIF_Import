/*! \file SurfaceCoreBaseType.cs
	\brief abstract base type for all mathematical cores of surfaces present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks> The Attr23CoreEnumType enumerates values that describe the surface form</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum Attr23CoreEnumType
    {
        /// <remarks> a freeform surface (NURBS, spline etc.)</remarks>
        FREEFORM,

        /// <remarks> a cylindrical surface</remarks>
        CYLINDER,

        /// <remarks> a conical surface</remarks>
        CONE,

        /// <remarks> a toroidal surface</remarks>
        TORUS,

        /// <remarks> a spherical surface</remarks>
        SPHERE,

        /// <remarks> a plane surface</remarks>
        PLANE,
    }

    /// <remarks> The SurfaceCoreBaseType is the abstract base type for all mathematical cores of surfaces present in the CAD scene.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Torus23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Sphere23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cylinder23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Cone23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Plane23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Offset23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ruled23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Extrude23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Revolution23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline23CoreType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs23CoreType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class SurfaceCoreBaseType
    {
        /// <remarks> The optional form attribute describes the surface form.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        public Attr23CoreEnumType Form { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormSpecified { get; set; }
    }

    /// <remarks> The Torus23CoreType defines the mathematical core of the geometric entity 'toroidal_surface(u,v):R2->R3'.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Torus23CoreType : SurfaceCoreBaseType
    {
        private DoublePositiveType scaleUField = 1D;
        private DoublePositiveType scaleVField = 1D;

        /// <remarks> The DiameterMinor element is the torus minor diameter.</remarks>
        public double DiameterMinor { get; set; }

        /// <remarks> The DiameterMajor element is the torus major diameter.</remarks>
        public double DiameterMajor { get; set; }

        /// <remarks> The Axis is the unit axis vector of the torus.</remarks>
        public AxisType Axis { get; set; }

        /// <remarks> The LatitudeLongitudeSweep element specifies the
        /// sweep angles in the two directions analogous to terrestrial latitude and longitude.</remarks>
        public LatitudeLongitudeSweepType LatitudeLongitudeSweep { get; set; }

        /// <remarks> The optional turnedV attribute shows if the v direction of the torus must be inverted.
        /// A value of 1 (or true) means the v direction must be inverted.
        /// A value of 0 (or false) means the v direction must not be inverted.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("turnedV")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TurnedV { get; set; } = false;

        /// <remarks> The optional offsetV attribute specifies the offset of the v parameter before passing the parameter to the torus formula.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("offsetV")]
        [System.ComponentModel.DefaultValueAttribute(0D)]
        public double OffsetV { get; set; } = 0D;

        /// <remarks> The optional scaleU attribute is the scaling coefficient of the u direction of the parametric space.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("scaleU")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double ScaleU { get => scaleUField; set => scaleUField = value; }

        /// <remarks> The optional scaleV attribute is the scaling coefficient of the v direction of the parametric space.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("scaleV")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double ScaleV { get => scaleVField; set => scaleVField = value; }
    }

    /// <remarks> The Sphere23CoreType defines the mathematical core of the geometric entity 'spherical_surface(u,v):R2->R3'.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Sphere23CoreType : SurfaceCoreBaseType
    {
        /// <remarks> The Diameter element is diameter of the sphere.</remarks>
        public double Diameter { get; set; }

        /// <remarks> The Location element is a 3D point which defines the sphere center.</remarks>
        public PointSimpleType Location { get; set; }

        /// <remarks> The LatitudeLongitudeSweep element specifies the
        /// sweep angles in the two directions analogous to terrestrial latitude and longitude.</remarks>
        public OrientedLatitudeLongitudeSweepType LatitudeLongitudeSweep { get; set; }

        /// <remarks> The optional turnedV attribute shows if the v direction of the sphere must be inverted.
        /// A value of 1 (or true) means the v direction must be inverted.
        /// A value of 0 (or false) means the v direction must not be inverted.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("turnedV")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TurnedV { get; set; } = false;

        /// <remarks> The optional scaleU attribute is the scaling coefficient of the u direction of the parametric space.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("scaleU")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double ScaleU { get; set; } = 1D;

        /// <remarks> The optional scaleV attribute is the scaling coefficient of the v direction of the parametric space.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("scaleV")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double ScaleV { get; set; } = 1D;
    }

    /// <remarks> The Cylinder23CoreType defines the mathematical core of the geometric entity 'cylindrical_surface(u,v):R2->R3'.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Cylinder23CoreType : SurfaceCoreBaseType
    {
        /// <remarks> The Diameter element is diameter of the cylinder.</remarks>
        public double Diameter { get; set; }

        /// <remarks> The Length element is height of the cylinder - distance between the cylinder top and bottom.</remarks>
        public double Length { get; set; }

        /// <remarks> The Axis is the unit axis vector of the cylinder.</remarks>
        public AxisType Axis { get; set; }

        /// <remarks> The Sweep element gives the start direction and the swept
        /// angle for the cylinder.The StartVector of the
        /// Sweep must lie in a plane normal to the axis of the cone.</remarks>
        public SweepType Sweep { get; set; }

        /// <remarks> The optional turnedV attribute shows if the v direction of the cylinder must be inverted.
        /// A value of 1 (or true) means the v direction must be inverted.
        /// A value of 0 (or false) means the v direction must not be inverted.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("turnedV")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TurnedV { get; set; } = false;

        /// <remarks> The optional scaleU attribute is the scaling coefficient of the u direction of the parametric space.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("scaleU")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double ScaleU { get; set; } = 1D;

        /// <remarks> The optional scaleV attribute is the scaling coefficient of the v direction of the parametric space.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("scaleV")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double ScaleV { get; set; } = 1D;
    }

    /// <remarks> The Cone23CoreType defines the mathematical core of the geometric entity 'conical_surface(u,v):R2->R3'.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Cone23CoreType : SurfaceCoreBaseType
    {
        /// <remarks> The DiameterBottom element is cone diameter at the bottom.</remarks>
        public double DiameterBottom { get; set; }

        /// <remarks> The DiameterBottom element is cone diameter at the top.</remarks>
        public double DiameterTop { get; set; }

        /// <remarks> The Length element is the cone height - distance between the cone top and bottom.</remarks>
        public double Length { get; set; }

        /// <remarks> The Axis is the unit axis vector of the cone.</remarks>
        public AxisType Axis { get; set; }

        /// <remarks> The Sweep element gives the start direction and the swept
        /// angle for the cone.The start Vector of the
        /// Sweep must lie in a plane normal to the axis of the cone.</remarks>
        public SweepType Sweep { get; set; }

        /// <remarks> The optional turnedV attribute shows if the v direction of the cone must be inverted.
        /// A value of 1 (or true) means the v direction must be inverted.
        /// A value of 0 (or false) means the v direction must not be inverted.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("turnedV")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TurnedV { get; set; } = false;

        /// <remarks> The optional scaleU attribute is the scaling coefficient of the u direction of the parametric space.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("scaleU")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double ScaleU { get; set; } = 1D;

        /// <remarks> The optional scaleV attribute is the scaling coefficient of the v direction of the parametric space.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("scaleV")]
        [System.ComponentModel.DefaultValueAttribute(1D)]
        public double ScaleV { get; set; } = 1D;
    }

    /// <remarks> The Plane23CoreType defines the mathematical core of the geometric entity 'plane_surface(u,v):R2->R3'. 
    /// Plane is an infinite flat surface. The parametrization of the plane is defined by two
    /// vectors: DirU and DirV.The domain values (domainU and domainV) 'limit' the plane infinity.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Plane23CoreType : SurfaceCoreBaseType
    {
        private ParameterRangeType domainUField;
        private ParameterRangeType domainVField;

        /// <remarks> The Origin element gives one corner of the parallelogram.</remarks>
        public PointSimpleType Origin { get; set; }

        /// <remarks> The DirU element is a vector that defines the direction and
        /// scaling of U-parameter lines.The DirU vector must not be parallel or anti-parallel to the DirV vector.</remarks>
        public VectorSimpleType DirU { get; set; }

        /// <remarks> The DirV element is a vector that defines the direction and scaling of V-parameter lines.</remarks>
        public VectorSimpleType DirV { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("domainU")]
        public double[] DomainU { get => domainUField; set => domainUField = value; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("domainV")]
        public double[] DomainV { get => domainVField; set => domainVField = value; }
    }

    /// <remarks> The SurfaceCoreType represents a container for a single surface.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceCoreType
    {
        /// <remarks> The Surface element is a surface (surface(u, v):R2->R3).</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Nurbs23Core", typeof(Nurbs23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Spline23Core", typeof(Spline23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Revolution23Core", typeof(Revolution23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Extrude23Core", typeof(Extrude23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Ruled23Core", typeof(Ruled23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Offset23Core", typeof(Offset23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Plane23Core", typeof(Plane23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Cone23Core", typeof(Cone23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Cylinder23Core", typeof(Cylinder23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Sphere23Core", typeof(Sphere23CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Torus23Core", typeof(Torus23CoreType))]
        public SurfaceCoreBaseType SurfaceCore { get; set; }
    }

    /// <remarks> The Offset23CoreType defines the mathematical core of the
    /// geometric entity 'offset_surface(u,v):R2->R3'. The offset surface
    /// is built on an existing surface by moving every surface point in
    /// the normal direction on an offset distance.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Offset23CoreType : SurfaceCoreBaseType
    {
        /// <remarks> The Distance element is the offset distance.</remarks>
        public double Distance { get; set; }

        /// <remarks> The Surface element is the base surface for the offsetting.</remarks>
        public SurfaceCoreType Surface { get; set; }
    }

    /// <remarks> The Ruled23CoreType defines the mathematical core of the
    /// geometric entity 'ruled_surface(u,v):R2->R3'.
    /// The ruled surface is a surface generated by connecting
    /// corresponding points on two space curves by a set of linear segments.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Ruled23CoreType : SurfaceCoreBaseType
    {
        /// <remarks> The Curve element is a 3D base curve.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Curve")]
        public Curve13CoreType[] Curve { get; set; }

        /// <remarks> The optional turnedSecondCurve attribute shows if the second
        /// curve is inverted.A value of 1 (or true) means the second
        /// curve is inverted.A value of 0 (or false) means the second curve is not inverted.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("turnedSecondCurve")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TurnedSecondCurve { get; set; } = false;
    }

    /// <remarks> The Extrude23CoreType defines the mathematical core of the
    /// geometric entity 'surface_of_extrusion(u,v):R2->R3'.
    /// It is built on the profile-curve and the extrusion direction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Extrude23CoreType : SurfaceCoreBaseType
    {
        /// <remarks> The TerminationPoint specifies the termination point. The corresponding start point is located at the profile curve.</remarks>
        public PointSimpleType TerminationPoint { get; set; }

        /// <remarks> The Curve element is the curve to be used as the profile of extrusion.</remarks>
        public Curve13CoreType Curve { get; set; }
    }

    /// <remarks> The Revolution23CoreType defines the mathematical core of the geometric entity 'surface_of_revolution(u,v):R2->R3'.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Revolution23CoreType : SurfaceCoreBaseType
    {
        private ParameterRangeType angleFiled;

        /// <remarks> The Axis is the unit axis vector of rotation.</remarks>
        public AxisType Axis { get; set; }

        /// <remarks> The Generatrix element is the 3D curve to be rotated around the axis.</remarks>
        public Curve13CoreType Generatrix { get; set; }

        /// <remarks> The required angle attribute specifies start and terminate rotation angles.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("angle")]
        public double[] Angle { get => angleFiled; set => angleFiled = value; }
    }

    /// <remarks> The Spline23CoreType defines the mathematical core of the
    /// geometric entity 'spline_surface(u,v):R2->R3'.
    /// The spline surface is a grid of parametric polynomial patches.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Spline23CoreType : SurfaceCoreBaseType
    {
        /// <remarks> The KnotsU element is the knot vector in the u direction (the u spline breakpoints).</remarks>
        public ArrayDoubleType KnotsU { get; set; }

        /// <remarks> The KnotsV element is the knot vector in the v direction (the v spline breakpoints).</remarks>
        public ArrayDoubleType KnotsV { get; set; }

        /// <remarks> The OrdersU element is the orders of the polynomial patches in the u direction.
        /// The order is 'the degree of the polynomial' + 1.
        /// The size of this array is 'the number of the u spline breakpoints' - 1.</remarks>
        public ArrayNaturalType OrdersU { get; set; }

        /// <remarks> The OrdersV element is the orders of the polynomial patches in the v direction.
        /// The order is 'the degree of the polynomial' + 1.
        /// The size of this array is 'the number of the v spline breakpoints' - 1.</remarks>
        public ArrayNaturalType OrdersV { get; set; }

        /// <remarks> The Coefficients element is the coefficients of the polynomial patches. 
        /// For each patch the number of coefficients equals ['the u polynomial order of the patch' times
        /// 'the v polynomial order of the patch'].
        /// The total size of this array is the sum of all patch coefficients.</remarks>
        public ArrayPointType Coefficients { get; set; }

        /// <remarks> The optional normalized attribute shows if the spline surface is normalized.
        /// A value of 1 (or true) means the surface is normalized.
        /// A value of 0 (or false) means the surface is not normalized.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("normalized")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Normalized { get; set; } = false;
    }

    /// <remarks> The Nurbs23CoreType defines the mathematical core of the geometric entity 'NURBS_surface(u,v):R2->R3'.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Nurbs23CoreType : SurfaceCoreBaseType
    {
        /// <remarks> The OrderU element is the order in the u direction (= degree + 1).</remarks>
        public uint OrderU { get; set; }

        /// <remarks> The OrderU element is the order in the v direction (= degree + 1).</remarks>
        public uint OrderV { get; set; }

        /// <remarks> The KnotsU element is the knot vector in the u direction.
        /// The size of the knot vector is 'number of control points in
        /// the u direction' + 'order in the u direction'.</remarks>
        public ArrayDoubleType KnotsU { get; set; }

        /// <remarks> The KnotsV element is the knot vector in the v direction.
        /// The size of the knot vector is 'number of control points in
        /// the v direction' + 'order in the v direction'.</remarks>
        public ArrayDoubleType KnotsV { get; set; }

        /// <remarks> This compositor provides a choice of the representation
        /// method for the array of control points.The size of this
        /// array is ('number of the u-knots' - 'the u-order') * ('number of the v-knots' - 'the v-order').</remarks>
        [System.Xml.Serialization.XmlElementAttribute("CPs", typeof(ArrayPointType))]
        [System.Xml.Serialization.XmlElementAttribute("CPsBinary", typeof(ArrayBinaryType))]
        public object Item { get; set; }

        /// <remarks> The optional Weights element is an array of control point weights.
        /// This array can be absent if the NURBS surface is a polynomial one.If this array is present then the number
        /// of its elements corresponds to the number of control points.</remarks>
        public ArrayDoubleType Weights { get; set; }
    }
}
