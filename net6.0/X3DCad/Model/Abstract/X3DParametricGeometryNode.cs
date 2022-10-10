/*! \file X3DParametricGeometryNode.cs
	\brief Base type for all geometry node types that are created parametrically and use control points to describe the final shape of the surface.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X3DCad.Model.Geometry;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// Base type for all geometry node types that are created parametrically and use control points to describe the final shape of the surface.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(X3DNurbsSurfaceGeometryNode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NurbsCurve))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NurbsSweptSurface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NurbsSwungSurface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NurbsSwungSurface))]
    public abstract class X3DParametricGeometryNode : X3DGeometryNode
    {
    }
}
