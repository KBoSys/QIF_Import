/*! \file RulesUnitsType.cs
    \brief defines units for various quantities

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFApplications.QIFRules
{
    /// <remarks> The RulesUnitsType defines units for various quantities. 
    /// All unit types are optional.Each unit type may occur at most once,
    /// since individual numbers used in rules cannot have units assigned.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class RulesUnitsType
    {
        /// <remarks> The optional AreaUnit element defines units for area values.</remarks>
        public AreaUnitType? AreaUnit { get; set; }

        /// <remarks> The optional AngularUnit element defines units for angle values.</remarks>
        public AngularUnitType? AngularUnit { get; set; }

        /// <remarks> The optional ForceUnit element defines units for force values.</remarks>
        public ForceUnitType? ForceUnit { get; set; }

        /// <remarks> The optional LinearUnit element defines units for length values.</remarks>
        public LinearUnitType? LinearUnit { get; set; }

        /// <remarks> The optional MassUnit element defines units for mass values.</remarks>
        public MassUnitType? MassUnit { get; set; }

        /// <remarks> The optional PressureUnit element defines units for pressure values.</remarks>
        public PressureUnitType? PressureUnit { get; set; }

        /// <remarks> The optional SpeedUnit element defines units for speed values.</remarks>
        public SpeedUnitType? SpeedUnit { get; set; }

        /// <remarks> The optional TemperatureUnit element defines units for temperature values.</remarks>
        public TemperatureUnitType? TemperatureUnit { get; set; }

        /// <remarks> The optional TimeUnit element defines units for time values.</remarks>
        public TimeUnitType? TimeUnit { get; set; }

        /// <remarks> The required n attribute is the number of unit definitions in the set.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint NumUnits { get; set; }
    }
}
