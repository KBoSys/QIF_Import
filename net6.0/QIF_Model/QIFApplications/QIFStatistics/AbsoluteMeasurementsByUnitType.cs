/*! \file AbsoluteMeasurementsByUnitType.cs
    \brief defines a list of measurement results for various units types.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks> The AbsoluteMeasurementsByUnitType defines a list of measurement
    /// results for various units types. This reusable type is used to
    /// define absolute minimums, maximums and differences for various units types.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AbsoluteMeasurementsByUnitType : ArrayBaseType<MeasuredUserDefinedUnitValueType>
    {
        /// <remarks></remarks>
        public MeasuredLinearValueType? LinearMeasurement { get; set; }

        /// <remarks></remarks>
        public MeasuredAngularValueType? AngularMeasurement { get; set; }

        /// <remarks></remarks>
        public MeasuredAreaValueType? AreaMeasurement { get; set; }

        /// <remarks></remarks>
        public MeasuredForceValueType? ForceMeasurement { get; set; }

        /// <remarks></remarks>
        public MeasuredMassValueType? MassMeasurement { get; set; }

        /// <remarks></remarks>
        public MeasuredPressureValueType? PressureMeasurement { get; set; }

        /// <remarks></remarks>
        public MeasuredSpeedValueType? SpeedMeasurement { get; set; }

        /// <remarks></remarks>
        public MeasuredTemperatureValueType? TemperatureMeasurement { get; set; }

        /// <remarks></remarks>
        public MeasuredTimeValueType? TimeMeasurement { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitMeasurement")]
        public MeasuredUserDefinedUnitValueType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }
}
