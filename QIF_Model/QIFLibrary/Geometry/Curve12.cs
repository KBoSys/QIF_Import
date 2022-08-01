/*! \file Curve12.cs
	\brief The Curve12BaseType is the abstract base type for all geometric
        2D curves (curve(t):R1->R2) present in the CAD scene.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Geometry
{
    /// <remarks The Curve12BaseType is the abstract base type for all geometric 2D curves(curve(t):R1->R2) present in the CAD scene./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Polyline12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregate12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Spline12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Nurbs12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcCircular12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcConic12Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Segment12Type))]
    public abstract class Curve12BaseType : GeometryBaseType
    {
    }

    /// <remarks The Segment12Type defines the geometric entity
    /// 'linear_segment(t):R1->R2'. The 2D curves
    /// are normally used to define a trimming curve in the
    /// parametric space of a surface./>
    public class Segment12Type : Curve12BaseType
    {
        /// <remarks The Segment12Core element defines the mathematical core of this curve type./>
        [XmlElement()]
        public Segment12CoreType Segment12Core { get; set; }
    }

    /// <remarks The Segment12CoreType defines the mathematical core of the
    /// geometric entity 'linear_segment(t):R1->R2'. It represents a
    /// portion of a 2D line defined and bounded by a start point and an end point./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class Segment12CoreType : CurveCoreBaseType
    {
        /// <remarks The LineSegment2dGroup is a group of elements that contains a start point and an end point that define a portion of a line./>
        #region ref="LineSegment2dGroup"
        /// <remarks The StartPoint element is the beginning point of the 2D line segment./>
        public Primitives.Point2dSimpleType StartPoint { get; set; }

        /// <remarks The EndPoint element is the ending point of the 2D line segment./>
        public Primitives.Point2dSimpleType EndPoint { get; set; }
        #endregion
    }

    /// <remarks The ArcConicFormEnumType enumerates values that describe the conic arc form and can take the following values:
    /// 'PARABOLA' - a parabola;
    /// 'ELLIPSE' - an ellipse;
    /// 'HYPERBOLA' - a hyperbola;/>
    public enum ArcConicFormEnumType
    {
        PARABOLA, ELLIPSE, HYPERBOLA
    }

    /// <remarks The ArcConic12Type defines the geometric entity
    /// 'conic_arc(t):R1->R2'. The 2D curves are
    /// normally used to define a trimming curve in the parametric space of a surface./>
    public class ArcConic12Type : Curve12BaseType
    {
        /// <remarks The ArcConic12Core element defines the mathematical core of this curve type./>
        public ArcConic12CoreType ArcConic12Core { get; set; }
    }

    /// <remarks The ArcCircular12Type defines the geometric entity
    /// 'circular_arc(t):R1->R2'. 
    /// The 2D curves are normally used to define a trimming curve in the
    /// parametric space of a surface./>
    public class ArcCircular12Type : Curve12BaseType
    {
        /// <remarks The ArcCircular12Core element defines the mathematical core of this curve type./>
        public ArcCircular12CoreType ArcCircular12Core { get; set; }
    }

    /// <remarks The Nurbs12Type defines the geometric entity
    /// 'NURBS_curve(t):R1->R2'. 
    /// The 2D curves are normally used to define a trimming curve in the
    /// parametric space of a surface./>
    public class Nurbs12Type : Curve12BaseType
    {
        /// <remarks The Nurbs12Core element defines the mathematical core of this curve type./>
        public Nurbs12CoreType Nurbs12Core { get; set; }
    }

    /// <remarks The Spline12Type defines the geometric entity
    /// 'spline_curve(t):R1->R2'. 
    /// The 2D curves are normally used to define a trimming curve in the
    /// parametric space of a surface./>
    public class Spline12Type : Curve12BaseType
    {
        /// <remarks The Spline12Core element defines the mathematical core of this curve type./>
        public Spline12CoreType Spline12Core { get; set; }
    }

    /// <remarks The Aggregate12Type defines the geometric entity
    /// 'aggregate_curve(t):R1->R2'.
    /// The 2D curves are normally used to define a trimming curve in the
    /// parametric space of a surface./>
    public class Aggregate12Type : Curve12BaseType
    {
        /// <remarks The Aggregate12Core element defines the mathematical core of this curve type./>
        public Aggregate12CoreType Aggregate12Core { get; set; }
    }

    /// <remarks The Polyline12Type defines the geometric entity
    /// 'polyline(t):R1->R2'.
    /// The Polyline12Type is a 2D curve normally used to define a
    /// trimming curve in the parametric space of a surface./>
    public class Polyline12Type : Curve12BaseType
    {
        /// <remarks The Polyline12Core element defines the mathematical core of this curve type./>
        public Polyline12CoreType Polyline12Core { get; set; }
    }

    /// <remarks The Polyline12CoreType defines the mathematical core of the
    /// geometric entity 'polyline(t):R1->R2'.
    /// The polyline is a series of connected linear segments./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Polyline12CoreType : CurveCoreBaseType
    {
        /// <remarks This compositor provides a choice of the representation method for the polyline points./>
		[System.Xml.Serialization.XmlElementAttribute("Points", typeof(ArrayPoint2dType))]
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
    public partial class Aggregate12CoreType : CurveCoreBaseType
    {
        /// <remarks The SubCurves element is an array of oriented sub-curves./>
        public ArraySubCurve12Type SubCurves { get; set; }
    }

    /// <remarks The ArraySubCurve12Type defines an array of Curve12./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArraySubCurve12Type
    {
        /// <remarks an array of Curve12/>
        [System.Xml.Serialization.XmlElementAttribute("SubCurve")]
        public Curve12OrientedType[] SubCurves { get; set; }

        /// <remarks The required n attribute is the number of Curve12 objects in this array./>
		[System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)SubCurves.Length;
            set { }
        }
    }

    /// <remarks The Spline12CoreType defines the mathematical core of the
    /// geometric entity 'spline_curve(t):R1->R2'.
    /// The spline curve is a sequence of parametric polynomial segments./>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Spline12CoreType : CurveCoreBaseType
    {
        /// <remarks The Knots element is the knot vector which contains the spline breakpoints./>
        public ArrayDoubleType Knots { get; set; }

        /// <remarks The Orders element is the orders of the polynomial segments.
        /// The order is 'the degree of the polynomial' + 1.
        /// The size of this array is 'the number of spline breakpoints' - 1./>
        public ArrayNaturalType Orders { get; set; }

        /// <remarks The Coefficients element is the coefficients of the
        /// polynomial segments.The total size of this array is the sum of all orders./>
        public ArrayPoint2dType Coefficients { get; set; }

        /// <remarks The optional normalized attribute shows if the curve is normalized. 
        /// A value of 1 (or true) means the curve is normalized.A value of 0 (or false) means the curve is not normalized./>
        [System.Xml.Serialization.XmlAttributeAttribute("normalized")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Normalized { get; set; } = false;
    }

    /// <remarks The Nurbs12CoreType defines the mathematical core of the geometric entity 'NURBS_curve(t):R1->R2'. 
    /// A NURBS curve is built on B-spline basis functions and defined by its
    /// order(= degree + 1), a knot vector, and an array of
    /// control points with an optional set of associated weights.
    /// If the weights are not defined or equal, the curve is a polynomial one(otherwise rational)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Nurbs12CoreType : CurveCoreBaseType
    {
        /// <remarks The Order element is the order (= degree + 1)./>
        public uint Order { get; set; }

        /// <remarks The Knots element is the knot vector - an increasing
        /// sequence of real numbers which divides the parametric
        /// space in the spans.The size of the knot vector is 'number of control points' + 'order'./>
        public ArrayDoubleType Knots { get; set; }

        /// <remarks This compositor provides a choice of the representation method for the array of control points./>
        [System.Xml.Serialization.XmlElementAttribute("CPs", typeof(ArrayPoint2dType))]
        [System.Xml.Serialization.XmlElementAttribute("CPsBinary", typeof(ArrayBinaryType))]
        public object Item { get; set; }

        /// <remarks The optional Weights element is an array of control point weights(positive real numbers).
        /// This array can be absent if the NURBS curve is a polynomial one.If this array is
        /// present, then the number of its elements corresponds to the number of control points./>
        public ArrayDoubleType Weights { get; set; }
    }

    /// <remarks The ArcCircular12CoreType defines the mathematical core of the
    /// geometric entity 'circular_arc(t):R1->R2'. A circular arc is defined as a portion of a circle./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArcCircular12CoreType : CurveCoreBaseType
    {
        /// <remarks The Radius element is the arc radius./>
        public double Radius { get; set; }

        /// <remarks The Center element is the 2D coordinates of center of the arc./>
        public string Center { get; set; }

        /// <remarks The DirBeg element is a 2D unit vector representing the beginning of the circular arc./>
        public UnitVector2dSimpleType DirBeg { get; set; }

        /// <remarks The optional turned attribute shows if the arc is inverted.
        /// A value of 1 (or true) means the arc is inverted.A value
        /// of 0 (or false) means the arc is not inverted./>
        [System.Xml.Serialization.XmlAttributeAttribute("turned")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Turned { get; set; } = false;
    }

    /// <remarks The ArcConic12CoreType defines the mathematical core of the geometric entity 'conic_arc(t):R1->R2'. 
    /// A conic arc is defined as a portion of a conic curve.The conic curve can have one the
    /// following forms: an ellipse, a parabola, or a hyperbola./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArcConic12CoreType : CurveCoreBaseType
    {
        /// <remarks The major diameter of the arc./>
        public double A { get; set; }

        /// <remarks The minor diameter of the arc./>
        public double B { get; set; }

        /// <remarks The Center element is the 2D coordinates of center of the arc./>
        public Point2dSimpleType Center { get; set; }

        /// <remarks The DirBeg element is a 2D unit vector representing the beginning of the conic arc./>
        public UnitVector2dSimpleType DirBeg { get; set; }

        /// <remarks The required form attribute specifies the form of the conic arc./>
        [System.Xml.Serialization.XmlAttributeAttribute("form")]
        public ArcConicFormEnumType Form { get; set; }

        /// <remarks The optional turned attribute shows if the arc is inverted.
        /// A value of 1 (or true) means the arc is inverted.
        /// A value of 0 (or false) means the arc is not inverted./>
        [System.Xml.Serialization.XmlAttributeAttribute("turned")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Turned { get; set; } = false;
    }

    /// <remarks The Curve12Core is the core of the oriented curve./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class Curve12OrientedType
    {

        #region ref="Curve12Core"
        /// <remarks The Curve12Core is the core of the oriented curve./>
        [System.Xml.Serialization.XmlElementAttribute("Segment12Core", typeof(Segment12CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("ArcConic12Core", typeof(ArcConic12CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("ArcCircular12Core", typeof(ArcCircular12CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Nurbs12Core", typeof(Nurbs12CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Spline12Core", typeof(Spline12CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Aggregate12Core", typeof(Aggregate12CoreType))]
        [System.Xml.Serialization.XmlElementAttribute("Polyline12Core", typeof(Polyline12CoreType))]
        public CurveCoreBaseType Curve12Core { get; set; }
        #endregion

        /// <remarks The optional turned attribute shows if the Curve12 is inverted.
        /// A value of 1 (or true) means the Curve12 is inverted from the Curve12Core.
        /// A value of 0 (or false) means the Curve12 is not inverted./>
        [System.Xml.Serialization.XmlAttributeAttribute("turned")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Turned { get; set; } = false;
    }
}

