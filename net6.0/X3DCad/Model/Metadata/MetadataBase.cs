﻿/*! \file MetadataBase.cs
	\brief Meta data types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    [XmlInclude(typeof(MetadataBoolean))]
    [XmlInclude(typeof(MetadataDouble))]
    [XmlInclude(typeof(MetadataFloat))]
    [XmlInclude(typeof(MetadataInteger))]
    [XmlInclude(typeof(MetadataString))]
    [XmlInclude(typeof(MetadataSet))]
    public class MetadataBase : X3DNode 
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
    }

    public class MetadataBaseNonNullable<T> : MetadataBase where T : struct
    {
        [XmlAttribute("value")]
        public T Value { get; set; }
    }

    public class MetadataBaseNullable<T> : MetadataBase where T : class
    {
        [XmlIgnore]
        public List<T> Value { get; set; } = new List<T>();

        [XmlAttribute("value")]
        public string? ValueAsText { get => ToString(); set => FromString(value); }

        #region String Helpers
        public override string? ToString()
        {
            return string.Join(" ", Value);
        }

        public void FromString(string? input)
        {
            Value.Clear();

            string[]? parts = input?.Split(' ');
            if (parts != null && parts.Length > 0)
            {
                for (int i = 0; i < parts.Length; ++i)
                {
                    try
                    {
                        var converter = TypeDescriptor.GetConverter(typeof(T));
                        if (converter != null)
                        {
                            object? val = converter.ConvertFromString(parts[i]);
                            if (val != null)
                            {
                                Value.Add((T)val);
                            }
                        }
                    }
                    finally
                    {
                    }
                }
            }
        }
        #endregion String Helpers
    }

    /// <summary>
    /// The metadata provided by this node is contained in the Boolean values of the value field.
    /// </summary>
    public class MetadataBoolean : MetadataBaseNonNullable<bool>
    {
        public MetadataBoolean() { }
    }

    /// <summary>
    /// The metadata provided by this node is contained in the Double values of the value field.
    /// </summary>
    public class MetadataDouble : MetadataBaseNonNullable<double>
    {
        public MetadataDouble() { }
    }

    /// <summary>
    /// The metadata provided by this node is contained in the Float values of the value field.
    /// </summary>
    public class MetadataFloat : MetadataBaseNonNullable<float>
    {
        public MetadataFloat() { }
    }

    /// <summary>
    /// The metadata provided by this node is contained in the integer numbers of the value field.
    /// </summary>
    public class MetadataInteger : MetadataBaseNonNullable<int>
    {
        public MetadataInteger() { }
    }

    /// <summary>
    /// The metadata provided by this node is contained in the strings of the value field.
    /// </summary>
    public class MetadataString : MetadataBaseNullable<string>
    {
        public MetadataString() { }
    }
}
