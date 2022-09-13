﻿/*! \file X3DChildNode.cs
	\brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Nodes;

namespace X3DCad.Model.Abstract
{
    #region <xs:group name="ChildContentModelInterchange">
    [XmlInclude(typeof(WorldInfo))]
    [XmlInclude(typeof(Viewpoint))]
    #endregion
    #region <xs:group ref="ChildContentModelFull"/>
    [XmlInclude(typeof(CADAssembly))]
    #endregion
    public abstract class X3DChildNode : X3DNode
    {
    }

    #region <xs:group name="ChildContentModelInterchange">
    [XmlInclude(typeof(WorldInfo))]
    [XmlInclude(typeof(Viewpoint))]
    #endregion
    public abstract class X3DBindableNode : X3DChildNode
    {
    }
}
