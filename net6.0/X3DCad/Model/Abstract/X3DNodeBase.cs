/*! \file X3DNodeBase.cs
	\brief Abstract base class for all Nodes

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Metadata;
using X3DCad.Model.Nodes;

namespace X3DCad.Model.Abstract
{
    #region xs:group ref="ChildContentModelCore"
    [XmlInclude(typeof(MetadataBoolean))]
    [XmlInclude(typeof(MetadataDouble))]
    [XmlInclude(typeof(MetadataFloat))]
    [XmlInclude(typeof(MetadataInteger))]
    [XmlInclude(typeof(MetadataString))]
    [XmlInclude(typeof(MetadataSet))]
    #endregion
    #region <xs:group name="ChildContentModelInterchange">
    [XmlInclude(typeof(Background))]
    [XmlInclude(typeof(WorldInfo))]
    [XmlInclude(typeof(Viewpoint))]
    #endregion
    #region <xs:group ref="ChildContentModelFull"/>
    [XmlInclude(typeof(CADAssembly))]
    #endregion
    public abstract class X3DNodeBase
    {
        public X3DNodeBase() { }
    }
}
