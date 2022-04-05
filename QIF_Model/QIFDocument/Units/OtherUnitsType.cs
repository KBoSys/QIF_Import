/*! \file OtherUnits.cs
    \brief Defines the alternate units used in the document

        The OtherUnitsType defines alternative units for various
        quantities. All unit types are optional and may occur multiple
        times so that many units of the same type (meters, inches, and
        millimeters, for example) may co-exist in an instance file.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QIF_Model.QIFDocument.Units
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherUnitsType
    {
        #region Properties
        /// <remarks Each optional AreaUnit element defines alternative units for area values./>
		[System.Xml.Serialization.XmlElementAttribute("AreaUnit")]
        public AreaUnitType[] AreaUnit { get; set; }

        /// <remarks Each optional AngularUnit element defines alternative units for angle values./>
        [System.Xml.Serialization.XmlElementAttribute("AngularUnit")]
        public AngularUnitType[] AngularUnit { get; set; }

        /// <remarks Each optional ForceUnit element defines alternative units for force values./>
        [System.Xml.Serialization.XmlElementAttribute("ForceUnit")]
        public ForceUnitType[] ForceUnit { get; set; }

        /// <remarks Each optional LinearUnit element defines alternative units for length values./>
        [System.Xml.Serialization.XmlElementAttribute("LinearUnit")]
        public LinearUnitType[] LinearUnit { get; set; }

        /// <remarks Each optional MassUnit element defines alternative units for mass values./>
        [System.Xml.Serialization.XmlElementAttribute("MassUnit")]
        public MassUnitType[] MassUnit { get; set; }

        /// <remarks Each optional PressureUnit element defines alternative units for pressure values./>
        [System.Xml.Serialization.XmlElementAttribute("PressureUnit")]
        public PressureUnitType[] PressureUnit { get; set; }

        /// <remarks Each optional SpeedUnit element defines alternative units for speed values./>
        [System.Xml.Serialization.XmlElementAttribute("SpeedUnit")]
        public SpeedUnitType[] SpeedUnit { get; set; }

        /// <remarks Each optional TemperatureUnit element defines alternative units for temperature values./>
        [System.Xml.Serialization.XmlElementAttribute("TemperatureUnit")]
        public TemperatureUnitType[] TemperatureUnit { get; set; }

        /// <remarks Each optional TimeUnit element defines alternative units for time values./>
        [System.Xml.Serialization.XmlElementAttribute("TimeUnit")]
        public TimeUnitType[] TimeUnit { get; set; }

        /// <remarks The required n attribute is the number of unit definitions in the set./>
        [System.Xml.Serialization.XmlElementAttribute("n")]
        public NaturalType N { get; set; }
    }
	#endregion
}
