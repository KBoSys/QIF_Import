/*! \file Unit.cs
    \brief Defines a unit

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Units
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class UnitBaseType
    {
        protected UnitBaseType(string siUnit)
        {
            SIUnitName = siUnit;
        }

        #region Properties
        /// <remarks> The name of the unit in the International System of Units - SI </remarks>
		[XmlElement]
        public string? SIUnitName { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SIUnitNameSpecified { get; set; }

        /// <remarks> The name of the unit</remarks>
		[XmlElement]
        public string? UnitName { get; set; }

        /// <remarks> Defines the conversion to SI units</remarks>
		[XmlElement]
        public UnitConversionType? UnitConversion { get; set; }
        #endregion
    }
}
