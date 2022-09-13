/*! \file X3DGroupingNode.cs
	\brief Grouping nodes can contain other nodes as children, thus making up the backbone of a scene graph.

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
    #region <xs:group ref="ChildContentModelFull"/>
    [XmlInclude(typeof(CADAssembly))]
    #endregion
    /// <summary>
    /// Grouping nodes can contain other nodes as children, thus making up the backbone of a scene graph.
    /// </summary>
    public abstract class X3DGroupingNode : X3DChildNode
    {
        // TODO
    }
}
