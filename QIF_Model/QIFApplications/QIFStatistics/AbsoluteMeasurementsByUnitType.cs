/*! \file AbsoluteMeasurementsByUnitType.cs
    \brief defines a list of measurement results for various units types.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks The AbsoluteMeasurementsByUnitType defines a list of measurement
    /// results for various units types. This reusable type is used to
    /// define absolute minimums, maximums and differences for various units types./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AbsoluteMeasurementsByUnitType
    {
        /// <remarks/>
        public MeasuredLinearValueType LinearMeasurement { get; set; }

        /// <remarks/>
        public MeasuredAngularValueType AngularMeasurement { get; set; }

        /// <remarks/>
        public MeasuredAreaValueType AreaMeasurement { get; set; }

        /// <remarks/>
        public MeasuredForceValueType ForceMeasurement { get; set; }

        /// <remarks/>
        public MeasuredMassValueType MassMeasurement { get; set; }

        /// <remarks/>
        public MeasuredPressureValueType PressureMeasurement { get; set; }

        /// <remarks/>
        public MeasuredSpeedValueType SpeedMeasurement { get; set; }

        /// <remarks/>
        public MeasuredTemperatureValueType TemperatureMeasurement { get; set; }

        /// <remarks/>
        public MeasuredTimeValueType TimeMeasurement { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitMeasurement")]
        public MeasuredUserDefinedUnitValueType[] UserDefinedUnitMeasurement { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.UserDefinedUnitMeasurement.Length;
            set { }
        }
    }
}
