/*! \file UnitConversion.cs
    \brief Defines a conversion from the unit value to value in terms of SI units

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
    public class UnitConversion
	{
		#region Private Members
		private double factorField;
        private double offsetField;
		#endregion

		#region Constructors
		public UnitConversion()
		{
            factorField = 1.0;
            offsetField = 0.0;
		}
        public UnitConversion(double factor, double offset=0.0)
        {
            factorField = factor;
            offsetField = offset;
        }
        #endregion

        #region Properties
        /// <remarks Multiplication Factor that may be used to convert values of the primary unit type to values in terms of SI units/>
        [System.Xml.Serialization.XmlElementAttribute("Factor", DataType = "decimal")]
        public double Factor
        {
            get => this.factorField;
            set => this.factorField = value;
        }

        /// <remarks An Offset that may be used to convert values of the primary unit type to values in terms of SI units./>
        [System.Xml.Serialization.XmlElementAttribute("Offset", DataType = "decimal")]
        public double Offset
        {
            get => this.offsetField;
            set => this.offsetField = value;
        }
		#endregion
	}
}
