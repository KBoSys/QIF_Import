/*! \file Coordinate.cs
	\brief This node defines a set of 3D coordinates to be used in the coord field of vertex-based geometry

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

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// containerFieldChoicesX3DCoordinateNode lists the allowed containerField enumeration values for Coordinate and CoordinateDouble nodes: 
    /// default "coord" if parent node is a geometry node, otherwise skinCoord or skinBindingCoords if parent node is HAnimHumanoid
    /// </summary>
    public enum ContainerFieldChoicesX3DCoordinateNode
    {
        /// <summary>
        /// parent node is a geometry node
        /// </summary>
        coord,

        /// <summary>
        /// parent node is a Nurbs node
        /// </summary>
        controlPoint,

        /// <summary>
        /// parent node is HAnimHumanoid
        /// </summary>
        skinCoord,

        /// <summary>
        /// parent node is HAnimHumanoid, added in X3D version 4
        /// </summary>
        skinBindingCoords,
    }

    /// <summary>
    /// This node defines a set of 3D coordinates to be used in the coord field of vertex-based geometry
    /// </summary>
    [XmlInclude(typeof(Coordinates))]
    [XmlInclude(typeof(ControlPoints))]
    public class CoordinatesBase : X3DCoordinateNode
    {
        public CoordinatesBase(ContainerFieldChoicesX3DCoordinateNode container)
        {
            Container = container;
        }

        [XmlIgnore]
        public MFVec3f Points { get; set; } = new MFVec3f();

        [XmlAttribute("point")]
        public string? PointAsText
        {
            get => Points.ToString();
            set => Points.FromString(value);
        }

        [XmlAttribute("containerField")]
        //[System.ComponentModel.DefaultValueAttribute(ContainerFieldChoicesX3DCoordinateNode.coord)]
        public ContainerFieldChoicesX3DCoordinateNode Container { get; set; } = ContainerFieldChoicesX3DCoordinateNode.coord;
    }

    [XmlInclude(typeof(CoordinateDouble))]
    public class Coordinates : CoordinatesBase
    {
        public Coordinates() : base(ContainerFieldChoicesX3DCoordinateNode.coord) { }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ControlPoints : CoordinatesBase
    {
        public ControlPoints() : base(ContainerFieldChoicesX3DCoordinateNode.controlPoint) { }
    }

    /// <summary>
    /// 
    /// </summary>
    public class CoordinateDouble : Coordinates
    {
    }

    /// <summary>
    /// The GeoCoordinate node specifies a list of coordinates in a spatial reference frame. 
    /// It is used in the coord field of vertex-based geometry nodes including IndexedFaceSet, IndexedLineSet, and PointSet.
    /// </summary>
    public class GeoCoordinate : X3DCoordinateNode
    {
        //[XmlIgnore]
        //public GeoSystemType GeoSystem { get; set; }

        [XmlIgnore]
        public MFVec3f Point { get; set; } = new MFVec3f();

        // TODO: GeoOrigin

        [XmlAttribute("geoSystem")]
        public string? GeoSystemAsText { get; set; }

        [XmlAttribute("point")]
        public string? PointAsText
        {
            get => Point.ToString();
            set => Point.FromString(value);
        }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("coord")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// ContainerFieldChoicesTextureCoordinate lists the allowed containerField enumeration values for TextureCoordinate node: 
    /// default "texCoord" if parent node is a geometry node, otherwise "texCoordRamp" if parent node is ParticleSystem
    /// </summary>
    public enum ContainerFieldChoicesTextureCoordinate
    {
        /// <summary>
        /// parent node is a geometry node
        /// </summary>
        texCoord,

        /// <summary>
        /// parent node is ParticleSystem
        /// </summary>
        texCoordRamp,
    }

    /// <summary>
    /// TextureCoordinateGenerator supports the automatic generation of texture coordinates for geometric shapes.
    /// This node can be used to set the texture coordinates for a node with a texCoord field.
    /// </summary>
    public abstract class TextureCoordinateBase<T> : X3DSingleTextureCoordinateNode where T: IX3DArray, new()
    {
        [XmlIgnore]
        public T Point { get; set; } = new T();

        [XmlAttribute("point")]
        public string? PointAsText { get => Point.ToString(); set => Point.FromString(value); }

        [XmlAttribute("containerField")]
        [System.ComponentModel.DefaultValueAttribute(ContainerFieldChoicesTextureCoordinate.texCoord)]
        public ContainerFieldChoicesTextureCoordinate Container { get; set; } = ContainerFieldChoicesTextureCoordinate.texCoord;
    }

    public class TextureCoordinate : TextureCoordinateBase<MFVec2f>
    {
    }

    /// <summary>
    /// textureCoordinateGeneratorModeChoices are strictly allowed enumeration values for TextureCoordinateGenerator mode field. This list is bounded, no additional values are allowed.
    /// </summary>
    public enum TextureCoordinateGeneratorModeChoices
    {
        /// <summary>
        /// Creates texture coordinates for a spherical environment
        /// </summary>
        SPHERE,

        /// <summary>
        /// Use vertex normal, transformed to camera space, as input texture coordinates
        /// </summary>
        CAMERASPACENORMAL,

        /// <summary>
        /// Use vertex position, transformed to camera space, as input texture coordinates
        /// </summary>
        CAMERASPACEPOSITION,

        /// <summary>
        /// Use reflection vector, transformed to camera space, as input texture coordinates
        /// </summary>
        CAMERASPACEREFLECTIONVECTOR,

        /// <summary>
        /// Sphere mapping but in local coordinates
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SPHERE-LOCAL")]
        SPHERE_LOCAL,

        /// <summary>
        /// Use vertex coordinates
        /// </summary>
        COORD,

        /// <summary>
        /// Use vertex coordinates transformed to camera space
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("COORD-EYE")]
        COORD_EYE,

        /// <summary>
        /// Apply Perlin solid noise function on vertex coordinates
        /// </summary>
        NOISE,

        /// <summary>
        /// Apply Perlin solid noise function on vertex coordinates transformed to camera space
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("NOISE-EYE")]
        NOISE_EYE,

        /// <summary>
        /// similar to CAMERASPACEREFLECTIONVECTOR with optional index of refraction
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SPHERE-REFLECT")]
        SPHERE_REFLECT,

        /// <summary>
        /// Similar to SPHERE-REFLECT transformed to camera space
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("SPHERE-REFLECT-LOCAL")]
        SPHERE_REFLECT_LOCAL,
    }

    public class TextureCoordinateGenerator : X3DSingleTextureCoordinateNode
    {
        [XmlAttribute("textureCoordinateGeneratorModeChoices")]
        [System.ComponentModel.DefaultValueAttribute(TextureCoordinateGeneratorModeChoices.SPHERE)]
        public TextureCoordinateGeneratorModeChoices Mode { get; set; } = TextureCoordinateGeneratorModeChoices.SPHERE;

        [XmlAttribute("parameter")]
        public float Parameter { get; set; }

        [XmlAttribute("containerField")]
        [System.ComponentModel.DefaultValueAttribute(ContainerFieldChoicesTextureCoordinate.texCoord)]
        public ContainerFieldChoicesTextureCoordinate containerField { get; set; } = ContainerFieldChoicesTextureCoordinate.texCoord;
    }

    /// <summary>
    /// The TextureCoordinate3D node is a geometry property node that specifies a set of 3D texture coordinates used by vertex-based geometry nodes 
    /// ( e.g., IndexedFaceSet and ElevationGrid) to map 3D textures to vertices.
    /// </summary>
    public class TextureCoordinate3D : TextureCoordinateBase<MFVec3f>
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public class TextureCoordinate4D : TextureCoordinateBase<MFVec4f>
    {
    }

    /// <summary>
    /// MultiTextureCoordinate supplies multiple texture coordinates per vertex. 
    /// This node can be used to set the texture coordinates for the different texture channels
    /// </summary>
    public class MultiTextureCoordinate : X3DTextureCoordinateNode
    {
        [XmlElement("TextureCoordinate", typeof(TextureCoordinate))]
        [XmlElement("TextureCoordinateGenerator", typeof(TextureCoordinateGenerator))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public List<object> Coord { get; set; } = new List<object>();

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("texCoord")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// This node defines a set of explicit fog depths on a per-vertex basis. 
    /// This depth value shall be applied per-vertex and used to replace the automatically generated depth.
    /// </summary>
    public class FogCoordinate : X3DGeometricPropertyNode
    {
        [XmlAttribute("depth")]
        public float Depth { get; set; }

        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("fogCoord")]
        public string? Container { get; set; }
    }
}