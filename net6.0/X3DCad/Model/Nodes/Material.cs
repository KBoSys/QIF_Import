/*! \file Material.cs
	\brief The Material node specifies surface material properties for associated geometry nodes.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X3DCad.Model.Abstract;

namespace X3DCad.Model.Nodes
{
    /// <summary>
    /// The Material node specifies surface material properties for associated geometry nodes.
    /// The material parameters are specified as scalars or RGB colors in the X3D file. All of the SFFloat and SFColor fields in the Material node range from 0.0 to 1.0.
    /// </summary>
    public class Material : X3DOneSidedMaterialNode
    {
        //<!-- TODO strictly one of each field, any order -->
        //<xs:element ref="ImageTexture"/>
        //<xs:element ref="MovieTexture"/>
        //<xs:element ref="PixelTexture"/>
        //<xs:element ref="ProtoInstance">

        //<xs:attribute name = "ambientIntensity" type="unitIntervalType" default="0.2">
        //<xs:attribute name = "ambientTextureMapping" type="xs:NMTOKEN">
        //<xs:attribute name = "diffuseColor" type="SFColor" default="0.8 0.8 0.8"/>
        //<xs:attribute name = "diffuseTextureMapping" type="xs:NMTOKEN"/>
        //<xs:attribute name = "emissiveColor" type="SFColor" default="0 0 0">
        //<xs:attribute name = "occlusionStrength" type="unitIntervalType" default="1"/>
        //<xs:attribute name = "occlusionTextureMapping" type="xs:NMTOKEN"/>
        //<xs:attribute name = "shininess" type="unitIntervalType" default="0.2">
        //<xs:attribute name = "shininessTextureMapping" type="xs:NMTOKEN"/>
        //<xs:attribute name = "specularColor" type="SFColor" default="0 0 0">
        //<xs:attribute name = "specularTextureMapping" type="xs:NMTOKEN"/>
        //<xs:attribute name = "transparency" type="unitIntervalType" default="0">
        //<xs:attribute name = "containerField" type="xs:NMTOKEN" default="material"/>
    }
}
