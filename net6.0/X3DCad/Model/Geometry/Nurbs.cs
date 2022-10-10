/*! \file NurbsPatchSurface.cs
	\brief Parametric curves in 3D space

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;
using X3DCad.Model.Types;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The NurbsTextureCoordinate node is a NURBS surface existing in the parametric domain of its surface host specifying the mapping of the texture onto the surface.
    /// </summary>
    public class NurbsTextureCoordinate : X3DNode
    {
        [XmlIgnore]
        public MFVec2f ControlPoint { get; set; } = new MFVec2f();

        [XmlAttribute("controlPoint")]
        public string? ControlPointAsText { get => ControlPoint.ToString(); set => ControlPoint.FromString(value); }

        [XmlAttribute("uDimension")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public Int32 UDimension { get; set; } = 0;

        [XmlAttribute("vDimension")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public Int32 VDimension { get; set; } = 0;

        [XmlAttribute("uKnot")]
        public double UKnot { get; set; }

        [XmlAttribute("vKnot")]
        public double VKnot { get; set; }

        [XmlAttribute("uOrder")]
        [System.ComponentModel.DefaultValueAttribute(3)]
        public Int32 UOrder { get; set; } = 3;

        [XmlAttribute("vOrder")]
        [System.ComponentModel.DefaultValueAttribute(3)]
        public Int32 VOrder { get; set; } = 3;

        [XmlAttribute("weight")]
        public double Weight { get; set; }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("texCoord")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// The ContourPolyline2D node defines a piecewise linear curve segment as a part of a trimming contour in the u,v domain of a surface.
    /// The controlPoint field specifies the end points of each segment of the piecewise linear curve.
    /// ContourPolyline2D nodes are used as children of the Contour2D group.
    /// </summary>
    public class ContourPolyline2D : X3DNurbsControlCurveNode
    {
        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("children")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// The Contour2D node groups a set of curve segments to a composite contour.
    /// </summary>
    public class Contour2D : X3DNode
    {
        #region <xs:choice minOccurs = "0" maxOccurs="unbounded">
        [XmlElement("Coordinate", typeof(NurbsCurve2D))]
        [XmlElement("CoordinateDouble", typeof(ContourPolyline2D))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public List<object>? Children { get; set; }
        #endregion </xs:choice>

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("trimmingContour")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// The NurbsCurve2D node defines a trimming segment that is part of a trimming contour in the u,v domain of the surface.
    /// NurbsCurve2D nodes are used as children of the Contour2D group.
    /// </summary>
    public class NurbsCurve2D : X3DNurbsControlCurveNode
    {
        [XmlAttribute("closed")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Closed { get; set; } = false;

        [XmlAttribute("knot")]
        public double Knot { get; set; }

        [XmlAttribute("order")]
        [System.ComponentModel.DefaultValueAttribute(3)]
        public Int32 Order { get; set; } = 3;

        [XmlAttribute("tessellation")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public Int32 Tessellation { get; set; } = 0;

        [XmlAttribute("weight")]
        public double Weight { get; set; }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// The NurbsCurve node is a geometry node defining a parametric curve in 3D space
    /// </summary>
    public class NurbsCurve : X3DParametricGeometryNode
    {
        /// <summary>
        /// Appropriately typed substitution node
        /// </summary>
        #region <xs:choice minOccurs = "0" maxOccurs="1">
        [XmlElement("Coordinate", typeof(Coordinate))]
        [XmlElement("CoordinateDouble", typeof(CoordinateDouble))]
        [XmlElement("GeoCoordinate", typeof(GeoCoordinate))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public object? ControlPoint { get; set; }
        #endregion </xs:choice>

        [XmlAttribute("closed")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Closed { get; set; } = false;

        [XmlAttribute("knot")]
        public double Knot { get; set; }

        [XmlAttribute("order")]
        [System.ComponentModel.DefaultValueAttribute(3)]
        public Int32 Order { get; set; } = 3;

        [XmlAttribute("tessellation")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public Int32 Tessellation { get; set; } = 0;

        [XmlAttribute("weight")]
        public double Weight { get; set; }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// The NurbsPatchSurface node is a contiguous NURBS surface patch
    /// </summary>
    public class NurbsPatchSurface : X3DNurbsSurfaceGeometryNode
    {
        #region <xs:choice minOccurs = "0" maxOccurs="2">
        [XmlElement("Coordinate", typeof(Coordinate))]
        [XmlElement("CoordinateDouble", typeof(CoordinateDouble))]
        [XmlElement("GeoCoordinate", typeof(GeoCoordinate))]
        [XmlElement("TextureCoordinate", typeof(TextureCoordinate))]
        [XmlElement("NurbsTextureCoordinate", typeof(NurbsTextureCoordinate))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public List<object>? Coord { get; set; }
        #endregion </xs:choice>

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// The NurbsTrimmedSurface node defines a NURBS surface that is trimmed by a set of trimming loops. 
    /// The outermost trimming loop shall be defined in a counterclockwise direction
    /// </summary>
    public class NurbsTrimmedSurface : X3DNurbsSurfaceGeometryNode
    {
        #region <xs:choice minOccurs = "0" maxOccurs="unbounded">
        [XmlElement("Contour2D", typeof(Contour2D))]
        [XmlElement("Coordinate", typeof(Coordinate))]
        [XmlElement("CoordinateDouble", typeof(CoordinateDouble))]
        [XmlElement("GeoCoordinate", typeof(GeoCoordinate))]
        [XmlElement("TextureCoordinate", typeof(TextureCoordinate))]
        [XmlElement("TextureCoordinate", typeof(TextureCoordinateGenerator))]
        [XmlElement("NurbsTextureCoordinate", typeof(NurbsTextureCoordinate))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public List<object>? TrimmingContour { get; set; }
        #endregion </xs:choice>

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// NurbsSweptSurface describes a generalized surface that defines a path in 3D space and constant cross section that may be 2D or 3D of the path. 
    /// Conceptually it is the NURBS equivalent of the Extrusion node (see 13.3.5 Extrusion) but permits the use of non-closed cross sections.
    /// </summary>
    public class NurbsSweptSurface : X3DParametricGeometryNode
    {
        #region <xs:choice minOccurs = "0" maxOccurs="2">
        [XmlElement("Coordinate", typeof(ContourPolyline2D))]
        [XmlElement("CoordinateDouble", typeof(NurbsCurve2D))]
        [XmlElement("GeoCoordinate", typeof(NurbsCurve))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public List<object>? CrossSectionCurve { get; set; }
        #endregion </xs:choice>

        [XmlAttribute("ccw")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool CCW { get; set; } = true;

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Solid { get; set; } = true;

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// NurbsSwungSurface describes a generalized surface that defines a path and constant cross section of the path 
    /// </summary>
    public class NurbsSwungSurface : X3DParametricGeometryNode
    {
        #region <xs:choice minOccurs = "0" maxOccurs="2">
        [XmlElement("Coordinate", typeof(ContourPolyline2D))]
        [XmlElement("CoordinateDouble", typeof(NurbsCurve2D))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public List<object>? ProfileCurve { get; set; }
        #endregion </xs:choice>

        [XmlAttribute("ccw")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool CCW { get; set; } = true;

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Solid { get; set; } = true;

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }
}
