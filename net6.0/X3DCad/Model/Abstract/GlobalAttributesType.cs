/*! \file GlobalAttributesType.cs
	\brief Global Attributes

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Global Attributes
    /// </summary>
    public abstract class GlobalAttributesType
    {
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
