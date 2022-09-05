/*! \file CharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured characteristic

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The CharacteristicMeasurementBaseType is the abstract base type that
    /// defines the results of a measured characteristic evaluation holding measured/analyzed values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CharacteristicMeasurementBaseType : CharacteristicBaseType
    {
        /// <remarks> The Status element is the tolerance condition: pass (in tolerance), fail(out of tolerance), etc.</remarks>
        public CharacteristicStatusType? Status { get; set; }

        /// <remarks> The CharacteristicItemId element is the QIF id of the associated characteristic item.</remarks>
        [System.Xml.Serialization.XmlElement]
        public QIFReferenceType? CharacteristicItemId { get; set; }

        /// <remarks> The optional TimeStamp element is the date and time at which the characteristic was measured.</remarks>
        public System.DateTime TimeStamp { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeStampSpecified { get; set; }

        /// <remarks> The optional FeatureMeasurementIds element is a list of QIF
        /// ids of the feature measurements to which this characteristic applies.</remarks>
        public ArrayReferenceType? FeatureMeasurementIds { get; set; }

        /// <remarks> The optional SubstituteFeatureAlgorithm element is the
        /// actual substitute feature data fitting algorithm used for
        /// the feature or features.This setting may differ from the
        /// substitute feature algorithm defined on the feature
        /// nominal, feature item, characteristic nominal or characteristic item.</remarks>
        public IntermediatesPMI.SubstituteFeatureAlgorithmType? SubstituteFeatureAlgorithm { get; set; }

        /// <remarks> The optional ActualComponentId element is the QIF id of the
        /// actual component to which this characteristic applies.</remarks>
        public QIFReferenceType? ActualComponentId { get; set; }

        /// <remarks> The optional MeasurementDeviceIds element is a list of
        /// references to the measurement devices used in the inspection of the characteristic.</remarks>
        public ArrayReferenceType? MeasurementDeviceIds { get; set; }

        /// <remarks> The optional ManufacturingProcessId element is a
        /// reference to the traceability information for process used to manufacture this characteristic.</remarks>
        public QIFReferenceType? ManufacturingProcessId { get; set; }

        /// <remarks> The optional NotedEventIds element is a list of QIF ids of
        /// noted events that happened during the measurement of this characteristic.</remarks>
        public ArrayReferenceType? NotedEventIds { get; set; }

        /// <remarks> The optional NonConformanceDesignator element is an
        /// indication that the characteristic is non-conforming.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string? NonConformanceDesignator { get; set; }
    }

    /// <remarks> The SurfaceTextureCharacteristicMeasurementType defines the results
    /// of a measured surface texture characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceTextureCharacteristicMeasurementType : CharacteristicMeasurementBaseType
    {
        /// <remarks> The optional RoughnessAverage element is the measured Roughness Average(Ra) value.</remarks>
        public Units.MeasuredLinearValueType? RoughnessAverageValue { get; set; }
    }

    /// <remarks> The UserDefinedUnitCharacteristicMeasurementType defines the
    /// results of a measured user-defined characteristic evaluation that
    /// is specific to an application and has a numerical value and units
    /// that are not available in another user-defined characteristic type.
    /// In particular this type is not to be used to define the measurement
    /// for characteristics with linear units, angular units, or units of
    /// temperature, area, force, mass, pressure, speed, or time.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedUnitCharacteristicMeasurementType : CharacteristicMeasurementBaseType
    {
        /// <remarks> The optional Value element is the measured value of the characteristic.</remarks>
        public MeasuredUserDefinedUnitValueType? Value { get; set; }

        /// <remarks> The optional MaxValue element is the maximum of the measured value when reported.</remarks>
        public MeasuredUserDefinedUnitValueType? MaxValue { get; set; }

        /// <remarks> The optional MinValue element is the minimum of the measured value when reported.</remarks>
        public MeasuredUserDefinedUnitValueType? MinValue { get; set; }
    }

    /// <remarks> The UserDefinedAttributeCharacteristicMeasurementType defines the
    /// results of a measured user-defined characteristic evaluation.The
    /// Value must be one of the PassValues or FailValues given in the corresponding nominal characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedAttributeCharacteristicMeasurementType : CharacteristicMeasurementBaseType
    {
        /// <remarks> The optional Value element is the measured value for the user-defined attribute characteristic.</remarks>
        public string? Value { get; set; }
    }
}
