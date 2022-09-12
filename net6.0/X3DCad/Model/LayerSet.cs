/*! \file LayerSet.cs
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

namespace X3DCad.Model
{
    public class LayerSet : X3DNode
    {
        //[XmlElement("Layer", typeof(ExternalFileReferencesType))]
        //[XmlElement("LayoutLayer", typeof(ArrayReferenceType))]
        //[XmlElement("ProtoInstance", typeof(ArrayQPIdFullReferenceType))]
        //public object[]? Layers { get; set; }

        [System.ComponentModel.DefaultValueAttribute(0)]
        [XmlAttribute("activeLayer")]
        public int ActiveLayer { get; set; }

        [System.ComponentModel.DefaultValueAttribute(0)]
        [XmlAttribute("order")]
        public int Order { get; set; }

        [System.ComponentModel.DefaultValueAttribute("children")]
        [XmlAttribute("containerField", DataType = "token")]
        public string? ContainerField { get; set; }
    }
}
