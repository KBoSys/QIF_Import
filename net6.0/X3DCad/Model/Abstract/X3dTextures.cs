/*! \file X3DTexture2DNode.cs
	\brief Base classes for texture nodes 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Nodes;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Base type for all nodes which specify sources for texture images.
    /// </summary>
    public abstract class X3DTextureNode : X3DAppearanceChildNode
    {
        [XmlAttribute("description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// Base type for all texture node types that define a single texture.
    /// A single texture can be used to influence a parameter of various material nodes in the Shape component, and it can be a child of MultiTexture.
    /// </summary>
    public abstract class X3DSingleTextureNode : X3DTextureNode
    {
    }

    /// <summary>
    /// Base type for all nodes which specify 2D sources for texture images.
    /// </summary>
    public abstract class X3DTexture2DNode : X3DSingleTextureNode
    {
        // TODO
        //<xs:choice minOccurs = "0" >
        //    < xs:element ref="TextureProperties"/>
        //    <xs:element ref="ProtoInstance">

        //<xs:attribute name = "repeatS" type="SFBool" default="true"/>
        //<xs:attribute name = "repeatT" type="SFBool" default="true"/>
    }

    /// <summary>
    /// Base type from which all time-dependent nodes are derived.
    /// </summary>
    public abstract class X3DTimeDependentNode : X3DChildNode
    {
        // TODO
        //<xs:attribute name = "description" type="SFString"/>
        //<xs:attribute name = "pauseTime" type="SFTime" default="0">
        //<xs:attribute name = "resumeTime" type="SFTime" default="0">
        //<xs:attribute name = "startTime" type="SFTime" default="0"/>
        //<xs:attribute name = "stopTime" type="SFTime" default="0"/>
    }

    /// <summary>
    /// 
    /// </summary>
    public abstract class X3DSoundSourceNode : X3DTimeDependentNode
    {
        [XmlAttribute("enabled")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Enabled { get; set; } = true;

        [XmlAttribute("gain")]
        [System.ComponentModel.DefaultValueAttribute(1.0f)]
        public float Gain { get; set; } = 1.0f;
    }
}
