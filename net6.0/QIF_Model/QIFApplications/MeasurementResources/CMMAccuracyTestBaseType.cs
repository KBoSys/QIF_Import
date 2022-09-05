/*! \file CMMAccuracyTestBaseType.cs
	\brief Base type for CMM accuracy tests.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The abstract CMMAccuracyTestBaseType is the base type for CMM accuracy tests.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointAccuracyTestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ISO10360TestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AACMMB89TestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCMMB89TestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FPSTestType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CMMAccuracyTestBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointAccuracyTestType : CMMAccuracyTestBaseType
    {
        /// <remarks></remarks>
        public LinearValueType? Accuracy { get; set; }
    }

    /// <remarks> The LinearErrorType defines a maximum error that increases
    /// linearly with the distance measured.To compute the error, add
    /// the BaseError to the ErrorRate times the distance measured.
    /// The units for distance measured must be the same as those of
    /// the BaseError.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinearErrorType
    {
        /// <remarks> The BaseError element gives the constant to add.</remarks>
        public LinearValueType? BaseError { get; set; }

        /// <remarks> The ErrorRate element gives the rate of increase with distance of the error.</remarks>
        public decimal ErrorRate { get; set; }
    }

    /// <remarks> The AngularErrorType defines a maximum angular error that increases
    /// linearly with the distance from measuring angle.To compute the
    /// error, add the BaseError to the ErrorRate times the distance from
    /// angle being measured.The units for angle being measured must be
    /// the same as those of the BaseError (This type of error is common in laser trackers).</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularErrorType
    {
        /// <remarks> The BaseError element gives the constant to add.</remarks>
        public AngularValueType? BaseError { get; set; }

        /// <remarks> The ErrorRate element gives the rate of increase with distance of the error.</remarks>
        public decimal ErrorRate { get; set; }
    }


    /// <remarks> The LesserErrorType defines a maximum error that is the lesser
    /// of a constant error or a linear error.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LesserErrorType
    {
        /// <remarks> The MaxErrorConstant element gives the maximum error in measuring a distance as a constant.</remarks>
        public LinearValueType? MaxErrorConstant { get; set; }

        /// <remarks> The LinearError element gives the maximum error in
        /// measuring a distance as a linear function of the distance measured.</remarks>
        public LinearErrorType? LinearError { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ISO10360TestType : CMMAccuracyTestBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("LesserError", typeof(LesserErrorType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearError", typeof(LinearErrorType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxErrorConstant", typeof(LinearValueType))]
        public object? Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EffectiveDiameterPerformanceTestType
    {
        /// <remarks></remarks>
        public decimal AverageDiameter { get; set; }

        /// <remarks></remarks>
        public decimal StandardDeviation { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SinglePointArticulationPerformanceTestType
    {
        /// <remarks></remarks>
        public LinearValueType? MaxDeviationFromAverageNear { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxDeviationFromAverageFar { get; set; }

        /// <remarks></remarks>
        public LinearValueType? MaxDeviationFromAverageMiddle { get; set; }

        /// <remarks></remarks>
        public LinearValueType? TwiceStandardDeviationNear { get; set; }

        /// <remarks></remarks>
        public LinearValueType? TwiceStandardDeviationFar { get; set; }

        /// <remarks></remarks>
        public LinearValueType? TwiceStandardDeviationMiddle { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class VolumetricPerformanceTestType
    {
        /// <remarks></remarks>
        public TwentyLinearValuesType? DeviationsFromCalibration { get; set; }

        /// <remarks></remarks>
        public LinearValueType? TwiceStandardDeviation { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TwentyLinearValuesType : ArrayBaseType<LinearValueType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("LinearValue")]
        public LinearValueType[]? Items { get => itemsField; set => itemsField = value; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AACMMB89TestType : CMMAccuracyTestBaseType
    {
        /// <remarks></remarks>
        public EffectiveDiameterPerformanceTestType? EffectiveDiameterPerformanceTest { get; set; }

        /// <remarks></remarks>
        public SinglePointArticulationPerformanceTestType? SinglePointArticulationPerformanceTest { get; set; }

        /// <remarks></remarks>
        public VolumetricPerformanceTestType? VolumetricPerformanceTest { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianCMMB89TestType : CMMAccuracyTestBaseType
    {
        /// <remarks></remarks>
        public LinearValueType? XLinearAccuracy { get; set; }

        /// <remarks></remarks>
        public LinearValueType? YLinearAccuracy { get; set; }

        /// <remarks></remarks>
        public LinearValueType? ZLinearAccuracy { get; set; }

        /// <remarks></remarks>
        public LinearValueType? OffsetVolumetricPerformance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? VolumetricPerformance { get; set; }

        /// <remarks></remarks>
        public LinearValueType? Repeatability { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FPSTestType : CMMAccuracyTestBaseType
    {
        /// <remarks></remarks>
        public LengthFunctionDiscreteType? XLinearity { get; set; }

        /// <remarks></remarks>
        public LengthFunctionDiscreteType? YLinearity { get; set; }

        /// <remarks></remarks>
        public LengthFunctionDiscreteType? ZLinearity { get; set; }

        /// <remarks></remarks>
        public AngleFunctionDiscreteType? XAxisRoll { get; set; }

        /// <remarks></remarks>
        public AngleFunctionDiscreteType? XAxisPitch { get; set; }

        /// <remarks></remarks>
        public AngleFunctionDiscreteType? XAxisYaw { get; set; }

        /// <remarks></remarks>
        public AngleFunctionDiscreteType? YAxisRoll { get; set; }

        /// <remarks></remarks>
        public AngleFunctionDiscreteType? YAxisPitch { get; set; }

        /// <remarks></remarks>
        public AngleFunctionDiscreteType? YAxisYaw { get; set; }

        /// <remarks></remarks>
        public AngleFunctionDiscreteType? ZAxisRoll { get; set; }

        /// <remarks></remarks>
        public AngleFunctionDiscreteType? ZAxisPitch { get; set; }

        /// <remarks></remarks>
        public AngleFunctionDiscreteType? ZAxisYaw { get; set; }

        /// <remarks></remarks>
        public LengthFunctionDiscreteType? XAxisStraightnessY { get; set; }

        /// <remarks></remarks>
        public LengthFunctionDiscreteType? XAxisStraightnessZ { get; set; }

        /// <remarks></remarks>
        public LengthFunctionDiscreteType? YAxisStraightnessX { get; set; }

        /// <remarks></remarks>
        public LengthFunctionDiscreteType? YAxisStraightnessZ { get; set; }

        /// <remarks></remarks>
        public LengthFunctionDiscreteType? ZAxisStraightnessX { get; set; }

        /// <remarks></remarks>
        public LengthFunctionDiscreteType? ZAxisStraightnessY { get; set; }

        /// <remarks></remarks>
        public double XYSquareness { get; set; }

        /// <remarks></remarks>
        public double XZSquareness { get; set; }

        /// <remarks></remarks>
        public double YZSquareness { get; set; }
    }
}
