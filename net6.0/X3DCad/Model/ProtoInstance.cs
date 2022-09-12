/*! \file ProtoInstance.cs
	\brief ProtoInstance can override field default values via fieldValue initializations.

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

namespace X3DCad.Model
{
    /// <summary>
    /// ProtoInstance can override field default values via fieldValue initializations.
    /// Non-recursive nested ProtoInstance and ProtoDeclare statements are allowed within a ProtoDeclare.
    /// </summary>
    public class ProtoInstance : X3DPrototypeInstance
    {
        #region <xs:attributeGroup ref="DEF_USE">
        /// <summary>
        /// DEF defines a unique ID name for each node, referenceable by other nodes.
        /// </summary>
        [XmlAttribute(DataType = "ID")]
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

        /// <summary>
        /// name attribute is ordinarily required, unless this is a USE node
        /// </summary>
        [XmlAttribute("name", DataType = "token")]
        public string? Name { get; set; }

        [System.ComponentModel.DefaultValueAttribute("children")]
        [XmlAttribute("containerField", DataType = "token")]
        public string? ContainerField { get; set; }
    }
}
