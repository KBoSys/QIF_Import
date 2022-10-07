/*! \file Color.cs
	\brief Defines a set of RGB colours to be used in the fields of another node.

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
using X3DCad.Model.Types;

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// Base type for color specifications in X3D.
    /// </summary>
    public abstract class X3DColorNode : X3DGeometricPropertyNode
    {
    }

    /// <summary>
    /// containerFieldChoicesColor lists the allowed containerField enumeration values for Color and ColorRGBA nodes: 
    /// default "color" if parent node is a geometry node, otherwise "colorRamp" if parent node is ParticleSystem.
    /// </summary>
    public enum ContainerFieldChoicesColor
    {
        /// <summary>
        /// parent node is a geometry node
        /// </summary>
        color,

        /// <summary>
        /// parent node is ParticleSystem
        /// </summary>
        colorRamp
    }

    /// <summary>
    /// Base class for Color and ColorRGBA
    /// </summary>
    public class ColorBase : X3DColorNode
    {
        [XmlAttribute("containerField")]
        [System.ComponentModel.DefaultValueAttribute(ContainerFieldChoicesColor.color)]
        public ContainerFieldChoicesColor Type { get; set; } = ContainerFieldChoicesColor.color;
    }

    /// <summary>
    /// This node defines a set of RGB colours to be used in the fields of another node.
    /// </summary>
    public class Color : ColorBase
    {
        [XmlIgnore]
        public MFColor? Value { get; set; }

        //<xs:attribute name = "color" type="MFColor"/>
        [XmlAttribute("color")]
        public string? ColorAsText 
        { 
            get => Value?.ToString(); 
            set
            {
                Value = new MFColor();
                Value.FromString(value);
            }
        }
    }

    /// <summary>
    /// Alpha value optionally supported until Rendering component level 4
    /// </summary>
    public class ColorRGBA : ColorBase
    {
    }
}
