/*! \file MassCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured mass characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The MassCharacteristicMeasurementBaseType is the abstract base type
    /// that defines the results of a measured mass characteristic evaluation.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedMassCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class MassCharacteristicMeasurementBaseType : UnitCharacteristicMeasurementBaseType<MeasuredMassValueType>
    {
    }

    /// <remarks> The UserDefinedMassCharacteristicMeasurementType is
    /// a characteristic measurement specified by the user that is measured in mass units.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedMassCharacteristicMeasurementType : MassCharacteristicMeasurementBaseType
    {
    }
}
