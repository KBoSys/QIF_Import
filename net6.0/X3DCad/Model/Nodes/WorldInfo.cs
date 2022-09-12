/*! \file X3DInfoNode.cs
	\brief WorldInfo contains a title and simple persistent metadata information about an X3D scene.

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

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// WorldInfo contains a title and simple persistent metadata information about an X3D scene.
    /// This node is strictly for documentation purposes and has no effect on the visual appearance or behaviour of the world.
    /// </summary>
    public class WorldInfo : X3DInfoNode
    {
        [XmlAttribute("info", DataType = "token")]
        public string? Info { get; set; }

        [XmlAttribute("title", DataType = "token")]
        public string? Title { get; set; }

        [System.ComponentModel.DefaultValueAttribute("children")]
        [XmlAttribute("containerField", DataType = "token")]
        public string? ContainerField { get; set; }
    }
}
