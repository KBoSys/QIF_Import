/*! \file CADAssembly.cs
	\brief 

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

namespace X3DCad.Model.Nodes
{
    public class CADAssembly : X3DGroupingNode
    {
        public CADAssembly() {}
        public CADAssembly(string name) { Name = name; }

        /// <summary>
        /// name attribute is ordinarily required, unless this is a USE node
        /// </summary>
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [System.ComponentModel.DefaultValueAttribute("children")]
        [XmlAttribute("containerField", DataType = "token")]
        public string? ContainerField { get; set; }
    }
}
