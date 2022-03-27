/*! \file OtherUnits.cs
    \brief Defines the alternate units used in the document

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
    public partial class OtherUnits
    {
		#region Private Members
		private Unit[] areaUnitField;
        private Unit[] angularUnitField;
        private Unit[] forceUnitField;
        private Unit[] linearUnitField;
        private Unit[] massUnitField;
        private Unit[] pressureUnitField;
        private Unit[] speedUnitField;
        private Unit[] temperatureUnitField;
        private Unit[] timeUnitField;
        private byte nField;
		#endregion
		#region Properties
		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("AreaUnit")]
        public Unit[] AreaUnit
        {
            get => this.areaUnitField;
            set => this.areaUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AngularUnit")]
        public Unit[] AngularUnit
        {
            get => this.angularUnitField;
            set => this.angularUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceUnit")]
        public Unit[] ForceUnit
        {
            get => this.forceUnitField;
            set => this.forceUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LinearUnit")]
        public Unit[] LinearUnit
        {
            get => this.linearUnitField;
            set => this.linearUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MassUnit")]
        public Unit[] MassUnit
        {
            get => this.massUnitField;
            set => this.massUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PressureUnit")]
        public Unit[] PressureUnit
        {
            get => this.pressureUnitField;
            set => this.pressureUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpeedUnit")]
        public Unit[] SpeedUnit
        {
            get => this.speedUnitField;
            set => this.speedUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TemperatureUnit")]
        public Unit[] TemperatureUnit
        {
            get => this.temperatureUnitField;
            set => this.temperatureUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeUnit")]
        public Unit[] TimeUnit
        {
            get => this.timeUnitField;
            set => this.timeUnitField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte n
        {
            get => this.nField;
            set => this.nField = value;
        }
    }
	#endregion
}
