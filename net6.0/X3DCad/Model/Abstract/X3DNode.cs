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
using X3DCad.Model.Nodes;

namespace X3DCad.Model.Abstract
{
    #region <xs:group name="ChildContentModelInterchange">
    [XmlInclude(typeof(Background))]
    [XmlInclude(typeof(WorldInfo))]
    [XmlInclude(typeof(Viewpoint))]
    #endregion
    #region <xs:group ref="ChildContentModelFull"/>
    [XmlInclude(typeof(CADAssembly))]
    #endregion
    /// <summary>
    /// All instantiable nodes implement X3DNode, which corresponds to SFNode type in the X3D specification.
    /// </summary>
    public abstract class X3DNode : X3DNodeBase
    {
        public X3DNode() { }

        [XmlElement]
        public ISType? IS { get; set; }

        #region xs:group ref="ChildContentModelCore"
        [System.Xml.Serialization.XmlElementAttribute("MetadataBoolean", typeof(MetadataBoolean))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataDouble", typeof(MetadataDouble))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataFloat", typeof(MetadataFloat))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataInteger", typeof(MetadataInteger))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataString", typeof(MetadataString))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataSet", typeof(MetadataSet))]
        public object? Metadata { get; set; }
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

        #region <xs:attributeGroup ref="globalAttributes"/>
        /// <summary>
        /// The class attribute is a space-separated list of classes, reserved for use by Cascading Style Sheets (CSS) and XML stylesheets.
        /// This attribute is only functional if the X3D model is loaded within an HTML page.
        /// </summary>
        [XmlAttribute("class", DataType = "token")]
        public string? Class { get; set; }

        /// <summary>
        /// The id attribute is a unique identifier, reserved for use by HTML5/DOM pages, independent of DEF labeling and internal X3D node referencing.
        /// This attribute is only functional if the X3D model is loaded within an HTML page.
        /// </summary>
        [XmlAttribute("id", DataType = "token")]
        public string? Id { get; set; }

        /// <summary>
        /// The style attribute provides an inline block of CSS for element styling, reserved for use by Cascading Style Sheets (CSS) and XML stylesheets.
        /// This attribute is only functional if the X3D model is loaded within an HTML page.
        /// </summary>
        [XmlAttribute("style", DataType = "string")] //typeof(SFString)
        public string? Style { get; set; }
        #endregion
    }
}
