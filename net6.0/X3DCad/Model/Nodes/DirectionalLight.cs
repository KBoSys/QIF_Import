/*! \file DirectionalLight.cs
	\brief defines a directional light source that illuminates along rays parallel to a given 3-dimensional vector.

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

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// The DirectionalLight node defines a directional light source that illuminates along rays parallel to a given 3-dimensional vector.
    /// </summary>
    public class DirectionalLight : X3DLightNode
    {
        [XmlIgnore]
        public SFVec3f Direction { get; set; } = new SFVec3f(0, 0, -1);

        [XmlAttribute("direction")]
        [System.ComponentModel.DefaultValueAttribute("0 0 -1")]
        public string? DirectionAsText { get => Direction.ToString(); set => Direction.FromString(value); }

        [XmlAttribute("global")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Global { get; set; } = false;

        [System.ComponentModel.DefaultValueAttribute("children")]
        [XmlAttribute("containerField", DataType = "token")]
        public string? ContainerField { get; set; }
    }
}
