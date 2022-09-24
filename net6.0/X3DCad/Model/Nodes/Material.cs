/*! \file Material.cs
	\brief The Material node specifies surface material properties for associated geometry nodes.

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
    /// The Material node specifies surface material properties for associated geometry nodes.
    /// The material parameters are specified as scalars or RGB colors in the X3D file. All of the SFFloat and SFColor fields in the Material node range from 0.0 to 1.0.
    /// </summary>
    public class Material : X3DOneSidedMaterialNode
    {
        #region Fields
        private unitIntervalType ambientIntensityField = 0.2f;
        private unitIntervalType occlusionStrengthField = 1;
        private unitIntervalType shininessField = 0.2f;
        private unitIntervalType transparencyField = 0;
        #endregion 

        #region Properties
        [XmlIgnore]
        public SFColor DiffuseColor { get; set; } = new SFColor(0.8f, 0.8f, 0.8f);

        [XmlIgnore]
        public SFColor EmissiveColor { get; set; } = new SFColor(0, 0, 0);

        [XmlIgnore]
        public SFColor SpecularColor { get; set; } = new SFColor(0, 0, 0);
        #endregion 

        #region Serialization
        //<!-- strictly one of each field, any order -->
        [XmlElement("ImageTexture", typeof(ImageTexture))]
        [XmlElement("MovieTexture", typeof(MovieTexture))]
        [XmlElement("PixelTexture", typeof(PixelTexture))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public object[]? Texture { get; set; }

        [XmlAttribute("ambientIntensity")]
        [System.ComponentModel.DefaultValueAttribute(0.2f)]
        public float AmbientIntensity { get => ambientIntensityField; set => ambientIntensityField = value; }

        [XmlAttribute("ambientTextureMapping", DataType = "token")]
        public string? AmbientTextureMapping { get; set; }

        [XmlAttribute("diffuseColor", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("0.8 0.8 0.8")]
        public string? DiffuseColorAsText { get => DiffuseColor.ToString(); set => DiffuseColor.FromString(value); }

        [XmlAttribute("diffuseTextureMapping", DataType = "token")]
        public string? DiffuseTextureMapping { get; set; }

        [XmlAttribute("emissiveColor", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("0 0 0")]
        public string? EmissiveColorAsText { get => EmissiveColor.ToString(); set => EmissiveColor.FromString(value); }

        [XmlAttribute("occlusionStrength")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float OcclusionStrength { get => occlusionStrengthField; set => occlusionStrengthField = value; }

        [XmlAttribute("occlusionTextureMapping", DataType = "token")]
        public string? OcclusionTextureMapping { get; set; }

        [XmlAttribute("shininess")]
        [System.ComponentModel.DefaultValueAttribute(0.2f)]
        public float Shininess { get => shininessField; set => shininessField = value; }

        [XmlAttribute("shininessTextureMapping", DataType = "token")]
        public string? ShininessTextureMapping { get; set; }

        [XmlAttribute("specularColor", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("0 0 0")]
        public string? SpecularColorAsText { get => SpecularColor.ToString(); set => SpecularColor.FromString(value); }

        [XmlAttribute("specularTextureMapping", DataType = "token")]
        public string? SpecularTextureMapping { get; set; }

        [XmlAttribute("transparency")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public float Transparency { get => transparencyField; set => transparencyField = value; }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("material")]
        public string? Container { get; set; }
        #endregion 
    }
}
