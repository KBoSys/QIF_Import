using System;
using System.Text.RegularExpressions;

namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks></remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticPartParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticDMEParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticCharacteristicParameterType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArithmeticFeatureParameterType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ArithmeticParameterBaseType : ArithmeticExpressionBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string? Parameter { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticPartParameterType : ArithmeticParameterBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticDMEParameterType : ArithmeticParameterBaseType
    {
        /// <remarks></remarks>
        public DMEClassNameEnumType DMEClassNameEnum { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DMEClassNameEnumType
    {

        /// <remarks></remarks>
        AACMM,

        /// <remarks></remarks>
        ALLDMES,

        /// <remarks></remarks>
        ANALOG_MICROMETER,

        /// <remarks></remarks>
        AUTOCOLLIMATOR,

        /// <remarks></remarks>
        CALIPER,

        /// <remarks></remarks>
        CAPACITIVE_SENSOR,

        /// <remarks></remarks>
        CARTESIAN_CMM,

        /// <remarks></remarks>
        CHARGE_COUPLED_DEVICE_CAMERA_SENSOR,

        /// <remarks></remarks>
        CMM,

        /// <remarks></remarks>
        COMPLEX_TACTILE_PROBE_SENSOR,

        /// <remarks></remarks>
        COMPUTED_TOMOGRAPHY,

        /// <remarks></remarks>
        CONFOCAL_CHROMATIC_SENSOR,

        /// <remarks></remarks>
        DIAL_CALIPER,

        /// <remarks></remarks>
        DIGITAL_CALIPER,

        /// <remarks></remarks>
        DIGITAL_MICROMETER,

        /// <remarks></remarks>
        DRAW_WIRE_SENSOR,

        /// <remarks></remarks>
        DVRT_SENSOR,

        /// <remarks></remarks>
        EDDY_CURRENT_SENSOR,

        /// <remarks></remarks>
        GAGE,

        /// <remarks></remarks>
        LASER_RADAR,

        /// <remarks></remarks>
        LASER_TRACKER,

        /// <remarks></remarks>
        LASER_TRIANGULATION_SENSOR,

        /// <remarks></remarks>
        LIGHT_PEN_CMM,

        /// <remarks></remarks>
        LVDT_SENSOR,

        /// <remarks></remarks>
        MAGNETO_INDUCTIVE_SENSOR,

        /// <remarks></remarks>
        MEASUREMENT_ROOM,

        /// <remarks></remarks>
        MICROMETER,

        /// <remarks></remarks>
        MICROSCOPE,

        /// <remarks></remarks>
        MULTIPLE_CARRIAGE_CARTESIAN_CMM,

        /// <remarks></remarks>
        OPTICAL_COMPARATOR,

        /// <remarks></remarks>
        PARALLEL_LINK_CMM,

        /// <remarks></remarks>
        PROBE_TIP,

        /// <remarks></remarks>
        SIMPLE_TACTILE_PROBE_SENSOR,

        /// <remarks></remarks>
        SINE_BAR,

        /// <remarks></remarks>
        STRUCTURED_LIGHT_SENSOR,

        /// <remarks></remarks>
        TACTILE_PROBE_SENSOR,

        /// <remarks></remarks>
        THEODOLITE,

        /// <remarks></remarks>
        TOOL_WITH_CCD_CAMERA_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_CAPACITIVE_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_COMPLEX_TACTILE_PROBE_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_CONFOCAL_CHROMATIC_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_DETACHABLE_SENSORS,

        /// <remarks></remarks>
        TOOL_WITH_DVRT_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_DRAW_WIRE_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_EDDY_CURRENT_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_INTEGRATED_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_LVDT_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_LASER_TRIANGULATION_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_MAGNETOINDUCTIVE_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_SIMPLE_TACTILE_PROBE_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_STRUCTURED_LIGHT_SENSOR,

        /// <remarks></remarks>
        TOOL_WITH_ULTRASONIC_SENSOR,

        /// <remarks></remarks>
        ULTRASONIC_SENSOR,

        /// <remarks></remarks>
        UNIVERSAL_DEVICE,

        /// <remarks></remarks>
        UNIVERSAL_LENGTH_MEASURING,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticCharacteristicParameterType : ArithmeticParameterBaseType
    {
        private CharacteristicTypeEnumType characteristicTypeField;

        [System.Xml.Serialization.XmlIgnore]
        public CharacteristicTypeEnumType CharacteristicType
        {
            get => characteristicTypeField;
            set => characteristicTypeField = value;
        }


        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElement]
        public string? CharacteristicTypeEnum 
        { 
            get => characteristicTypeField.ToString();
            set
            {
                characteristicTypeField = CharacteristicTypeEnumType.UNKNOWN;
                if (!string.IsNullOrEmpty(value))
                {
                    char[] charsToTrim = { ' ', '\n' };
                    var enumText = value.Trim(charsToTrim);

                    Enum.TryParse<CharacteristicTypeEnumType>(enumText, out characteristicTypeField);
                }
            }
        }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CharacteristicTypeEnumSpecified { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticFeatureParameterType : ArithmeticParameterBaseType
    {

        private FeatureTypeEnumType featureTypeEnumField;

        private bool featureTypeEnumFieldSpecified;

        /// <remarks></remarks>
        public FeatureTypeEnumType FeatureTypeEnum
        {
            get
            {
                return this.featureTypeEnumField;
            }
            set
            {
                this.featureTypeEnumField = value;
            }
        }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeatureTypeEnumSpecified
        {
            get
            {
                return this.featureTypeEnumFieldSpecified;
            }
            set
            {
                this.featureTypeEnumFieldSpecified = value;
            }
        }
    }

}
