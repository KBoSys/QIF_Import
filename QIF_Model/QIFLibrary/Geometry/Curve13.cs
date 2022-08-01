/*! \file Curve13.cs
	\brief The global Curve13 element is a 3D curve and is the head of a substitution group.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks The Curve13BaseType is the abstract base type for all geometric
    /// 3D curves(curve(t):R1->R3) present in the CAD scene./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic13Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment13Type))]
    public abstract class Curve13BaseType : GeometryBaseType
    {
        /// <remarks The optional Transform element is the identifier of a three dimensional transformation matrix./>
        public ElementReferenceType Transform { get; set; }
    }

    /// <remarks The Segment13Type defines the geometric entity
    /// 'linear_segment(t):R1->R3'. Any 3D geometry can have an additional transformation matrix./>
	public class Segment13Type : Curve13BaseType
    {
        /// <remarks The Segment13Core element defines the mathematical core of this curve type./>
        public Segment13CoreType Segment13Core { get; set; }
    }

    /// <remarks The ArcConic13Type defines the geometric entity
    /// 'conic_arc(t):R1->R3'. Any 3D geometry can have an
    /// additional transformation matrix./>
    public class ArcConic13Type : Curve13BaseType
    {
        /// <remarks The ArcConic13Core element defines the mathematical core of this curve type./>
        public ArcConic13CoreType ArcConic13Core { get; set; }
    }

    /// <remarks The ArcCircular13Type defines the geometric entity
    /// 'circular_arc(t):R1->R3'. Any 3D geometry can have an
    /// additional transformation matrix./>
    public class ArcCircular13Type : Curve13BaseType
    {
        /// <remarks Defines the mathematical core of this curve type./>
        public ArcCircular13CoreType ArcCircular13Core { get; set; }
    }

    /// <remarks The Nurbs13Type defines the geometric entity
    /// 'NURBS_curve(t):R1->R3'. Any 3D geometry can have an
    /// additional transformation matrix./>
    public class Nurbs13Type : Curve13BaseType
    {
        /// <remarks Defines the mathematical core of this curve type./>
        public Nurbs13CoreType Nurbs13Core { get; set; }
    }

    /// <remarks The Spline13Type defines the geometric entity
    /// 'spline_curve(t):R1->R3'. Any 3D geometry can have an
    /// additional transformation matrix./>
    public class Spline13Type : Curve13BaseType
    {
        /// <remarks Defines the mathematical core of this curve type./>
        public Spline13CoreType Spline13Core { get; set; }
    }

    /// <remarks The Aggregate13Type defines the geometric entity
    /// 'aggregate_curve(t):R1->R3'. Any 3D geometry can have an
    /// additional transformation matrix./>
    public class Aggregate13Type : Curve13BaseType
    {
        /// <remarks Defines the mathematical core of this curve type./>
        public Aggregate13CoreType Aggregate13Core { get; set; }
    }

    /// <remarks The Polyline13Type defines the geometric entity
    /// 'polyline(t):R1->R3'. Any 3D geometry can have an
    /// additional transformation matrix./>
	public class Polyline13Type : Curve13BaseType
    {
        /// <remarks Defines the mathematical core of this curve type./>
        public Polyline13CoreType Polyline13Core { get; set; }
    }

    /// <remarks The Polyline13CoreType defines the mathematical core of the
    /// geometric entity 'polyline(t):R1->R3'.
    /// The polyline is a series of connected linear segments./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Polyline13CoreType : CurveCoreBaseType
    {
        /// <remarks This compositor provides a choice of the representation method for the polyline points./>
		[System.Xml.Serialization.XmlElementAttribute("Points", typeof(ArrayPointType))]
        [System.Xml.Serialization.XmlElementAttribute("PointsBinary", typeof(ArrayBinaryType))]
        public object Item { get; set; }
    }

    /// <remarks The Aggregate12CoreType defines the mathematical core of the
    /// geometric entity 'aggregate_curve(t):R1->R2'.
    /// The aggregate curve is a sequence of parametric sub-curves./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Aggregate13CoreType : CurveCoreBaseType
    {
        /// <remarks The SubCurves element is an array of orientated sub-curves./>
		public ArraySubCurve13Type SubCurves { get; set; }
    }

    /// <remarks The Spline13CoreType defines the mathematical core of the
    /// geometric entity 'spline_curve(t):R1->R3'.
    /// The spline curve is a sequence of parametric polynomial segments./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Spline13CoreType : CurveCoreBaseType
    {
        /// <remarks The Knots element is the knot vector which contains the spline breakpoints./>
        public ArrayDoubleType Knots { get; set; }

        /// <remarks The Orders element is the orders of the polynomial segments.
        /// The order is 'the degree of the polynomial' + 1.
        /// The size of this array is 'the number of spline breakpoints' - 1./>
        public ArrayNaturalType Orders { get; set; }

        /// <remarks The Coefficients element is the coefficients of the
        /// polynomial segments.For each segment the number of
        /// coefficients equals the polynomial order on this segment. 
        /// The total size of this array is the sum of all orders./>
        public ArrayPointType Coefficients { get; set; }

        /// <remarks The optional normalized attribute shows if the curve is normalized.
        /// A value of 1 (or true) means the curve is normalized.
        /// A value of 0 (or false) means the curve is not normalized./>
        [System.Xml.Serialization.XmlAttributeAttribute("normalized")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Normalized { get; set; }
    }

    /// <remarks The Nurbs13CoreType defines the mathematical core of the geometric
    /// entity 'NURBS_curve(t):R1->R3'. A NURBS curve is built on B-spline
    /// basis functions and defined by its order(= degree + 1), a knot
    /// vector, and an array of control points with an optional set of
    /// associated weights.If the weights are not defined or equal, the
    /// curve is a polynomial one(otherwise rational)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Nurbs13CoreType : CurveCoreBaseType
    {
        /// <remarks The Order element is the order (= degree + 1)./>
        public uint Order { get; set; }

        /// <remarks The Knots element is the knot vector - an increasing
        /// sequence of real numbers which divides the parametric
        /// space in the spans.The size of the knot vector is
        /// 'number of control points' + 'order'./>
        public ArrayDoubleType Knots { get; set; }

        /// <remarks This compositor provides a choice of the representation method for the array of control points./>
        [System.Xml.Serialization.XmlElementAttribute("CPs", typeof(ArrayPointType))]
        [System.Xml.Serialization.XmlElementAttribute("CPsBinary", typeof(ArrayBinaryType))]
        public object Item { get; set; }

        /// <remarks The optional Weights element is an array of control point
        /// weights(positive real numbers).This array can be absent if
        /// the NURBS curve is a polynomial one.If this array is
        /// present, then the number of its elements corresponds to the
        /// number of control points./>
        public ArrayDoubleType Weights { get; set; }
    }

    /// <remarks The ArcCircular13CoreType defines the mathematical core of the
    /// geometric entity 'circular_arc(t):R1->R3'. A circular arc is
    /// defined as a portion of a circle./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArcCircular13CoreType : CurveCoreBaseType
    {
        /// <remarks The Radius element is the arc radius./>
        public double Radius { get; set; }

        /// <remarks The Center element is the 3D coordinates of center of the arc./>
        public PointSimpleType Center { get; set; }

        /// <remarks The DirBeg element is a unit vector representing the beginning of the conic arc./>
        public UnitVectorSimpleType DirBeg { get; set; }

        /// <remarks The Normal element is normal of the plane wherein the conic arc is defined./>
        public UnitVectorSimpleType Normal { get; set; }
    }

    /// <remarks The ArcConic13CoreType defines the mathematical core of the
    /// geometric entity 'conic_arc(t):R1->R3'. A conic arc is defined
    /// as a portion of a conic curve.The conic curve can have one the following forms: an ellipse, a parabola, or a hyperbola./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArcConic13CoreType : CurveCoreBaseType
    {
        /// <remarks The major diameter of the arc./>
        public double A { get; set; }

        /// <remarks The minor diameter of the arc./>
        public double B { get; set; }

        /// <remarks The Center element is the 3D coordinates of center of the arc./>
        public PointSimpleType Center { get; set; }

        /// <remarks The DirBeg element is a unit vector representing the beginning of the conic arc./>
        public UnitVectorSimpleType DirBeg { get; set; }

        /// <remarks The Normal element is normal of the plane wherein the conic arc is defined./>
        public UnitVectorSimpleType Normal { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        public ArcConicFormEnumType Form { get; set; }
    }

    /// <remarks The Segment13CoreType defines the mathematical core of the
    /// geometric entity 'linear_segment(t):R1->R3'. It represents a
    /// portion of a 3D line defined and bounded by a start point and an end point./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Segment13CoreType : CurveCoreBaseType
    {
        /// <remarks The LineSegmentGroup is a group of elements that contains a start point and an end point that define a portion of a line./>
        #region ref="LineSegmentGroup"
        /// <remarks The StartPoint element is the beginning point of the line segment./>
        public PointSimpleType StartPoint { get; set; }

        /// <remarks The EndPoint element is the ending point of the line segment./>
        public PointSimpleType EndPoint { get; set; }
        #endregion
    }

    /// <remarks The ArraySubCurve13Type defines an array of Curve13 sub-curves./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArraySubCurve13Type
    {
        /// <remarks Each SubCurve element is a Curve13./>
        [System.Xml.Serialization.XmlElementAttribute("SubCurve")]
        public Curve13OrientedType[] SubCurves { get; set; }

        /// <remarks The required n attribute is the number of Curve13 objects in this array./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.SubCurves.Length;
            set { }
        }
    }

    /// <remarks The Curve13OrientedType defines an oriented Curve13./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Curve13OrientedType
    {
        /// <remarks The Curve13Core is the core of the oriented curve./>
        [System.Xml.Serialization.XmlElementAttribute("Polyline13Core", typeof(Polyline13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Aggregate13Core", typeof(Aggregate13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Spline13Core", typeof(Spline13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Nurbs13Core", typeof(Nurbs13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("ArcCircular13Core", typeof(ArcCircular13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("ArcConic13Core", typeof(ArcConic13CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Segment13Core", typeof(Segment13CoreType))]
        public CurveCoreBaseType Curve13Core { get; set; }

        /// <remarks The optional turned attribute shows if the Curve13 is inverted.
        /// A value of 1 (or true) means the Curve13 is inverted from the Curve13Core.
        /// A value of 0 (or false) means the Curve13 is not inverted./>
        [System.Xml.Serialization.XmlAttributeAttribute("turned")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Turned { get; set; } = false;
    }
}
