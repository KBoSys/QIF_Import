/*! \file EnumTypes.cs
    \brief enumerations

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks> The DistanceBetweenAnalysisModeEnumType enumerates values that describe the analysis mode for a distance between characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DistanceBetweenAnalysisModeEnumType
    {
        ONEDIMENSIONAL,     /// <remarks> evaluation is along an axis defined by a vector.</remarks>
        TWODIMENSIONAL,     /// <remarks> evaluation is in a plane perpendicular to a vector.</remarks>
        THREEDIMENSIONAL,   /// <remarks> a point to point evaluation not requiring a vector.</remarks>
    }

    /// <remarks> The MeasurementDirectiveEnumType enumerates values that describe the method of measurement between two features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum MeasurementDirectiveEnumType
    {
        MINIMUM,    /// <remarks> use minimum distance</remarks>
        MAXIMUM,    /// <remarks> use maximum distance</remarks>
        AVERAGE,    /// <remarks> use average distance</remarks>
        UNDEFINED,  /// <remarks> No specific method is required. Use any appropriate method.</remarks>
    }

    /// <remarks> The MeasurementDirectiveType defines the method of measurement between two features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasurementDirectiveType
    {
        /// <remarks> The MeasurementDirectiveEnum element describes an often-used method of measurement between two features.</remarks>
        /// <remarks> The OtherMeasurementDirective element describes the method of measurement between two features in natural language.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDirectiveEnum", typeof(MeasurementDirectiveEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherMeasurementDirective", typeof(string))]
        public object Item { get; set; }
    }
}
