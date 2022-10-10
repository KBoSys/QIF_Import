/*! \file X3DCoordinateNode.cs
	\brief Base type for all coordinate node types in X3D.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Base type for all geometric property node types.
    /// </summary>
    public abstract class X3DGeometricPropertyNode : X3DNode
    {
    }

    /// <summary>
    /// Base type for all coordinate node types in X3D.
    /// </summary>
    public abstract class X3DCoordinateNode : X3DGeometricPropertyNode
    {
    }

    /// <summary>
    /// Base type for all normal node types in X3D.
    /// </summary>
    public abstract class X3DNormalNode : X3DGeometricPropertyNode
    {
    }

    /// <summary>
    /// Base type for all nodes which specify texture coordinates.
    /// </summary>
    public abstract class X3DTextureCoordinateNode : X3DGeometricPropertyNode
    {

    }

    /// <summary>
    /// Base type for all texture coordinate nodes which specify texture coordinates for a single texture.
    /// </summary>
    public abstract class X3DSingleTextureCoordinateNode : X3DTextureCoordinateNode
    {
        [XmlAttribute("mapping", DataType = "token")]
        public string? Mapping { get; set; }
    }
}
