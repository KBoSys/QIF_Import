/*! \file X3DNode.cs
	\brief All instantiable nodes implement X3DNode, which corresponds to SFNode type in the X3D specification.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;
using X3DCad.Model.Metadata;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// All instantiable nodes implement X3DNode, which corresponds to SFNode type in the X3D specification.
    /// </summary>
    public abstract class X3DNode : GlobalAttributesType
    {
        [XmlElement]
        public ISType? IS { get; set; }

        #region xs:group ref="ChildContentModelCore"
        [System.Xml.Serialization.XmlElementAttribute("MetadataBoolean", typeof(MetadataBoolean))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataDouble", typeof(MetadataDouble))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataFloat", typeof(MetadataFloat))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataInteger", typeof(MetadataInteger))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataString", typeof(MetadataString))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataSet", typeof(MetadataSet))]
        public object[]? ChildContent { get; set; }
        #endregion

        #region <xs:attributeGroup name="DEF_USE">
        /// <summary>
        /// DEF defines a unique ID name for each node, referenceable by other nodes.
        /// </summary>
        [XmlAttribute(DataType ="ID")]
        public string? DEF { get; set; }

        /// <summary>
        /// USE means reuse an already DEF-ed node ID, excluding all child nodes and all other attributes (except for containerField, which can have a different value).
        /// </summary>
        [XmlAttribute(DataType = "IDREF")]
        public string? USE { get; set; }
        #endregion
    }
}
