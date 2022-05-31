/*! \file PressureCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured pressure characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The PressureCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured pressure characteristic evaluation./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedPressureCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class PressureCharacteristicMeasurementBaseType : UnitCharacteristicMeasurementBaseType<MeasuredPressureValueType>
    {
    }

    /// <remarks The UserDefinedPressureCharacteristicMeasurementType is
    /// a characteristic measurement specified by the user that is measured in pressure units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedPressureCharacteristicMeasurementType : PressureCharacteristicMeasurementBaseType
    {
    }
}
