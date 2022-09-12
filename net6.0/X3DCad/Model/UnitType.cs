/*! \file UnitType.cs
	\brief unit statement defines data-conversion factors for typed values defined in a scene.

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
    /// unitCategoryChoices are strictly allowed enumeration values for standard units in the UNIT statement. 
    /// This list is bounded, no additional values are allowed.
    /// </summary>
    public enum UnitCategoryChoices
    {
        /// <summary>
        /// angle default is radians
        /// </summary>
        [XmlEnumAttribute("angle")]
        Angle,

        /// <summary>
        /// force default is newtons
        /// </summary>
        [XmlEnumAttribute("force")]
        Force,

        /// <summary>
        /// length default is meters
        /// </summary>
        [XmlEnumAttribute("length")]
        Length,

        /// <summary>
        /// mass default is kilograms
        /// </summary>
        [XmlEnumAttribute("mass")]
        Mass,
    }

    /// <summary>
    /// Functional summary: unit statement defines data-conversion factors for typed values defined in a scene.
    /// </summary>
    public class UnitType : X3DStatement
    {
        [XmlElement("unitCategoryChoices")]
        public UnitCategoryChoices? Category { get; set; }

        [XmlElement("name", DataType = "token")]
        public string? Name { get; set; }

        [XmlElement("conversionFactor")]
        public double Factor { get; set; }
    }
}
