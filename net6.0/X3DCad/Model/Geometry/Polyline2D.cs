/*! \file Polyline2D.cs
	\brief Specifies a series of contiguous line segments in the local 2D coordinate system connecting the specified vertices.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;
using X3DCad.Model.Types;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The Polyline2D node specifies a series of contiguous line segments in the local 2D coordinate system connecting the specified vertices.
    /// </summary>
    public class Polyline2D : GeometryBase
    {
        /// <summary>
        /// The lineSegments field specifies the vertices to be connected.
        /// </summary>
        [XmlIgnore]
        public MFVec2f LineSegments { get; set; } = new MFVec2f();

        [XmlAttribute("lineSegments")]
        public string? LineSegmentsAsText { get => LineSegments.ToString(); set => LineSegments.FromString(value); }
    }

    /// <summary>
    /// The Polyline2D node specifies a set of vertices in the local 2D coordinate system at each of which is displayed a point.
    /// </summary>
    public class Polypoint2D : GeometryBase
    {
        /// <summary>
        /// The points field specifies the vertices to be displayed.
        /// </summary>
        [XmlIgnore]
        public MFVec2f Points { get; set; } = new MFVec2f();

        [XmlAttribute("point")]
        public string? PointsAsText { get => Points.ToString(); set => Points.FromString(value); }
    }
}
