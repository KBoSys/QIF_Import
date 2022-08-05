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
    /// <remarks The abstract MeasurementDeviceScalesBaseType is the base type for
    /// defining scales of different measurement devices./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianMeasurementDeviceScalesType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class MeasurementDeviceScalesBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CartesianMeasurementDeviceScalesType : MeasurementDeviceScalesBaseType
    {
        /// <remarks/>
        public MeasurementDeviceScaleType XScale { get; set; }

        /// <remarks/>
        public MeasurementDeviceScaleType YScale { get; set; }

        /// <remarks/>
        public MeasurementDeviceScaleType ZScale { get; set; }
    }

    /// <remarks The MeasurementDeviceScaleType describes a scale on a machine./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasurementDeviceScaleType
    {
        /// <remarks/>
        public string ScaleMaterial { get; set; }

        /// <remarks/>
        public decimal ScaleCoefficientOfExpansion { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleCoefficientOfExpansionSpecified { get; set; }

        /// <remarks/>
        public decimal ScaleCoefficientOfExpansionUncertainty { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleCoefficientOfExpansionUncertaintySpecified { get; set; }

        /// <remarks/>
        public TypeOfScaleType TypeOfScale { get; set; }

        /// <remarks/>
        public LinearValueType ScaleResolution { get; set; }

        /// <remarks/>
        public ScaleReferenceEnumType ScaleReference { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleReferenceSpecified { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TypeOfScaleType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherTypeOfScale", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TypeOfScaleEnum", typeof(TypeOfScaleEnumType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum TypeOfScaleEnumType
    {
        /// <remarks/>
        ELECTROOPTICAL_LINEAR,

        /// <remarks/>
        ELECTROOPTICAL_ROTARY,

        /// <remarks/>
        LASER_INTERFEROMETER_LINEAR,

        /// <remarks/>
        TIME_OF_FLIGHT_LINEAR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ScaleReferenceEnumType
    {
        /// <remarks/>
        SCALE_ABSOLUTE,

        /// <remarks/>
        SCALE_INCREMENTAL,
    }
}
