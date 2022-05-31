/*! \file DimensionalCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured geometric characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The GeometricCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured geometric
    /// characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class GeometricCharacteristicMeasurementBaseType : UnitCharacteristicMeasurementBaseType<MeasuredLinearValueType>
    {
    }
}
