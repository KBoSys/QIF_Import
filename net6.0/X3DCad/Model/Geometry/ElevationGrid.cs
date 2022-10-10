/*! \file ElevationGrid.cs
	\brief Specifies a uniform rectangular grid of varying height in the Y=0 plane of the local coordinate system. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;
using X3DCad.Model.Nodes;
using X3DCad.Model.Types;

namespace X3DCad.Model.Geometry
{
    /// <summary>
    /// The ElevationGrid node specifies a uniform rectangular grid of varying height in the Y=0 plane of the local coordinate system. 
    /// The geometry is described by a scalar array of height values that specify the height of a surface above each point of the grid.
    /// </summary>
    public class ElevationGrid : GeometryBase
    {
        public ElevationGrid()
        {
            Height = new MFFloat();
            Height.Items.Add(0);
            Height.Items.Add(0);
            Height.Items.Add(0);
            Height.Items.Add(0);
        }

        #region <xs:choice minOccurs = "0" >
        [XmlElement("FloatVertexAttribute", typeof(FloatVertexAttribute))]
        [XmlElement("Matrix3VertexAttribute", typeof(Matrix3VertexAttribute))]
        [XmlElement("Matrix4VertexAttribute", typeof(Matrix4VertexAttribute))]
        [XmlElement("FogCoordinate", typeof(FogCoordinate))]
        [XmlElement("TextureCoordinate", typeof(TextureCoordinate))]
        [XmlElement("TextureCoordinate3D", typeof(TextureCoordinate3D))]
        [XmlElement("TextureCoordinate4D", typeof(TextureCoordinate4D))]
        [XmlElement("TextureCoordinateGenerator", typeof(TextureCoordinateGenerator))]
        [XmlElement("MultiTextureCoordinate", typeof(MultiTextureCoordinate))]
        [XmlElement("Color", typeof(X3DCad.Model.Nodes.Color))]
        [XmlElement("ColorRGBA", typeof(ColorRGBA))]
        [XmlElement("Normal", typeof(Normal))]
        [XmlElement("ProtoInstance", typeof(ProtoInstance))]
        public List<object>? Item { get; set; }
        #endregion </xs:choice>

        [XmlIgnore]
        public MFFloat Height { get; set; }

        [XmlAttribute("height")]
        [System.ComponentModel.DefaultValueAttribute("0 0 0 0")]
        public string? HeightAsText { get => Height.ToString(); set => Height.FromString(value); }

        [XmlAttribute("ccw")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool CCW { get; set; } = true;

        [XmlAttribute("colorPerVertex")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool ColorPerVertex { get; set; } = true;

        [XmlAttribute("creaseAngle")]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public float CreaseAngle { get; set; } = 0;

        [XmlAttribute("normalPerVertex")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool NormalPerVertex { get; set; } = true;

        [XmlAttribute("solid")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Solid { get; set; } = true;

        [XmlAttribute("xDimension")]
        [System.ComponentModel.DefaultValueAttribute(2)]
        public Int32 XDimension { get; set; } = 2;

        [XmlAttribute("xSpacing")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float XSpacing { get; set; } = 1;

        [XmlAttribute("zDimension")]
        [System.ComponentModel.DefaultValueAttribute(2)]
        public Int32 ZDimension { get; set; } = 2;

        [XmlAttribute("zSpacing")]
        [System.ComponentModel.DefaultValueAttribute(1)]
        public float ZSpacing { get; set; } = 1;
    }

    /// <summary>
    /// The GeoElevationGrid node specifies a uniform grid of elevation values within some spatial reference frame. 
    /// These are then transparently transformed into a geocentric, curved-earth representation. For example, 
    /// this would allow a geographer to create a height field where all coordinates are specified in terms of latitude, longitude, and elevation.
    /// </summary>
    public class GeoElevationGrid : GeometryBase
    {
        // TODO: 
        #region <xs:choice minOccurs = "0" >
        //<xs:element ref="GeoOrigin"/>
        //<xs:group ref="ColorNormalTexCoordContentModel" minOccurs="0"/>
        #endregion </xs:choice>

        //<xs:attribute name = "geoSystem" type="geoSystemType" default='"GD" "WE"'/>
        //<xs:attribute name = "geoGridOrigin" type="SFVec3d" default="0 0 0"/>
        //<xs:attribute name = "height" type="MFDouble" default="0 0 0 0"/>
        //<xs:attribute name = "ccw" type="SFBool" default="true"/>
        //<xs:attribute name = "colorPerVertex" type="SFBool" default="true"/>
        //<xs:attribute name = "creaseAngle" SFDouble default="0">
        //<xs:attribute name = "normalPerVertex" type="SFBool" default="true"/>
        //<xs:attribute name = "solid" type="SFBool" default="true"/>
        //<xs:attribute name = "xDimension" SFInt32 default="2">
        //<xs:attribute name = "xSpacing" SFDouble default="1.0">
        //<xs:attribute name = "yScale" SFFloat default="1">
        //<xs:attribute name = "zDimension" SFInt32 default="2">
        //<xs:attribute name = "zSpacing" SFDouble default="1.0">
    }
}
