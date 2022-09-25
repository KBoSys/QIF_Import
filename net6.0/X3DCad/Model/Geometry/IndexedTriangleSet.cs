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
    /// The IndexedTriangleSet node represents a 3D shape composed of a collection of individual triangles
    /// </summary>
    public class IndexedTriangleSet : X3DComposedGeometryNode
    {
        [XmlIgnore]
        public MFInt32 Index { get; set; } = new MFInt32();

        [XmlAttribute("index")]
        public string? IndexAsText { get => Index.ToString(); set => Index.FromString(value); }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// An IndexedTriangleFanSet represents a 3D shape composed of triangles that form a fan shape around the first vertex declared in each fan
    /// </summary>
    public class IndexedTriangleFanSet : IndexedTriangleSet
    {
   }
}
