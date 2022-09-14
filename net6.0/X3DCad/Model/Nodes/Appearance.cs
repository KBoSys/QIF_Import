/*! \file Appearance.cs
	\brief The Appearance node specifies the visual properties of geometry. The value for each of the fields in this node may be NULL. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;
using X3DCad.Model.Types;

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// Permitted values for Appearance alphaMode field. This list is bounded, no additional values are allowed.
    /// </summary>
    public enum AlphaModeChoices
    {
        /// <summary>
        /// Material transparency is applied to texture transparency
        /// </summary>
        AUTO,

        /// <summary>
        /// Ignore alpha channel texture transparency, opaque
        /// </summary>
        OPAQUE,

        /// <summary>
        /// Alpha-testing mode for transparent when alpha value less than 0.5 and opaque when greater than or equal to 0.5
        /// </summary>
        MASK,

        /// <summary>
        /// Blend combines partial transparency of textures and materials
        /// </summary>
        BLEND,
    }

    /// <summary>
    /// The Appearance node specifies the visual properties of geometry. The value for each of the fields in this node may be NULL. 
    /// However, if the field is non-NULL, it shall contain one node of the appropriate type.
    /// </summary>
    public class Appearance : X3DAppearanceNode
    {
        private unitIntervalType alphaCutoffField = new unitIntervalType(0.5f);

        [XmlAttribute("alphaCutoff")]
        [System.ComponentModel.DefaultValueAttribute(0.5f)]
        public float AlphaCutoff { get => alphaCutoffField; set => alphaCutoffField = value; }

        [XmlAttribute("alphaMode")]
        [System.ComponentModel.DefaultValueAttribute(AlphaModeChoices.AUTO)]
        public AlphaModeChoices AlphaMode { get; set; }

        [XmlAttribute("containerField")]
        [System.ComponentModel.DefaultValueAttribute("appearance")]
        public string? Container { get; set; }
    }
}
