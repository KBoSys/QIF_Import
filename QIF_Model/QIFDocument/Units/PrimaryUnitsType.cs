/*! \file PrimaryUnits.cs
    \brief Defines the primary units used in the document

        The PrimaryUnitsType defines the primary units for various
        quantities. Primary units apply to values with units if no explicit
        unit name is provided with a value. All elements in this type are
        optional.

        The PMI units (PMIAreaUnit, PMIAngularUnit, and PMILinearUnit),
        if given, override the corresponding non-PMI units for all
        area, angular, and linear values in (only):
          1. all of the QIFDocument/Characteristics portion of an instance
             file.
          2. all CharacteristicMeasurements elements in the
             QIFDocument/Results portion of an instance file.
          3. all elements of AbsoluteLimitsByUnitType or
             CriteriaByUnitType in the
             QIFDocument/Statistics/StatisticalStudiesPlans
             portion of an instance file.

          If no PMI unit is given for a particular unit type, but the
          corresponding non-PMI unit is given, the non-PMI unit applies.

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
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PrimaryUnitsType
    {
        /// The optional AreaUnit element is the primary units for area values.
        [XmlAttributeAttribute]
        public AreaUnitType AreaUnit {get; set;}

        /// The optional PMIAreaUnit element is the primary units for PMI area values.
        [XmlAttributeAttribute]
        public AreaUnitType PMIAreaUnit { get; set; }

        /// The optional AngularUnit element is the primary units for angle values.
        [XmlAttributeAttribute]
        public AngularUnitType AngularUnit { get; set; }

        /// The optional PMIAngularUnit element is the primary units for PMI angle values.
        [XmlAttributeAttribute]
        public AngularUnitType PMIAngularUnit { get; set; }

        /// The optional ForceUnit element is the primary units for force values.
        [XmlAttributeAttribute]
        public ForceUnitType ForceUnit { get; set; }

        /// The optional LinearUnit element is the primary units for length values.
        [XmlAttributeAttribute]
        public LinearUnitType LinearUnit { get; set; }

        /// The optional PMILinearUnit element is the primary units for PMI length values.
        [XmlAttributeAttribute]
        public LinearUnitType PMILinearUnit { get; set; }

        /// The optional MassUnit element is the primary units for mass values.
        [XmlAttributeAttribute]
        public MassUnitType MassUnit { get; set; }

        /// The optional PressureUnit element is the primary units for pressure values.
        [XmlAttributeAttribute]
        public PressureUnitType PressureUnit { get; set; }

        /// The optional SpeedUnit element is the primary units for speed values.
        [XmlAttributeAttribute]
        public SpeedUnitType SpeedUnit { get; set; }

        /// The optional TemperatureUnit element is the primary units for temperature values.
        [XmlAttributeAttribute]
        public TemperatureUnitType TemperatureUnit { get; set; }

        /// The optional TimeUnit element is the primary units for time values.
        [XmlAttributeAttribute]
        public TimeUnitType TimeUnit { get; set; }
    }
}
