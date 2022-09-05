/*! \file MeasurementDevicesType.cs
	\brief Defines a measurement device that is intended to be operated hands-on by a human user

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The ManualMeasurementDeviceType defines a measurement device
    /// that is intended to be operated hands-on by a human user - not
    /// with a joystick or other electronic control interface device.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SineBarType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GageDeviceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MicrometerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MicrometerDigitalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MicrometerAnalogType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaliperType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaliperDigitalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaliperDialType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ManualMeasurementDeviceType : MeasurementDeviceType
    {
        /// <remarks> The optional MinMeasuringDistance element is the minimum measuring distance for a manual measurement device.</remarks>
        public LinearValueType? MinMeasuringDistance { get; set; }

        /// <remarks> The optional MaxMeasuringDistance element is the maximum measuring distance for a manual measurement device.</remarks>
        public LinearValueType? MaxMeasuringDistance { get; set; }
    }

    /// <remarks> The SineBarType defines a sine bar.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SineBarType : ManualMeasurementDeviceType
    {
        /// <remarks> The optional NominalBallCenterToBallCenterLength element defines the nominal distance between the two sine bar balls.</remarks>
        public LinearValueType? NominalBallCenterToBallCenterLength { get; set; }

        /// <remarks> The optional CylinderCenterToCylinderCenterAccuracy element
        /// defines the accuracy between the two sine bar cylinder centers.</remarks>
        public LinearValueType? CylinderCenterToCylinderCenterAccuracy { get; set; }

        /// <remarks> The optional Parallelism element is the parallelism
        /// between the upper and lower planes of a sine bar.</remarks>
        public LinearValueType? Parallelism { get; set; }

        /// <remarks> The optional OverallLength element is the overall
        /// length of a sine bar.</remarks>
        public LinearValueType? OverallLength { get; set; }

        /// <remarks> The optional Material element is the material that a sine bar is made.</remarks>
        public string? Material { get; set; }

        /// <remarks> The optional Magnetic element is the magnetic capability of a sine bar.</remarks>
        public bool Magnetic { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MagneticSpecified { get; set; }

        /// <remarks> The optional Width element is the width of a sine bar. </remarks>
        public LinearValueType? Width { get; set; }
    }

    /// <remarks> The global GageDevice element gives information about a gage device.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class GageDeviceType : ManualMeasurementDeviceType
    {
    }

    /// <remarks> The MicrometerType defines a micrometer.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MicrometerDigitalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MicrometerAnalogType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MicrometerType : ManualMeasurementDeviceType
    {
        /// <remarks></remarks>
        public LinearResolutionType? LinearResolution { get; set; }

        /// <remarks></remarks>
        public NumericalLengthAccuracyType? Accuracy { get; set; }

        /// <remarks></remarks>
        public ForceValueType? MeasuringForce { get; set; }

        /// <remarks></remarks>
        [System.ComponentModel.DefaultValueAttribute(InternalExternalEnumType.INTERNAL)]
        public InternalExternalEnumType InternalExternal { get; set; } = InternalExternalEnumType.INTERNAL;
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MicrometerDigitalType : MicrometerType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MicrometerAnalogType : MicrometerType
    {
    }

    /// <remarks></remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaliperDigitalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaliperDialType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CaliperType : ManualMeasurementDeviceType
    {
        /// <remarks></remarks>
        public LinearResolutionType? LinearResolution { get; set; }

        /// <remarks></remarks>
        public NumericalLengthAccuracyType? Accuracy { get; set; }

        /// <remarks></remarks>
        public bool CanMeasureInnerD { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CanMeasureInnerDSpecified { get; set; }

        /// <remarks></remarks>
        public bool CanMeasureOuterD { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CanMeasureOuterDSpecified { get; set; }

        /// <remarks></remarks>
        public bool CanMeasureDepth { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CanMeasureDepthSpecified { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CaliperDigitalType : CaliperType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CaliperDialType : CaliperType
    {
    }
}
