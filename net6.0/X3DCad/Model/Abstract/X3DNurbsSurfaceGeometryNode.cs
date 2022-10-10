/*! \file X3DNurbsSurfaceGeometryNode.cs
	\brief Abstract geometry type for all types of NURBS surfaces.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Geometry;
using X3DCad.Model.Types;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Abstract geometry type for all types of NURBS surfaces.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NurbsPatchSurface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NurbsTrimmedSurface))]
    public abstract class X3DNurbsSurfaceGeometryNode : X3DParametricGeometryNode
    {
        [XmlAttribute("uClosed")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UClosed { get; set; } = false;

        [XmlAttribute("vClosed")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool VClosed { get; set; } = false;

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

        [XmlAttribute("uTessellation")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public Int32 UTessellation { get; set; } = 0;

        [XmlAttribute("vTessellation")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public Int32 VTessellation { get; set; } = 0;

        [XmlAttribute("weight")]
        public double Weight { get; set; }

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Solid { get; set; } = true;
    }

    /// <summary>
    /// Base type for all nodes that provide control curve information in 2D space
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContourPolyline2D))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NurbsCurve2D))]
    public abstract class X3DNurbsControlCurveNode : X3DNode
    {
        [XmlIgnore]
        public MFVec2f ControlPoint { get; set; } = new MFVec2f();

        [XmlAttribute("controlPoint")]
        public string? ControlPointAsText { get => ControlPoint.ToString(); set => ControlPoint.FromString(value); }
    }
}
