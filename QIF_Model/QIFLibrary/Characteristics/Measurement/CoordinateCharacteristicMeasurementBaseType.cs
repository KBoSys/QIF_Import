/*! \file CoordinateCharacteristicMeasurementBaseType.cs
    \brief 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The CoordinateCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured coordinate characteristic evaluation./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularCoordinateCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCoordinateCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CoordinateCharacteristicMeasurementBaseType<T> : DimensionalCharacteristicMeasurementBaseType<T>
    {
        /// <remarks The TypeOfCoordinates element is the type of coordinate system used for reporting./>
        public PrimitivesPMI.TypeOfCoordinatesType TypeOfCoordinates { get; set; }
    }

    /// <remarks The AngularCoordinateCharacteristicMeasurementType defines the results of a measured angular coordinate characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularCoordinateCharacteristicMeasurementType : CoordinateCharacteristicMeasurementBaseType<MeasuredAngularValueType>
    {
    }

    /// <remarks The LinearCoordinateCharacteristicMeasurementType defines the results of a measured linear coordinate characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinearCoordinateCharacteristicMeasurementType : CoordinateCharacteristicMeasurementBaseType<MeasuredLinearValueType>
    {
    }
}
