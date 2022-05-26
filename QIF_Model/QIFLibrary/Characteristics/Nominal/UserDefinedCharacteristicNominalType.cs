/*! \file UserDefinedCharacteristicNominalType.cs
    \brief User defined characteristics

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <remarks The UserDefinedAttributeCharacteristicNominalType defines a unique
    /// user-defined characteristic nominal for an attribute characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedAttributeCharacteristicNominalType : CharacteristicNominalBaseType
    {
        /// <remarks The optional PassValues element is a list of acceptable target values for the user-defined characteristic./>
        public StringValuesType PassValues { get; set; }

        /// <remarks The optional FailValues element is a list of values for the
        /// user-defined characteristic that indicate failure to achieve an allowed target value of the characteristic./>
        public StringValuesType FailValues { get; set; }
    }

    /// <remarks The AreaCharacteristicNominalBaseType is the abstract base type that defines a unique area characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AreaCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is the nominal value of the area characteristic./>
        public Units.AreaValueType TargetValue { get; set; }
    }

    /// <remarks The UserDefinedAreaCharacteristicNominalType is
    /// a characteristic nominal specified by the user that is measured in area units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedAreaCharacteristicNominalType : AreaCharacteristicNominalBaseType
    {
    }

    /// <remarks The ForceCharacteristicNominalBaseType is the abstract base type that defines a unique force characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class ForceCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is the nominal value of the force characteristic./>
        public Units.ForceValueType TargetValue { get; set; }
    }

    /// <remarks The UserDefinedForceCharacteristicNominalType is a characteristic nominal specified by the user that is measured in force units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedForceCharacteristicNominalType : ForceCharacteristicNominalBaseType
    {
    }

    /// <remarks The MassCharacteristicNominalBaseType is the abstract base type that defines a unique mass characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class MassCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is the nominal value of the mass characteristic./>
        public Units.MassValueType TargetValue { get; set; }
    }

    /// <remarks The UserDefinedMassCharacteristicNominalType is
    /// a characteristic nominal specified by the user that is measured in mass units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedMassCharacteristicNominalType : MassCharacteristicNominalBaseType
    {
    }

    /// <remarks The PressureCharacteristicNominalBaseType is the abstract base type that defines a unique pressure characteristic nominal./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedPressureCharacteristicNominalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class PressureCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is the nominal value of the pressure characteristic./>
        public Units.PressureValueType TargetValue { get; set; }
    }

    /// <remarks The UserDefinedPressureCharacteristicNominalType is
    /// a characteristic nominal specified by the user that is measured in pressure units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedPressureCharacteristicNominalType : PressureCharacteristicNominalBaseType
    {
    }

    /// <remarks The SpeedCharacteristicNominalBaseType is the abstract base type
    /// that defines a unique speed characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class SpeedCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is the nominal value of the speed characteristic./>
        public Units.SpeedValueType TargetValue { get; set; }
    }

    /// <remarks The UserDefinedSpeedCharacteristicNominalType is
    /// a characteristic nominal specified by the user that is measured in speed units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedSpeedCharacteristicNominalType : SpeedCharacteristicNominalBaseType
    {
    }

    /// <remarks The TemperatureCharacteristicNominalBaseType is the abstract base type that defines a unique temperature characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class TemperatureCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is the nominal value of the temperature characteristic./>
        public Units.TemperatureValueType TargetValue { get; set; }
    }

    /// <remarks The UserDefinedTemperatureCharacteristicNominalType is
    /// a characteristic nominal specified by the user that is measured in temperature units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedTemperatureCharacteristicNominalType : TemperatureCharacteristicNominalBaseType
    {
    }

    /// <remarks The TimeCharacteristicNominalBaseType is the abstract base type that defines a unique time characteristic nominal./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class TimeCharacteristicNominalBaseType : CharacteristicNominalBaseType
    {
        /// <remarks The optional TargetValue element is the nominal value of the time characteristic./>
        public Units.TimeValueType TargetValue { get; set; }
    }

    /// <remarks The UserDefinedTimeCharacteristicNominalType is
    /// a characteristic nominal specified by the user that is measured in time units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedTimeCharacteristicNominalType : TimeCharacteristicNominalBaseType
    {
    }

    /// <remarks
    /// The UserDefinedUnitCharacteristicNominalType defines a unique
    /// user-defined characteristic nominal for a numerical characteristic
    /// that is specific to an application and has a numerical value and
    /// units that are not available in another user-defined characteristic
    /// type.In particular this type is not to be used to define the
    /// nominal for characteristics with linear units, angular units, or
    /// units of temperature, area, force, mass, pressure, speed, or time./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class UserDefinedUnitCharacteristicNominalType : CharacteristicNominalBaseType
    {
        /// <remarks
        /// This sequence consists of a TargetValue, followed by either
        /// or both of MaxValue and MinValue, followed by DefinedAsLimit.
        /// If both MaxValue and MinValue are given, MaxValue must be given first./>

        /// <remarks
        /// The TargetValue element is the nominal value of the characteristic./>
        public Units.UserDefinedUnitValueType TargetValue { get; set; }

        /// <remarks The choice is among (1) MaxValue, (2) MinValue, or (3) both
        /// (with MaxValue coming first). This choice structure is the
        /// normal XML schema language structure for 'one or both'./>
        [System.Xml.Serialization.XmlElementAttribute("MaxValue", typeof(Units.UserDefinedUnitValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValue", typeof(Units.UserDefinedUnitValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public Units.UserDefinedUnitValueType[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public UserDefinedUnitsChoiceEnum[] ItemsElementName { get; set; }

        /// <remarks/>
        public bool DefinedAsLimit { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum UserDefinedUnitsChoiceEnum
    {
        MaxValue,
        MinValue,
    }
}
