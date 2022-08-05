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
    /// <remarks/>
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AACMMType : CMMType
    {
        /// <remarks/>
        public PointType HomeLocation { get; set; }

        /// <remarks/>
        public int NumberOfJoints { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfJointsSpecified { get; set; }

        /// <remarks/>
        public LinearValueType MinMeasuringDistance { get; set; }

        /// <remarks/>
        public LinearValueType MaxMeasuringDistance { get; set; }

        /// <remarks/>
        public LinearValueType ProbeTipDiameter { get; set; }

        /// <remarks/>
        public AACMMAccuraciesType Accuracies { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AACMMAccuraciesType : ArrayBaseType<AACMMAccuracyType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AACMMAccuracy")]
        public AACMMAccuracyType[] Items { get => itemsField; set => itemsField = value; }
    }

    /// <remarks The XYZLinearSpecificationType defines the linear specifications in
    /// any Cartesian coordinate system device.This specification could be
    /// backlash, motion range, minimum incremental motion, resolution, etc./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class XYZLinearSpecificationType
    {
        /// <remarks/>
        public LinearValueType X { get; set; }

        /// <remarks/>
        public LinearValueType Y { get; set; }

        /// <remarks/>
        public LinearValueType Z { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ParallelLinkCMMType : CMMType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMSpeeds", typeof(CartesianCMMSpeedsType))]
        [System.Xml.Serialization.XmlElementAttribute("ParallelLinkCMMSpeeds", typeof(ParallelLinkCMMSpeedsType))]
        public CMMSpeedsBaseType CMMSpeeds { get; set; }

        /// <remarks/>
        public XYZLinearSpecificationType AxesTravelDistance { get; set; }

        /// <remarks/>
        public AngularValueType AxesRotationAngle { get; set; }

        /// <remarks/>
        public XYZLinearSpecificationType AxisBacklash { get; set; }

        /// <remarks/>
        public XYZLinearSpecificationType AxisRepeatability { get; set; }

        /// <remarks/>
        public MassValueType MaxLoad { get; set; }

        /// <remarks/>
        public string StageMaterial { get; set; }

        /// <remarks/>
        public ForceValueType MaxHoldingForce { get; set; }

        /// <remarks/>
        public string MotorType { get; set; }

        /// <remarks/>
        public StiffnessType LinksStiffness { get; set; }

        /// <remarks/>
        public ArrayReferenceType ToolIds { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StiffnessType
    {
        /// <remarks/>
        public UserDefinedUnitValueType XStiffness { get; set; }

        /// <remarks/>
        public UserDefinedUnitValueType YStiffness { get; set; }

        /// <remarks/>
        public UserDefinedUnitValueType ZStiffness { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LightPenCMMType : CMMType
    {
        /// <remarks/>
        public ChargeCoupledDeviceCameraSensorType LightPenCMMChargeCoupledDeviceCameraSensor { get; set; }

        /// <remarks/>
        public string LightSource { get; set; }

        /// <remarks/>
        public LinearValueType NominalVolumetricAccuracy { get; set; }

        /// <remarks/>
        public LinearValueType ActualVolumetricAccuracy { get; set; }

        /// <remarks/>
        public LinearValueType NominalSinglePointAccuracy { get; set; }

        /// <remarks/>
        public LinearValueType ActualSinglePointAccuracy { get; set; }

        /// <remarks/>
        public UserDefinedUnitValueType ScanningSpeed { get; set; }

        /// <remarks/>
        public string LaserClass { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultipleCarriageCartesianCMMType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianCMMType : CMMType
    {
        /// <remarks/>
        public PointType HomeLocation { get; set; }

        /// <remarks/>
        public CartesianCMMGeometryType CMMGeometry { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMAxisDirections", typeof(CartesianCMMAxisDirectionsType))]
        public CMMAxisDirectionsBaseType CMMAxisDirections { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CartesianMeasurementDeviceScales", typeof(CartesianMeasurementDeviceScalesType))]
        public MeasurementDeviceScalesBaseType Scales { get; set; }

        /// <remarks/>
        public LinearValueType MaxWorkpieceHeight { get; set; }

        /// <remarks/>
        public MassValueType MaxWorkpieceMass { get; set; }

        /// <remarks/>
        public CartesianCMMSpeedsType JoystickSpeeds { get; set; }

        /// <remarks/>
        public CMMSpeedsBaseType CMMSpeeds { get; set; }

        /// <remarks/>
        public RotaryTableType RotaryTable { get; set; }

        /// <remarks/>
        public CartesianCMMAccuraciesType Accuracies { get; set; }

        /// <remarks/>
        public ArrayReferenceType ToolIds { get; set; }

        /// <remarks/>
        public ArrayReferenceType SensorIds { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MultipleCarriageCartesianCMMType : CartesianCMMType
    {
        /// <remarks/>
        public CarriagesType Carriages { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianCMMGeometryType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CartesianCMMGeometryEnum", typeof(CartesianCMMGeometryEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCartesianCMMGeometry", typeof(string))]
        public object Item { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum CartesianCMMGeometryEnumType
    {

        /// <remarks/>
        FIXED_BRIDGE,

        /// <remarks/>
        MOVING_BRIDGE,

        /// <remarks/>
        L_SHAPED_BRIDGE,

        /// <remarks/>
        COLUMN,

        /// <remarks/>
        FIXED_TABLE_CANTILEVER_ARM,

        /// <remarks/>
        MOVING_TABLE_CANTILEVER_ARM,

        /// <remarks/>
        FIXED_TABLE_HORIZONTAL_ARM,

        /// <remarks/>
        MOVING_TABLE_HORIZONTAL_ARM,

        /// <remarks/>
        MOVING_RAM_HORIZONTAL_ARM,

        /// <remarks/>
        GANTRY,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class RotaryTableType
    {
        /// <remarks/>
        public PointType LocationOnCMM { get; set; }

        /// <remarks/>
        public UnitVectorType AxisDirection { get; set; }

        /// <remarks/>
        public UnitVectorType ZeroIndexDirection { get; set; }

        /// <remarks/>
        public LinearValueType TableRadius { get; set; }

        /// <remarks/>
        public TableErrorsType TableErrors { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TableErrorsType
    {
        /// <remarks/>
        public LinearValueType AxialError { get; set; }

        /// <remarks/>
        public LinearValueType RadialError { get; set; }

        /// <remarks/>
        public LinearValueType TangentialError { get; set; }
    }
}
