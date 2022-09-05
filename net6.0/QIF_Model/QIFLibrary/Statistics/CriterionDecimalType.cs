/*! \file CriterionDecimalType.cs
    \brief defines a numerical limit to be used as a criterion as a decimal value outside of which an issue will exist.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The CriterionDecimalType defines a numerical limit to be used as a
    /// criterion as a decimal value outside of which an issue will exist.
    /// The limit can be optionally qualified to allow a number of items to
    /// exceed the limit as long as none are outside a specified extreme limit.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionUserDefinedUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionTemperatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionSpeedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionPressureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionMassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionForceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionAreaType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionAngularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionLinearType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionDecimalType
    {
        /// <remarks> The Limit element defines a limit outside of which an issue will exist.</remarks>
        public decimal Limit { get; set; }

        /// <remarks> The NumberAllowedExceptions element defines the number of
        /// items that can lie between the limit and the extreme limit without an issue existing.</remarks>
        public LimitingNumberType? NumberAllowedExceptions { get; set; }

        /// <remarks> The optional ExtremeLimit element defines the extreme limit
        /// outside of which no item can lie or an issue will exist.</remarks>
        public decimal ExtremeLimit { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtremeLimitSpecified { get; set; }
    }

    /// <remarks> The LimitingNumberType defines a limiting number of items either as an integer or as a fraction.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LimitingNumberType
    {
        /// <remarks> This compositor provides a choice between the limiting number expressed as an integer or as a fraction.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Count", typeof(uint))]
        [System.Xml.Serialization.XmlElementAttribute("Fraction", typeof(decimal))]
        public object? Item { get; set; }
    }

    /// <remarks> The CriterionLinearType defines a CriterionDecimalType with an
    /// optional linearUnit attribute that identifies the unit being used
    /// by its unit name.If no value for the attribute is given in an
    /// instance file when a length value is given, the unit type is the
    /// primary length unit specified in the PrimaryUnits element of a
    /// FileUnits element, if there is a FileUnits element, and meters if not.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionLinearType : CriterionDecimalType
    {
        /// <remarks> The optional linearUnit attribute defines the unit name for the CriterionLinearType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("linearUnit", DataType = "token")]
        public string? LinearUnit { get; set; }
    }

    /// <remarks> The CriterionUserDefinedUnitType defines a CriterionDecimalType
    /// with user defined units that are not available in another criterion
    /// type. In particular this type is not to be used to define a
    /// criterion with linear units, angular units, or units of
    /// temperature, area, force, mass, pressure, speed, or time.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionUserDefinedUnitType : CriterionDecimalType
    {
        /// <remarks> The required unitName attribute is the unit name for the CriterionUserDefinedUnitType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("unitName", DataType = "token")]
        public string? UnitName { get; set; }
    }

    /// <remarks> The CriterionTimeType defines a CriterionDecimalType with an
    /// optional timeUnit attribute that identifies the unit being used by
    /// its unit name.If no value for the attribute is given in an instance
    /// file when a time value is given, the unit type is the primary time
    /// unit specified in the PrimaryUnits element of a FileUnits element,
    /// if there is a FileUnits element, and seconds if not.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionTimeType : CriterionDecimalType
    {
        /// <remarks> The optional timeUnit attribute defines the unit name for the CriterionTimeType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("timeUnit", DataType = "token")]
        public string? TimeUnit { get; set; }
    }

    /// <remarks> The CriterionTemperatureType defines a CriterionDecimalType with an
    /// optional temperatureUnit attribute that identifies the unit being
    /// used by its unit name.If no value for the attribute is given in an
    /// instance file when a temperature value is given, the unit type is
    /// the primary temperature unit specified in the PrimaryUnits element
    /// of a FileUnits element, if there is a FileUnits element, and Kelvin if not.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionTemperatureType : CriterionDecimalType
    {
        /// <remarks> The optional temperatureUnit attribute defines the unit name for the CriterionTemperatureType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("temperatureUnit", DataType = "token")]
        public string? TemperatureUnit { get; set; }
    }

    /// <remarks> The CriterionSpeedType defines a CriterionDecimalType with an
    /// optional speedUnit attribute that identifies the unit being used by
    /// its unit name.If no value for the attribute is given in an instance
    /// file when a speed value is given, the unit type is the primary
    /// speed unit specified in the PrimaryUnits element of a FileUnits
    /// element, if there is a FileUnits element, and meters per second if not.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionSpeedType : CriterionDecimalType
    {
        /// <remarks> The optional speedUnit attribute defines the unit name for the CriterionSpeedType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("speedUnit", DataType = "token")]
        public string? SpeedUnit { get; set; }
    }

    /// <remarks> The CriterionPressureType defines a CriterionDecimalType with an
    /// optional pressureUnit attribute that identifies the unit being used
    /// by its unit name.If no value for the attribute is given in an
    /// instance file when a pressure value is given, the unit type is the
    /// primary pressure unit specified in the PrimaryUnits element of a
    /// FileUnits element, if there is a FileUnits element, and Pascals if not.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionPressureType : CriterionDecimalType
    {
        /// <remarks> The optional pressureUnit attribute defines the unit name for the CriterionPressureType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("pressureUnit", DataType = "token")]
        public string? PressureUnit { get; set; }
    }

    /// <remarks> The CriterionMassType defines a CriterionDecimalType with an
    /// optional massUnit attribute that identifies the unit being used by
    /// its unit name.If no value for the attribute is given in an instance
    /// file when a mass value is given, the unit type is the primary mass
    /// unit specified in the PrimaryUnits element of a FileUnits element,
    /// if there is a FileUnits element, and kilograms if not.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionMassType : CriterionDecimalType
    {
        /// <remarks> The optional massUnit attribute defines the unit name for the CriterionMassType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("massUnit", DataType = "token")]
        public string? MassUnit { get; set; }
    }

    /// <remarks> The CriterionForceType defines a CriterionDecimalType with an
    /// optional forceUnit attribute that identifies the unit being used
    /// by its unit name.If no value for the attribute is given in an
    /// instance file when a force value is given, the unit type is the
    /// primary force unit specified in the PrimaryUnits element of a
    /// FileUnits element, if there is a FileUnits element, and Newtons if not.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionForceType : CriterionDecimalType
    {
        /// <remarks> The optional forceUnit attribute defines the unit name for the CriterionForceType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("forceUnit", DataType = "token")]
        public string? ForceUnit { get; set; }
    }

    /// <remarks> The CriterionAreaType defines a CriterionDecimalType with an
    /// optional areaUnit attribute that identifies the unit being used
    /// by its unit name.If no value for the attribute is given in an
    /// instance file when an area value is given, the unit type is the
    /// primary area unit specified in the PrimaryUnits element of a
    /// FileUnits element, if there is a FileUnits element, and square meters if not.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionAreaType : CriterionDecimalType
    {
        /// <remarks> The optional areaUnit attribute defines the unit name for the CriterionAreaType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("areaUnit", DataType = "token")]
        public string? AreaUnit { get; set; }
    }

    /// <remarks> The CriterionAngularType defines a CriterionDecimalType with an
    /// optional angularUnit attribute that identifies the unit being used
    /// by its unit name.If no value for the attribute is given in an
    /// instance file when an angle value is given, the unit type is the
    /// primary angle unit specified in the PrimaryUnits element of a
    /// FileUnits element, if there is a FileUnits element, and radians if not.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CriterionAngularType : CriterionDecimalType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("angularUnit", DataType = "token")]
        public string? AngularUnit { get; set; }
    }
}
