namespace QIF_Model.QIFLibrary.Expressions
{
    /// <remarks/>
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

        private string parameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticPartParameterType : ArithmeticParameterBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticDMEParameterType : ArithmeticParameterBaseType
    {

        private DMEClassNameEnumType dMEClassNameEnumField;

        /// <remarks/>
        public DMEClassNameEnumType DMEClassNameEnum
        {
            get
            {
                return this.dMEClassNameEnumField;
            }
            set
            {
                this.dMEClassNameEnumField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DMEClassNameEnumType
    {

        /// <remarks/>
        AACMM,

        /// <remarks/>
        ALLDMES,

        /// <remarks/>
        ANALOG_MICROMETER,

        /// <remarks/>
        AUTOCOLLIMATOR,

        /// <remarks/>
        CALIPER,

        /// <remarks/>
        CAPACITIVE_SENSOR,

        /// <remarks/>
        CARTESIAN_CMM,

        /// <remarks/>
        CHARGE_COUPLED_DEVICE_CAMERA_SENSOR,

        /// <remarks/>
        CMM,

        /// <remarks/>
        COMPLEX_TACTILE_PROBE_SENSOR,

        /// <remarks/>
        COMPUTED_TOMOGRAPHY,

        /// <remarks/>
        CONFOCAL_CHROMATIC_SENSOR,

        /// <remarks/>
        DIAL_CALIPER,

        /// <remarks/>
        DIGITAL_CALIPER,

        /// <remarks/>
        DIGITAL_MICROMETER,

        /// <remarks/>
        DRAW_WIRE_SENSOR,

        /// <remarks/>
        DVRT_SENSOR,

        /// <remarks/>
        EDDY_CURRENT_SENSOR,

        /// <remarks/>
        GAGE,

        /// <remarks/>
        LASER_RADAR,

        /// <remarks/>
        LASER_TRACKER,

        /// <remarks/>
        LASER_TRIANGULATION_SENSOR,

        /// <remarks/>
        LIGHT_PEN_CMM,

        /// <remarks/>
        LVDT_SENSOR,

        /// <remarks/>
        MAGNETO_INDUCTIVE_SENSOR,

        /// <remarks/>
        MEASUREMENT_ROOM,

        /// <remarks/>
        MICROMETER,

        /// <remarks/>
        MICROSCOPE,

        /// <remarks/>
        MULTIPLE_CARRIAGE_CARTESIAN_CMM,

        /// <remarks/>
        OPTICAL_COMPARATOR,

        /// <remarks/>
        PARALLEL_LINK_CMM,

        /// <remarks/>
        PROBE_TIP,

        /// <remarks/>
        SIMPLE_TACTILE_PROBE_SENSOR,

        /// <remarks/>
        SINE_BAR,

        /// <remarks/>
        STRUCTURED_LIGHT_SENSOR,

        /// <remarks/>
        TACTILE_PROBE_SENSOR,

        /// <remarks/>
        THEODOLITE,

        /// <remarks/>
        TOOL_WITH_CCD_CAMERA_SENSOR,

        /// <remarks/>
        TOOL_WITH_CAPACITIVE_SENSOR,

        /// <remarks/>
        TOOL_WITH_COMPLEX_TACTILE_PROBE_SENSOR,

        /// <remarks/>
        TOOL_WITH_CONFOCAL_CHROMATIC_SENSOR,

        /// <remarks/>
        TOOL_WITH_DETACHABLE_SENSORS,

        /// <remarks/>
        TOOL_WITH_DVRT_SENSOR,

        /// <remarks/>
        TOOL_WITH_DRAW_WIRE_SENSOR,

        /// <remarks/>
        TOOL_WITH_EDDY_CURRENT_SENSOR,

        /// <remarks/>
        TOOL_WITH_INTEGRATED_SENSOR,

        /// <remarks/>
        TOOL_WITH_LVDT_SENSOR,

        /// <remarks/>
        TOOL_WITH_LASER_TRIANGULATION_SENSOR,

        /// <remarks/>
        TOOL_WITH_MAGNETOINDUCTIVE_SENSOR,

        /// <remarks/>
        TOOL_WITH_SIMPLE_TACTILE_PROBE_SENSOR,

        /// <remarks/>
        TOOL_WITH_STRUCTURED_LIGHT_SENSOR,

        /// <remarks/>
        TOOL_WITH_ULTRASONIC_SENSOR,

        /// <remarks/>
        ULTRASONIC_SENSOR,

        /// <remarks/>
        UNIVERSAL_DEVICE,

        /// <remarks/>
        UNIVERSAL_LENGTH_MEASURING,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticCharacteristicParameterType : ArithmeticParameterBaseType
    {
        /// <remarks/>
        public CharacteristicTypeEnumType CharacteristicTypeEnum { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CharacteristicTypeEnumSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ArithmeticFeatureParameterType : ArithmeticParameterBaseType
    {

        private FeatureTypeEnumType featureTypeEnumField;

        private bool featureTypeEnumFieldSpecified;

        /// <remarks/>
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

        /// <remarks/>
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
