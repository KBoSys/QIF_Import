/*! \file OtherUnits.cs
    \brief Defines the alternate units used in the document

        The OtherUnitsType defines alternative units for various
        quantities. All unit types are optional and may occur multiple
        times so that many units of the same type (meters, inches, and
        millimeters, for example) may co-exist in an instance file.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Units
{
    /// <remarks></remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherUnitsType
    {
        #region Properties
        /// <remarks> Each optional AreaUnit element defines alternative units for area values.</remarks>
		[System.Xml.Serialization.XmlElementAttribute("AreaUnit")]
        public AreaUnitType[] AreaUnit { get; set; }

        /// <remarks> Each optional AngularUnit element defines alternative units for angle values.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AngularUnit")]
        public AngularUnitType[] AngularUnit { get; set; }

        /// <remarks> Each optional ForceUnit element defines alternative units for force values.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ForceUnit")]
        public ForceUnitType[] ForceUnit { get; set; }

        /// <remarks> Each optional LinearUnit element defines alternative units for length values.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("LinearUnit")]
        public LinearUnitType[] LinearUnit { get; set; }

        /// <remarks> Each optional MassUnit element defines alternative units for mass values.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MassUnit")]
        public MassUnitType[] MassUnit { get; set; }

        /// <remarks> Each optional PressureUnit element defines alternative units for pressure values.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("PressureUnit")]
        public PressureUnitType[] PressureUnit { get; set; }

        /// <remarks> Each optional SpeedUnit element defines alternative units for speed values.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SpeedUnit")]
        public SpeedUnitType[] SpeedUnit { get; set; }

        /// <remarks> Each optional TemperatureUnit element defines alternative units for temperature values.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("TemperatureUnit")]
        public TemperatureUnitType[] TemperatureUnit { get; set; }

        /// <remarks> Each optional TimeUnit element defines alternative units for time values.</remarks>
        [XmlElement("TimeUnit", Type = typeof(TimeUnitType))]
        public TimeUnitType[] TimeUnits { get; set; }

        /// <remarks> The required n attribute is the number of unit definitions in the set.</remarks>
        [XmlAttribute("n")]
        public uint Counts
        {
            get
            {
                uint cnt = 0;
                cnt += AreaUnit != null ? (uint)AreaUnit.Length : 0;
                cnt += AngularUnit != null ? (uint)AngularUnit.Length : 0;
                cnt += ForceUnit != null ? (uint)ForceUnit.Length : 0;
                cnt += LinearUnit != null ? (uint)LinearUnit.Length : 0;
                cnt += MassUnit != null ? (uint)MassUnit.Length : 0;
                cnt += PressureUnit != null ? (uint)PressureUnit.Length : 0;
                cnt += SpeedUnit != null ? (uint)SpeedUnit.Length : 0;
                cnt += TemperatureUnit != null ? (uint)TemperatureUnit.Length : 0;
                cnt += TimeUnits != null ? (uint)TimeUnits.Length : 0;
                return cnt;
            }
            set { }
        }
    }
    #endregion
}
