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
        #region Methods
        public void AddMetaData(string name, string content)
        {
            Meta.Add(new MetaType()
            {
                Name = name,
                Content = content
            });
        }
        #endregion Methods

        #region XML Serialization
        [XmlElement(ElementName = "component", Type = typeof(ComponentType))]
        public ComponentType[]? Component { get; set; }

        [XmlElement(ElementName = "unit", Type = typeof(UnitType))]
        public UnitType[]? Unit { get; set; }

        [XmlElement(ElementName = "meta", Type = typeof(MetaType))]
        public List<MetaType> Meta { get; set; } = new List<MetaType>();
        #endregion
    }
}
