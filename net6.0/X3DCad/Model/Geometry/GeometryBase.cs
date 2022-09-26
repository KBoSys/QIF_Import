/*! \file GeometryBase.cs
	\brief Base class for Geometry Nodes

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

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// Base class for Geometry Nodes
    /// </summary>
    public abstract class GeometryBase : X3DGeometryNode
    {
        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// Base class for 3D Geometry Nodes
    /// </summary>
    public abstract class Geometry3DBase : GeometryBase
    {
        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Solid { get; set; } = true;
    }
}
