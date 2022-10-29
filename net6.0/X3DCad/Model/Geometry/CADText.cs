/*! \file CADText.cs
	\brief The Text node specifies a two-sided (by default), flat text string object positioned in the Z=0 plane of the local coordinate system

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;
using X3DCad.Model.Nodes;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The Text node specifies a two-sided (by default), flat text string object positioned in the Z=0 plane of the local coordinate system
    /// </summary>
    public class CADText : X3DGeometryNode
    {
        /// <summary>
        /// TextChildContentModel is the child-node content model utilized by Text.  
        /// TextChildContentModel can contain a single FontStyle or ScreenFontStyle node.
        /// </summary>
        #region <xs:group ref="TextChildContentModel"/>
        [XmlElement("FontStyle", typeof(FontStyle))]
        [XmlElement("ScreenFontStyle", typeof(ScreenFontStyle))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public object? Font { get; set; }
        #endregion 

        [XmlAttribute("string")]
        public string[]? Text { get; set; }

        [XmlAttribute("length")]
        public float[]? Length { get; set; }

        [XmlAttribute("maxExtent")]
        [System.ComponentModel.DefaultValueAttribute(0.0f)]
        public float MaxExtent { get; set; } = 0.0f;

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Solid { get; set; } = false;
    }
}
