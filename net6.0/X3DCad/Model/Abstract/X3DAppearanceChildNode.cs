/*! \file X3DAppearanceChildNode.cs
	\brief Nodes of this type can be used as child nodes for Appearance.

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
    /// Nodes of this type can be used as child nodes for Appearance.
    /// </summary>
    public abstract class X3DAppearanceChildNode : X3DNode
    {
    }

    /// <summary>
    /// Base type for all Material nodes.
    /// </summary>
    public abstract class X3DMaterialNode : X3DAppearanceChildNode
    {
    }
}
