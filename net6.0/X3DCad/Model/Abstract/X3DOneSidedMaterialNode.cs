/*! \file X3DOneSidedMaterialNode.cs
	\brief Base type for material nodes that describe how the shape looks like from one side.

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
    /// Base type for material nodes that describe how the shape looks like from one side.
    /// A different number of contanied texture nodes are allowed by each of the implementing nodes.
    /// </summary>
    public abstract class X3DOneSidedMaterialNode : X3DMaterialNode
    {
                //<xs:attribute name = "emissiveTextureMapping" type="xs:NMTOKEN"/>
                //<xs:attribute name = "normalScale" default="1"> SFFloat
                //<xs:attribute name="normalTextureMapping" type="xs:NMTOKEN"/>
    }
}
