/*! \file Unit.cs
    \brief Defines a unit

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QIF_Model.QIFDocument.Units
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class UnitBaseType
	{
		#region Private Members
		private string siUnitNameField;
        private string unitNameField;
        private UnitConversionType unitConversionField;
        #endregion
        protected UnitBaseType(string siUnit)
		{
            siUnitNameField = siUnit;
        }

        #region Properties
        /// <remarks The name of the unit in the International System of Units - SI />
		[XmlElement]
        public string SIUnitName
        {
            get => this.siUnitNameField; 
            set => this.siUnitNameField = value; 
        }

        /// <remarks The name of the unit/>
		[XmlElement]
        public string UnitName
        {
            get => this.unitNameField;
            set => this.unitNameField = value;
        }

        /// <remarks Defines the conversion to SI units/>
		[XmlElement]
        public UnitConversionType UnitConversion
        {
            get => this.unitConversionField;
            set => this.unitConversionField = value;
        }
		#endregion
	}
}
