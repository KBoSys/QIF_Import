/*! \file Unit.cs
    \brief Defines a unit

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFDocument.FileUnits
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class Unit
	{
		#region Private Members
		private string siUnitNameField;
        private string unitNameField;
        private UnitConversion unitConversionField;
        #endregion
        #region Properties
        /// <remarks The name of the unit in the International System of Units - SI />
        public string SIUnitName
        {
            get => this.siUnitNameField;
            set => this.siUnitNameField = value;
        }

        /// <remarks The name of the unit/>
        public string UnitName
        {
            get => this.unitNameField;
            set => this.unitNameField = value;
        }

        /// <remarks Defines the conversion to SI units/>
        public UnitConversion UnitConversion
        {
            get => this.unitConversionField;
            set => this.unitConversionField = value;
        }
		#endregion
	}
}
