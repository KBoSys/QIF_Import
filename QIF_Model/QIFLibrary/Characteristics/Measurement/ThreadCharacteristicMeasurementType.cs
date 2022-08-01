/*! \file ThreadCharacteristicMeasurementType.cs
    \brief defines the results of a measured thread characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The ThreadCharacteristicMeasurementType defines the results of a
    /// measured thread characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadCharacteristicMeasurementType : CharacteristicMeasurementBaseType
    {
        /// <remarks The optional PitchDiameter element is the measured pitch
        /// diameter of the thread./>
        public MeasuredLinearValueType PitchDiameter { get; set; }

        /// <remarks The optional FunctionalSize element is the measured
        /// functional size of the thread./>
        public MeasuredLinearValueType FunctionalSize { get; set; }
    }
}
