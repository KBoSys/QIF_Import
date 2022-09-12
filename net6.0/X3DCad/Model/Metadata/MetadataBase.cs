/*! \file MetadataBase.cs
	\brief Meta data types

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
    /// containerFieldChoicesMetadata lists the allowed containerField enumeration values for Metadata nodes: 
    /// "value" if providing information and parent node is MetadataSet collection, otherwise default "metadata" if providing information about parent node.
    /// </summary>
    public enum ContainerFieldChoicesMetadata
    {
        /// <summary>
        /// this node provides metadata information regarding its parent node.
        /// </summary>
        [XmlEnumAttribute("metadata")]
        Metadata,

        /// <summary>
        /// parent node is MetadataSet, this node is providing information as part of a MetadataSet collection.
        /// </summary>
        [XmlEnumAttribute("value")]
        Value,
    }

    /// <summary>
    /// The metadata provided by this node is contained in the Boolean values of the value field.
    /// </summary>
    public class MetadataBase : X3DNode 
    {
        private ContainerFieldChoicesMetadata containerFieldChoicesMetadata;

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
        public string? ContainerField
        {
            get => containerFieldChoicesMetadata.ToString();
            set
            {
                Enum.TryParse(value, out containerFieldChoicesMetadata);
            }
        }
    }

    public class MetadataBaseNonNullable<T> : MetadataBase where T : struct
    {
        [XmlAttribute("value")]
        public T Value { get; set; }
    }

    public class MetadataBaseNullable<T> : MetadataBase where T : class
    {
        [XmlAttribute("value")]
        public T? Value { get; set; }
    }

    /// <summary>
    /// The metadata provided by this node is contained in the Boolean values of the value field.
    /// </summary>
    public class MetadataBoolean : MetadataBaseNonNullable<bool>
    {
    }

    /// <summary>
    /// The metadata provided by this node is contained in the Double values of the value field.
    /// </summary>
    public class MetadataDouble : MetadataBaseNonNullable<double>
    {
    }

    /// <summary>
    /// The metadata provided by this node is contained in the Float values of the value field.
    /// </summary>
    public class MetadataFloat : MetadataBaseNonNullable<float>
    {
    }

    /// <summary>
    /// The metadata provided by this node is contained in the integer numbers of the value field.
    /// </summary>
    public class MetadataInteger : MetadataBaseNonNullable<int>
    {
    }

    /// <summary>
    /// The metadata provided by this node is contained in the strings of the value field.
    /// </summary>
    public class MetadataString : MetadataBaseNullable<string>
    {
    }
}
