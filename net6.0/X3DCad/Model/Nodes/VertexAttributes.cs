/*! \file VertexAttributes.cs
	\brief The FloatVertexAttribute node defines a set of per-vertex single-precision floating point attributes.

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
    /// Base class for VertexAttributes
    /// </summary>
    public abstract class VertexAttributeBase : X3DVertexAttributeNode
    {
        [XmlAttribute("containerField", DataType = "token")]
        [System.ComponentModel.DefaultValueAttribute("attrib")]
        public string? Container { get; set; }
    }

    /// <summary>
    /// The FloatVertexAttribute node defines a set of per-vertex single-precision floating point attributes.
    /// </summary>
    public class FloatVertexAttribute : VertexAttributeBase
    {
        [XmlAttribute("value")]
        public float Value { get; set; }

        [XmlAttribute("valuenumComponents")]
        [System.ComponentModel.DefaultValueAttribute(4)]
        public int NumComponents { get; set; } = 4;
    }

    /// <summary>
    /// The Matrix3VertexAttribute node defines a set of per-vertex 3×3 matrix attributes.
    /// </summary>
    public class Matrix3VertexAttribute : VertexAttributeBase
    {
        [XmlIgnore]
        public MFMatrix3d Value { get; set; } = new MFMatrix3d();

        [XmlAttribute("value")]
        public string? ValueAsText {get => Value.ToString(); set => Value.FromString(value);}
    }

    /// <summary>
    /// 
    /// </summary>
    public class Matrix4VertexAttribute : VertexAttributeBase
    {
        [XmlIgnore]
        public MFMatrix4d Value { get; set; } = new MFMatrix4d();

        [XmlAttribute("value")]
        public string? ValueAsText { get => Value.ToString(); set => Value.FromString(value); }
    }
}
