/*! \file LineSet.cs
	\brief Represents a 3D geometry formed by constructing polylines from 3D vertices specified in the coord field.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Types;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The LineSet node represents a 3D geometry formed by constructing polylines from 3D vertices specified in the coord field.
    /// </summary>
    public class LineSet : PointSet
    {
        /// <summary>
        /// The vertexCount field describes how many vertices are to be used in each polyline from the coordinate field. 
        /// Coordinates are assigned to each line by taking vertexCount[n] vertices from the coordinate field. 
        /// Each value of the vertexCount array shall be greater than or equal to two. 
        /// It shall be an error to have a value less than two.
        /// </summary>
        [XmlIgnore]
        public MFInt32 VertexCount { get; set; } = new MFInt32();

        [XmlAttribute("vertexCount")]
        public string? VertexCountAsText { get => VertexCount.ToString(); set => VertexCount.FromString(value); }
    }

    /// <summary>
    /// The IndexedLineSet node represents a 3D geometry formed by constructing polylines from 3D vertices specified in the coord field. 
    /// IndexedLineSet uses the indices in its coordIndex field to specify the polylines by connecting vertices from the coord field. 
    /// An index of "-1" indicates that the current polyline has ended and the next one begins. 
    /// The last polyline may be (but does not have to be) followed by a "-1". 
    /// IndexedLineSet is specified in the local coordinate system and is affected by the transformations of its ancestors.
    /// </summary>
    public class IndexedLineSet : PointSet
    {
        /// <summary>
        /// </summary>
        [XmlIgnore]
        public MFInt32 ColorIndex { get; set; } = new MFInt32();

        [XmlIgnore]
        public MFInt32 CoordIndex { get; set; } = new MFInt32();

        [XmlAttribute("colorPerVertex")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool ColorPerVertex { get; set; } = true;

        [XmlAttribute("colorIndex")]
        public string? ColorIndexAsText { get => ColorIndex.ToString(); set => ColorIndex.FromString(value); }

        [XmlAttribute("coordIndex")]
        public string? CoordIndexAsText { get => CoordIndex.ToString(); set => CoordIndex.FromString(value); }
    }
}
