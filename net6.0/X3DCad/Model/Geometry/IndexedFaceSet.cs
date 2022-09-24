/*! \file IndexedFaceSet.cs
	\brief The IndexedFaceSet node represents a 3D shape formed by constructing faces (polygons) from vertices listed in the coord field

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The IndexedFaceSet node represents a 3D shape formed by constructing faces (polygons) from vertices listed in the coord field
    /// </summary>
    public class IndexedFaceSet : X3DComposedGeometryNode
    {
        [XmlAttribute("convex")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Convex { get; set; } = true;

        [XmlAttribute("creaseAngle")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public float CreaseAngle { get; set; }

        // TODO: MFInt32
        [XmlAttribute("colorIndex")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public int[]? ColorIndex { get; set; }

        [XmlAttribute("coordIndex")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public int[]? CoordIndex { get; set; }

        [XmlAttribute("normalIndex")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public int[]? NormalIndex { get; set; }

        [XmlAttribute("texCoordIndex")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public int[]? TexCoordIndex { get; set; }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }
}
