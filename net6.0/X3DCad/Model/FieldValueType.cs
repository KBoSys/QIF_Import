/*! \file FieldValueType.cs
	\brief Each fieldValue statement can contain either attribute-value or node content.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using X3DCad.Model.Abstract;

namespace X3DCad.Model
{
    /// <summary>
    /// Functional summary: a fieldValue statement re-initializes the default value of a field in a ProtoInstance.
    /// Each fieldValue statement can contain either attribute-value or node content.
    /// </summary>
    public class FieldValueType : X3DStatement
    {
        #region <xs:group ref="SceneGraphFragmentContentModel"/>
        // TODO:
        #endregion

        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("value")]
        public string? Value { get; set; }
    }
}
