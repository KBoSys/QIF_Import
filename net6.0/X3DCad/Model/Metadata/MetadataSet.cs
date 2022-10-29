/*! \file MetadataSet.cs
	\brief The metadata provided by this node is contained in the metadata nodes of the value field.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model.Metadata
{
    /// <summary>
    /// The metadata provided by this node is contained in the metadata nodes of the value field.
    /// </summary>
    public class MetadataSet : GlobalAttributesType
    {
        /// <summary>
        /// name attribute is ordinarily included, unless this is a USE node or else contained within a special metadata taxonomy
        /// </summary>
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// Default containerField='metadata' when providing information about the parent element itself, 
        /// otherwise apply containerField='value' when this element contains payload metadata inside a parent/ancestor MetadataSet element.
        /// </summary>
        [XmlAttribute("containerField")]
        [System.ComponentModel.DefaultValueAttribute(ContainerFieldChoicesMetadata.Metadata)]
        public ContainerFieldChoicesMetadata ContainerField { get; set; } = ContainerFieldChoicesMetadata.Metadata;

        [XmlElement]
        public ISType? IS { get; set; }

        #region xs:group ref="ChildContentModelCore"
        [System.Xml.Serialization.XmlElementAttribute("MetadataBoolean", typeof(MetadataBoolean))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataDouble", typeof(MetadataDouble))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataFloat", typeof(MetadataFloat))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataInteger", typeof(MetadataInteger))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataString", typeof(MetadataString))]
        [System.Xml.Serialization.XmlElementAttribute("MetadataSet", typeof(MetadataSet))]
        #endregion
        [System.Xml.Serialization.XmlElementAttribute("ProtoInstance", typeof(ProtoInstance))]
        public List<object> ChildContent { get; set; } = new List<object>();

        #region <xs:attributeGroup name="DEF_USE">
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
    }
}
