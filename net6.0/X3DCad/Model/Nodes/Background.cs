/*! \file Background.cs
	\brief A background node

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// A background node that uses six static images to compose the backdrop
    /// </summary>
    public class Background : X3DBackgroundNode
    {
        public Background() { }

        [XmlAttribute("backUrl")]
        public string? BackUrl { get; set; }

        [XmlAttribute("bottomUrl")]
        public string? BottomUrl { get; set; }

        [XmlAttribute("frontUrl")]
        public string? FrontUrl { get; set; }

        [XmlAttribute("leftUrl")]
        public string? LeftUrl { get; set; }

        [XmlAttribute("rightUrl")]
        public string? RightUrl { get; set; }

        [XmlAttribute("topUrl")]
        public string? TopUrl { get; set; }

        [System.ComponentModel.DefaultValueAttribute("children")]
        [XmlAttribute("containerField", DataType = "token")]
        public string? ContainerField { get; set; }
    }
}
