/*! \file MetaType.cs
	\brief The meta statement provides metadata information about a scene, where name and content attributes provide attribute=value metadata pairs.

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
    /// <summary>
    /// Functional summary: the meta statement provides metadata information about a scene, where name and content attributes provide attribute=value metadata pairs.
    /// </summary>
    public class MetaType : X3DStatement
    {
        #region XML Serialization
        /// <summary>
        /// source="http://www.dublincore.org/documents/dcmi-terms/#terms-description"
        /// </summary>
        [XmlAttribute("name")]
        public string? Name { get; set; }

        /// <summary>
        /// source="http://www.w3.org/TR/html4/struct/global.html#adef-content"
        /// </summary>
        [XmlAttribute("content")]
        public string? Content { get; set; }

        /// <summary>
        /// source="http://www.w3.org/TR/html4/struct/dirlang.html#adef-dir"
        /// </summary>
        [XmlAttribute("dir")]
        public string? Dir { get; set; }

        /// <summary>
        /// source="http://www.w3.org/TR/html4/struct/global.html#adef-http-equiv"
        /// </summary>
        [XmlAttribute("http-equiv")]
        public string? HttpEquiv { get; set; }

        /// <summary>
        /// source="http://www.w3.org/TR/html4/struct/dirlang.html#h-8.1.1"
        /// </summary>
        [XmlAttribute("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// source="http://www.w3.org/TR/html4/struct/global.html#idx-scheme"
        /// </summary>
        [XmlAttribute("scheme")]
        public string? Scheme { get; set; }
        #endregion
    }
}
