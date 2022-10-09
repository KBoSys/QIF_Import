/*! \file IndexedTriangleSet.cs
	\brief Represents a 3D shape composed of a collection of individual triangles

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;
using X3DCad.Model.Types;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The TriangleSet2D node specifies a set of triangles in the local 2D coordinate system.
    /// </summary>
    public class TriangleSet2D : Geometry3DBase
    {
        [XmlIgnore]
        public MFVec2f Vertices { get; set; } = new MFVec2f();

        [XmlAttribute("vertices")]
        public string? VerticesAsText { get => Vertices.ToString(); set => Vertices.FromString(value); }
    }

    /// <summary>
    /// The TriangleSet node represents a 3D shape that represents a collection of individual triangles.
    /// </summary>
    public class TriangleSet : ComposedGeometryBase
    {
    }

    /// <summary>
    /// The IndexedTriangleSet node represents a 3D shape composed of a collection of individual triangles
    /// </summary>
    public class IndexedTriangleSet : ComposedGeometryBase
    {
        [XmlIgnore]
        public MFInt32 Index { get; set; } = new MFInt32();

        [XmlAttribute("index")]
        public string? IndexAsText { get => Index.ToString(); set => Index.FromString(value); }
    }

    /// <summary>
    /// An IndexedTriangleFanSet represents a 3D shape composed of triangles that form a fan shape around the first vertex declared in each fan
    /// </summary>
    public class IndexedTriangleFanSet : IndexedTriangleSet
    {
    }

    /// <summary>
    /// An IndexedTriangleStripSet represents a 3D shape composed of strips of triangles. 
    /// IndexedTriangleStripSet uses the indices in its index field to specify the triangle strips by connecting vertices from the coord field. 
    /// An index of "−1" indicates that the current strip has ended and the next one begins. 
    /// The last strip may be (but does not have to be) followed by a "−1". Each strip shall have at least three non-coincident vertices.
    /// </summary>
    public class IndexedTriangleStripSet : IndexedTriangleSet
    {
    }

    /// <summary>
    /// A TriangleFanSet represents a 3D shape composed of triangles that form a fan shape around the first vertex declared in each fan.
    /// </summary>
    public class TriangleFanSet : ComposedGeometryBase
    {
        /// <summary>
        /// The fanCount field describes how many vertices are to be used in each fan from the coordinate field. 
        /// Coordinates are assigned to each strip by taking fanCount[n] vertices from the coordinate field. 
        /// Each value of the fanCount array shall be greater than or equal to three. 
        /// It shall be an error to have a value less than three.
        /// </summary>
        [XmlIgnore]
        public MFInt32 FanCount { get; set; } = new MFInt32();

        [XmlAttribute("fanCount")]
        public string? FanCountText { get => FanCount.ToString(); set => FanCount.FromString(value); }
    }

    /// <summary>
    /// A TriangleStripSet represents a 3D shape composed of strips of triangles.
    /// </summary>
    public class TriangleStripSet : ComposedGeometryBase
    {
        /// <summary>
        /// The stripCount field describes how many vertices are to be used in each strip from the coordinate field. 
        /// Coordinates are assigned to each strip by taking stripCount[i] vertices from the coordinate field, where i is a sequential index of stripCount. 
        /// Each value of the stripCount array shall be greater than or equal to three. It shall be an error to have a value less than three. 
        /// </summary>
        [XmlIgnore]
        public MFInt32 StripCount { get; set; } = new MFInt32();

        [XmlAttribute("stripCount")]
        public string? StripCountText { get => StripCount.ToString(); set => StripCount.FromString(value); }
    }
}
