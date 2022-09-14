/*! \file X3DProductStructureChildNode.cs
	\brief Base type marking nodes that are valid product structure children for the CADGeometry component.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Base type marking nodes that are valid product structure children for the CADGeometry component.
    /// </summary>
    public class X3DProductStructureChildNode : X3DChildNode
    {
        /// <summary>
        /// name attribute is ordinarily required, unless this is a USE node
        /// </summary>
        [XmlAttribute("name")]
        public string? Name { get; set; }
    }
}
