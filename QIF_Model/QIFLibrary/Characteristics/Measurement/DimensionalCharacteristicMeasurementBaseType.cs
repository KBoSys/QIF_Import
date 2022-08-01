/*! \file DimensionalCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured dimensional characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The DimensionalCharacteristicMeasurementBaseType is the abstract
    /// base type that defines the results of a measured dimensional characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class DimensionalCharacteristicMeasurementBaseType<T> : CharacteristicMeasurementBaseType
    {
        /// <remarks The optional Value element is the measured value of the dimensional characteristic./>
        public T Value { get; set; }

        /// <remarks The optional MaxValue element is the maximum of the measured value when reported./>
        public T MaxValue { get; set; }

        /// <remarks The optional MinValue element is the minimum of the measured value when reported./>
        public T MinValue { get; set; }
    }
}
