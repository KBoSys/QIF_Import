/*! \file CADGroup.cs
	\brief A Group node contains children nodes without introducing a new transformation. 

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
    /// A Group node contains children nodes without introducing a new transformation. 
    /// It is equivalent to a Transform node containing an identity transform.
    /// </summary>
    public class CADGroup : X3DGroupingNode
    {
        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("children")]
        public string? ContainerField { get; set; }
    }
}
