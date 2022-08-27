/*! \file RunoutCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured runout characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The RunoutCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured runout characteristic evaluation.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalRunoutCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularRunoutCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class RunoutCharacteristicMeasurementBaseType : GeometricCharacteristicMeasurementBaseType
    {
        /// <remarks> The optional DatumsOk element specifies whether the datum
        /// features passed all their associated characteristic
        /// evaluations.The element is set to "true" for passed all,
        /// is set to "false" for did not pass all, and is not present
        /// if the status of the datum features is unknown.</remarks>
        public bool DatumsOk { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumsOkSpecified { get; set; }
    }

    /// <remarks> The TotalRunoutCharacteristicMeasurementType defines a total runout characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class TotalRunoutCharacteristicMeasurementType : RunoutCharacteristicMeasurementBaseType
    {
    }

    /// <remarks> The global CircularRunoutCharacteristicMeasurement element gives information about a circular runout characteristic measurement.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularRunoutCharacteristicMeasurementType : RunoutCharacteristicMeasurementBaseType
    {
    }
}
