/*! \file MeasurementDeviceAccuracyBaseType.cs
	\brief Base type for more specific types of measurement device accuracy.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.MeasurementResources
{
    /// <remarks> The AccuracySourceType describes the source of an accuracy assertion.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AccuracySourceType
    {
        /// <remarks>
        /// The AccuracySourceEnum element describes an often-used type of accuracy source.
        /// The OtherAccuracySource element describes an accuracy source in natural language.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AccuracySourceEnum", typeof(AccuracySourceEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherAccuracySource", typeof(string))]
        public object Item { get; set; }
    }

    /// <remarks> The AccuracySourceEnumType enumerates values that describe the type of source of an accuracy statement.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum AccuracySourceEnumType
    {
        /// <remarks></remarks>
        MANUFACTURER_SPECIFICATION,

        /// <remarks></remarks>
        CUSTOM_CERTIFICATION,
    }


    /// <remarks> The abstract MeasurementDeviceAccuracyBaseType is the base type for
    /// more specific types of measurement device accuracy.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AACMMAccuracyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CartesianCMMAccuracyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NumericalLengthAccuracyType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class MeasurementDeviceAccuracyBaseType
    {
        /// <remarks> The EnvironmentalRange element is the range of environmental
        /// conditions within which the accuracy description is valid.</remarks>
        public EnvironmentalRangeType EnvironmentalRange { get; set; }
    }

    /// <remarks> The NumericalLengthAccuracyType defines the accuracy of a length or point measurement device.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class NumericalLengthAccuracyType : MeasurementDeviceAccuracyBaseType
    {
        /// <remarks> The AccuracyValue element is the accuracy.</remarks>
        public LinearValueType AccuracyValue { get; set; }
    }

    /// <remarks> The AACMMAccuracyType describes the accuracy of an articulated arm CMM.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AACMMAccuracyType : MeasurementDeviceAccuracyBaseType
    {
        /// <remarks> The AACMMAccuracyTest element is the test that was used to determine the accuracy.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AACMMB89Test", typeof(AACMMB89TestType))]
        [System.Xml.Serialization.XmlElementAttribute("AACMMISO10360Test", typeof(ISO10360TestType))]
        [System.Xml.Serialization.XmlElementAttribute("AACMMPointAccuracyTest", typeof(PointAccuracyTestType))]
        public CMMAccuracyTestBaseType AACMMAccuracyTest { get; set; }

        /// <remarks> The AccuracySource element is the source of the accuracy.</remarks>
        public AccuracySourceType AccuracySource { get; set; }
    }
}
