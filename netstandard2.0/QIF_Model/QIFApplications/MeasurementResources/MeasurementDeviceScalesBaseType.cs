/*! \file MeasurementDeviceScalesBaseType.cs
	\brief Base type for defining scales of different measurement devices.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The abstract MeasurementDeviceScalesBaseType is the base type for
    /// defining scales of different measurement devices.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianMeasurementDeviceScalesType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class MeasurementDeviceScalesBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianMeasurementDeviceScalesType : MeasurementDeviceScalesBaseType
    {
        /// <remarks></remarks>
        public MeasurementDeviceScaleType XScale { get; set; }

        /// <remarks></remarks>
        public MeasurementDeviceScaleType YScale { get; set; }

        /// <remarks></remarks>
        public MeasurementDeviceScaleType ZScale { get; set; }
    }

    /// <remarks> The MeasurementDeviceScaleType describes a scale on a machine.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasurementDeviceScaleType
    {
        /// <remarks></remarks>
        public string ScaleMaterial { get; set; }

        /// <remarks></remarks>
        public decimal ScaleCoefficientOfExpansion { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleCoefficientOfExpansionSpecified { get; set; }

        /// <remarks></remarks>
        public decimal ScaleCoefficientOfExpansionUncertainty { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleCoefficientOfExpansionUncertaintySpecified { get; set; }

        /// <remarks></remarks>
        public TypeOfScaleType TypeOfScale { get; set; }

        /// <remarks></remarks>
        public LinearValueType ScaleResolution { get; set; }

        /// <remarks></remarks>
        public ScaleReferenceEnumType ScaleReference { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleReferenceSpecified { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TypeOfScaleType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("OtherTypeOfScale", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TypeOfScaleEnum", typeof(TypeOfScaleEnumType))]
        public object Item { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum TypeOfScaleEnumType
    {
        /// <remarks></remarks>
        ELECTROOPTICAL_LINEAR,

        /// <remarks></remarks>
        ELECTROOPTICAL_ROTARY,

        /// <remarks></remarks>
        LASER_INTERFEROMETER_LINEAR,

        /// <remarks></remarks>
        TIME_OF_FLIGHT_LINEAR,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ScaleReferenceEnumType
    {
        /// <remarks></remarks>
        SCALE_ABSOLUTE,

        /// <remarks></remarks>
        SCALE_INCREMENTAL,
    }
}
