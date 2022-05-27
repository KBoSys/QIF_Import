/*! \file EnumTypes.cs
    \brief enumerations

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The DistanceBetweenAnalysisModeEnumType enumerates values that describe the analysis mode for a distance between characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DistanceBetweenAnalysisModeEnumType
    {
        ONEDIMENSIONAL,     /// <remarks evaluation is along an axis defined by a vector./>
        TWODIMENSIONAL,     /// <remarks evaluation is in a plane perpendicular to a vector./>
        THREEDIMENSIONAL,   /// <remarks a point to point evaluation not requiring a vector./>
    }

    /// <remarks The MeasurementDirectiveEnumType enumerates values that describe the method of measurement between two features./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum MeasurementDirectiveEnumType
    {
        MINIMUM,    /// <remarks use minimum distance/>
        MAXIMUM,    /// <remarks use maximum distance/>
        AVERAGE,    /// <remarks use average distance/>
        UNDEFINED,  /// <remarks No specific method is required. Use any appropriate method./>
    }

    /// <remarks The MeasurementDirectiveType defines the method of measurement between two features./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasurementDirectiveType
    {
        /// <remarks The MeasurementDirectiveEnum element describes an often-used method of measurement between two features./>
        /// <remarks The OtherMeasurementDirective element describes the method of measurement between two features in natural language./>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDirectiveEnum", typeof(MeasurementDirectiveEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherMeasurementDirective", typeof(string))]
        public object Item { get; set; }
    }
}
