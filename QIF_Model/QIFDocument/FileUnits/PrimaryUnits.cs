/*! \file PrimaryUnits.cs
    \brief Defines the primary units used in the document

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
    public partial class PrimaryUnits
    {
		#region Private Members
		private Unit areaUnitField;
        private Unit pMIAreaUnitField;
        private Unit angularUnitField;
        private Unit pMIAngularUnitField;
        private Unit forceUnitField;
        private Unit linearUnitField;
        private Unit pMILinearUnitField;
        private Unit massUnitField;
        private Unit pressureUnitField;
        private Unit speedUnitField;
        private Unit temperatureUnitField;
        private Unit timeUnitField;
		#endregion
		#region Properties
		/// <remarks/>
		public Unit AreaUnit
        {
            get => this.areaUnitField;
            set => this.areaUnitField = value;
        }

        /// <remarks/>
        public Unit PMIAreaUnit
        {
            get => this.pMIAreaUnitField;
            set => this.pMIAreaUnitField = value;
        }

        /// <remarks/>
        public Unit AngularUnit
        {
            get => this.angularUnitField;
            set => this.angularUnitField = value;
        }

        /// <remarks/>
        public Unit PMIAngularUnit
        {
            get => this.pMIAngularUnitField;
            set => this.pMIAngularUnitField = value;
        }

        /// <remarks/>
        public Unit ForceUnit
        {
            get => this.forceUnitField;
            set => this.forceUnitField = value;
        }

        /// <remarks/>
        public Unit LinearUnit
        {
            get => this.linearUnitField;
            set => this.linearUnitField = value;
        }

        /// <remarks/>
        public Unit PMILinearUnit
        {
            get => this.pMILinearUnitField;
            set => this.pMILinearUnitField = value;
        }

        /// <remarks/>
        public Unit MassUnit
        {
            get => this.massUnitField;
            set => this.massUnitField = value;
        }

        /// <remarks/>
        public Unit PressureUnit
        {
            get => this.pressureUnitField;
            set => this.pressureUnitField = value;
        }

        /// <remarks/>
        public Unit SpeedUnit
        {
            get => this.speedUnitField;
            set => this.speedUnitField = value;
        }

        /// <remarks/>
        public Unit TemperatureUnit
        {
            get => this.temperatureUnitField;
            set => this.temperatureUnitField = value;
        }

        /// <remarks/>
        public Unit TimeUnit
        {
            get => this.timeUnitField;
            set => this.timeUnitField = value;
        }
    }
	#endregion
}
