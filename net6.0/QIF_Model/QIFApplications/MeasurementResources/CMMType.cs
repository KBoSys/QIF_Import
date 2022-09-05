/*! \file CMMType.cs
	\brief Defines a CMM measurement device. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks></remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AACMMType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelLinkCMMType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LightPenCMMType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCMMType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultipleCarriageCartesianCMMType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CMMType : UniversalDeviceType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AACMMType : CMMType
    {
        /// <remarks></remarks>
        public PointType? HomeLocation { get; set; }

        /// <remarks></remarks>
        public int NumberOfJoints { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfJointsSpecified { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? ProbeTipDiameter { get; set; }

        /// <remarks></remarks>
        public AACMMAccuraciesType? Accuracies { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AACMMAccuraciesType : ArrayBaseType<AACMMAccuracyType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("AACMMAccuracy")]
        public AACMMAccuracyType[] Items { get => itemsField; set => itemsField = value; }
    }

    /// <remarks> The XYZLinearSpecificationType defines the linear specifications in
    /// any Cartesian coordinate system device.This specification could be
    /// backlash, motion range, minimum incremental motion, resolution, etc.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class XYZLinearSpecificationType
    {
        /// <remarks></remarks>
        public LinearValueType? X { get; set; }

        /// <remarks></remarks>
        public LinearValueType? Y { get; set; }

        /// <remarks></remarks>
        public LinearValueType? Z { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ParallelLinkCMMType : CMMType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMSpeeds", typeof(CartesianCMMSpeedsType))]
        [System.Xml.Serialization.XmlElementAttribute("ParallelLinkCMMSpeeds", typeof(ParallelLinkCMMSpeedsType))]
        public CMMSpeedsBaseType? CMMSpeeds { get; set; }

        /// <remarks></remarks>
        public XYZLinearSpecificationType? AxesTravelDistance { get; set; }

        /// <remarks></remarks>
        public AngularValueType? AxesRotationAngle { get; set; }

        /// <remarks></remarks>
        public XYZLinearSpecificationType? AxisBacklash { get; set; }

        /// <remarks></remarks>
        public XYZLinearSpecificationType? AxisRepeatability { get; set; }

        /// <remarks></remarks>
        public MassValueType? MaxLoad { get; set; }

        /// <remarks></remarks>
        public string? StageMaterial { get; set; }

        /// <remarks></remarks>
        public ForceValueType? MaxHoldingForce { get; set; }

        /// <remarks></remarks>
        public string? MotorType { get; set; }

        /// <remarks></remarks>
        public StiffnessType LinksStiffness { get; set; }

        /// <remarks></remarks>
        public ArrayReferenceType? ToolIds { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StiffnessType
    {
        /// <remarks></remarks>
        public UserDefinedUnitValueType? XStiffness { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? YStiffness { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? ZStiffness { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LightPenCMMType : CMMType
    {
        /// <remarks></remarks>
        public ChargeCoupledDeviceCameraSensorType LightPenCMMChargeCoupledDeviceCameraSensor { get; set; }

        /// <remarks></remarks>
        public string? LightSource { get; set; }

        /// <remarks></remarks>
        public LinearValueType? NominalVolumetricAccuracy { get; set; }

        /// <remarks></remarks>
        public LinearValueType? ActualVolumetricAccuracy { get; set; }

        /// <remarks></remarks>
        public LinearValueType? NominalSinglePointAccuracy { get; set; }

        /// <remarks></remarks>
        public LinearValueType? ActualSinglePointAccuracy { get; set; }

        /// <remarks></remarks>
        public UserDefinedUnitValueType? ScanningSpeed { get; set; }

        /// <remarks></remarks>
        public string? LaserClass { get; set; }
    }

    /// <remarks></remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultipleCarriageCartesianCMMType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianCMMType : CMMType
    {
        /// <remarks></remarks>
        public PointType? HomeLocation { get; set; }

        /// <remarks></remarks>
        public CartesianCMMGeometryType CMMGeometry { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMAxisDirections", typeof(CartesianCMMAxisDirectionsType))]
        public CMMAxisDirectionsBaseType CMMAxisDirections { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("CartesianMeasurementDeviceScales", typeof(CartesianMeasurementDeviceScalesType))]
        public MeasurementDeviceScalesBaseType Scales { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxWorkpieceHeight { get; set; }

        /// <remarks></remarks>
        public MassValueType? MaxWorkpieceMass { get; set; }

        /// <remarks></remarks>
        public CartesianCMMSpeedsType? JoystickSpeeds { get; set; }

        /// <remarks></remarks>
        public CMMSpeedsBaseType? CMMSpeeds { get; set; }

        /// <remarks></remarks>
        public RotaryTableType? RotaryTable { get; set; }

        /// <remarks></remarks>
        public CartesianCMMAccuraciesType? Accuracies { get; set; }

        /// <remarks></remarks>
        public ArrayReferenceType? ToolIds { get; set; }

        /// <remarks></remarks>
        public ArrayReferenceType? SensorIds { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MultipleCarriageCartesianCMMType : CartesianCMMType
    {
        /// <remarks></remarks>
        public CarriagesType? Carriages { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianCMMGeometryType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMGeometryEnum", typeof(CartesianCMMGeometryEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCartesianCMMGeometry", typeof(string))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CartesianCMMGeometryEnumType
    {

        /// <remarks></remarks>
        FIXED_BRIDGE,

        /// <remarks></remarks>
        MOVING_BRIDGE,

        /// <remarks></remarks>
        L_SHAPED_BRIDGE,

        /// <remarks></remarks>
        COLUMN,

        /// <remarks></remarks>
        FIXED_TABLE_CANTILEVER_ARM,

        /// <remarks></remarks>
        MOVING_TABLE_CANTILEVER_ARM,

        /// <remarks></remarks>
        FIXED_TABLE_HORIZONTAL_ARM,

        /// <remarks></remarks>
        MOVING_TABLE_HORIZONTAL_ARM,

        /// <remarks></remarks>
        MOVING_RAM_HORIZONTAL_ARM,

        /// <remarks></remarks>
        GANTRY,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class RotaryTableType
    {
        /// <remarks></remarks>
        public PointType? LocationOnCMM { get; set; }

        /// <remarks></remarks>
        public UnitVectorType? AxisDirection { get; set; }

        /// <remarks></remarks>
        public UnitVectorType? ZeroIndexDirection { get; set; }

        /// <remarks></remarks>
        public LinearValueType? TableRadius { get; set; }

        /// <remarks></remarks>
        public TableErrorsType? TableErrors { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TableErrorsType
    {
        /// <remarks></remarks>
        public LinearValueType? AxialError { get; set; }

        /// <remarks></remarks>
        public LinearValueType? RadialError { get; set; }

        /// <remarks></remarks>
        public LinearValueType? TangentialError { get; set; }
    }
}
