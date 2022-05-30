/*! \file MeasurePointNominalType.cs
    \brief defines a nominal measure point.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The MeasurePointNominalType defines a nominal measure point. In a
    /// MeasurePointNominalType, the inherited Point element is the
    /// location of a point at which a measurement is to be taken, and the
    /// inherited Normal element is a vector pointing opposite an intended
    /// approach direction for measurement./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MeasurePointNominalType : PointWithNormalBaseType
    {
        /// <remarks The optional MeasurementDeviceId element is the QIF id of
        /// the measurement device to be used to measure the point./>
        public QIFReferenceType MeasurementDeviceId { get; set; }

        /// <remarks The optional SensorId element is the QIF id of the sensor (e.g., tactile probe) to be used to measure the point./>
        public QIFReferenceType SensorId { get; set; }

        /// <remarks The optional TipId element is the QIF id of the tip of a
        /// complex tactile probe to be used to measure the point.
        /// This must be the id of a ProbeTipType object./>
        public QIFReferenceType TipId { get; set; }
    }
}
