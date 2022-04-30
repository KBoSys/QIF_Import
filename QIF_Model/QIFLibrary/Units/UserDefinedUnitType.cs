/*! \file UserDefinedUnits.cs
    \brief Declaration of user defined unit

        The UserDefinedUnitType defines the units for user-defined
        quantities that are not of any of the defined unit types.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFLibrary.Units
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedUnitType
    {
        #region Properties
        /// <summary>
        /// The WhatIsMeasured element describes the sort of quantity that
        /// can be measured using this unit.For example 'electric
        /// current', 'angular velocity', 'density of scratches', or 'number of widgets'.
        /// </summary>
        public string WhatIsMeasured { get; set; }

        /// <summary>
        /// The UnitName element is the name for the UserDefinedUnitType.
        /// For example 'amperes','radians per second', 'scratches per door panel', or 'widgets'.
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// The optional StandardName element provides the name of a
        /// standard or document containing a more complete description of
        /// the named unit.For SI units, it is suggested that the value be "SI".
        /// </summary>
        public string StandardName { get; set; }
		#endregion
	}
}
