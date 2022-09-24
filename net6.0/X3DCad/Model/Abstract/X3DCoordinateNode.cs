/*! \file X3DCoordinateNode.cs
	\brief Base type for all coordinate node types in X3D.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
