/*! \file X3DAppearanceNode.cs
	\brief Base type for all Appearance nodes.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Base type for all Appearance nodes.
    /// </summary>
    public class X3DAppearanceNode : X3DNode
    {
        /// <summary>
        /// Child-node content model corresponding to X3DAppearanceChildNode.  
        /// Appearance can contain FillProperties, LineProperties, PointProperties, Material, PhysicalMaterial, UnlitMaterial or TwoSidedMaterial, 
        /// any Texture node and any TextureTransform node, in any order. Appearance may also contain multiple shaders (ComposedShader, PackagedShader, ProgramShader).
        /// </summary>

        #region <xs:group ref="AppearanceChildContentModelNoProtoInstance"/>
        // TODO:
        //AcousticProperties
        // FillProperties
        //LineProperties
        //PointProperties
        //PhysicalMaterial
        //UnlitMaterial
        //TwoSidedMaterial
        //ComposedShader
        //PackagedShader
        //ProgramShader
        //ComposedCubeMapTexture
        //ComposedTexture3D
        //ImageTexture
        //ImageTexture3D
        //MovieTexture
        //MultiTexture
        //PixelTexture
        //PixelTexture3D
        //GeneratedCubeMapTexture
        //ImageCubeMapTexture
        //MultiTextureTransform
        //TextureTransform
        //TextureTransform3D
        //TextureTransformMatrix3D
        #endregion
        [XmlElement("Material", typeof(Material))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public object? Item { get; set; }
    }
}
