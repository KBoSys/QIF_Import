/*! \file CADLayer.cs
	\brief The CADLayer node defines a hierarchy of nodes used for showing layer structure for the CAD model.

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
    /// The CADLayer node defines a hierarchy of nodes used for showing layer structure for the CAD model.
    /// </summary>
    public class CADLayer : X3DGroupingNode
    {
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("children")]
        public string? Container { get; set; }
    }
}
