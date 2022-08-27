/*! \file TimeCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured time characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The TimeCharacteristicMeasurementBaseType is the abstract base type
    /// that defines the results of a measured time characteristic evaluation.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedTimeCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class TimeCharacteristicMeasurementBaseType : UnitCharacteristicMeasurementBaseType<MeasuredTimeValueType>
    {
    }

    /// <remarks> The UserDefinedTimeCharacteristicMeasurementType is
    /// a characteristic measurement specified by the user that is measured in time units.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedTimeCharacteristicMeasurementType : TimeCharacteristicMeasurementBaseType
    {
    }

}
