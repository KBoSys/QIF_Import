/*! \file RulesUnitsType.cs
    \brief defines units for various quantities

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks The RulesUnitsType defines units for various quantities. 
    /// All unit types are optional.Each unit type may occur at most once,
    /// since individual numbers used in rules cannot have units assigned./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class RulesUnitsType
    {
        /// <remarks The optional AreaUnit element defines units for area values./>
        public AreaUnitType AreaUnit { get; set; }

        /// <remarks The optional AngularUnit element defines units for angle values./>
        public AngularUnitType AngularUnit { get; set; }

        /// <remarks The optional ForceUnit element defines units for force values./>
        public ForceUnitType ForceUnit { get; set; }

        /// <remarks The optional LinearUnit element defines units for length values./>
        public LinearUnitType LinearUnit { get; set; }

        /// <remarks The optional MassUnit element defines units for mass values./>
        public MassUnitType MassUnit { get; set; }

        /// <remarks The optional PressureUnit element defines units for pressure values./>
        public PressureUnitType PressureUnit { get; set; }

        /// <remarks The optional SpeedUnit element defines units for speed values./>
        public SpeedUnitType SpeedUnit { get; set; }

        /// <remarks The optional TemperatureUnit element defines units for temperature values./>
        public TemperatureUnitType TemperatureUnit { get; set; }

        /// <remarks The optional TimeUnit element defines units for time values./>
        public TimeUnitType TimeUnit { get; set; }

        /// <remarks The required n attribute is the number of unit definitions in the set./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint NumUnits { get; set; }
    }
}
