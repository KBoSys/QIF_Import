/*! \file HeadType.cs
	\brief Head definition

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model
{
    /// <summary>
    /// Head element
    /// </summary>
    public class HeadType : X3DStatement
    {
        [XmlElement(ElementName = "component", Type = typeof(ComponentType))]
        public ComponentType[]? Component { get; set; }

        [XmlElement(ElementName = "unit", Type = typeof(UnitType))]
        public UnitType[]? Unit { get; set; }

        [XmlElement(ElementName = "meta", Type = typeof(MetaType))]
        public MetaType[]? Meta { get; set; }
    }
}
