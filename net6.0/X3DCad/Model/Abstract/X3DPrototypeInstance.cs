/*! \file X3DPrototypeInstance.cs
	\brief Base type for all prototype instances.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Metadata;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Base type for all prototype instances.
    /// Note that direct children nodes are disallowed, instead let fieldValue with type SFNode/MFNode contain them.
    /// Current practice is that, if desired, prototype authors must explicitly add the metadata SFNode field in the ProtoInterface.
    /// </summary>
    public class X3DPrototypeInstance
    {
        [XmlElement("fieldValue", typeof(FieldValueType))]
        public FieldValueType[]? FieldValue { get; set; }

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
    }
}
