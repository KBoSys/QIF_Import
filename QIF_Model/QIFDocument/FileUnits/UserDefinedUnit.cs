/*! \file UserDefinedUnits.cs
    \brief Declaration of user defined unit

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFDocument.FileUnits
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedUnit
    {
		#region Private Members
		private string whatIsMeasuredField;
        private string unitNameField;
        private string standardNameField;
		#endregion

		#region Properties
		/// <remarks/>
		public string WhatIsMeasured
        {
            get => this.whatIsMeasuredField;
            set => this.whatIsMeasuredField = value;
        }

        /// <remarks/>
        public string UnitName
        {
            get => this.unitNameField;
            set => this.unitNameField = value;
        }

        /// <remarks/>
        public string StandardName
        {
            get => this.standardNameField;
            set => this.standardNameField = value;
        }
		#endregion
	}
}
