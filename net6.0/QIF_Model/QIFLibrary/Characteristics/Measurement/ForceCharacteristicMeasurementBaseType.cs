/*! \file ForceCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured pressure characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The ForceCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured pressure characteristic evaluation.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedForceCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ForceCharacteristicMeasurementBaseType : UnitCharacteristicMeasurementBaseType<MeasuredForceValueType>
    {
    }

    /// <remarks> The UserDefinedForceCharacteristicMeasurementType is
    /// a characteristic measurement specified by the user that is measured in pressure units.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedForceCharacteristicMeasurementType : ForceCharacteristicMeasurementBaseType
    {
    }
}
