/*! \file ComposedGeometryBase.cs
	\brief Base class for Composed Geometries

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
    /// Base class for Composed Geometries
    /// </summary>
    public abstract class ComposedGeometryBase : X3DComposedGeometryNode
    {
        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("geometry")]
        public string? Container { get; set; }
    }
}
