/*! \file X3DStatement.cs
	\brief X3DStatement is a marker interface that identifies statements relating to nonrenderable scene graph structure. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X3DCad.Model.Abstract
{
    /// <summary>
    /// X3DStatement is a marker interface that identifies statements relating to nonrenderable scene graph structure. 
    /// X3DStatement does not extend from any other node type since it is not an explicit part of the X3D node interface hierarchy, 
    /// and DEF/USE is not appropriate for such statements.
    /// </summary>
    public abstract class X3DStatement : GlobalAttributesType
    {
    }
}
