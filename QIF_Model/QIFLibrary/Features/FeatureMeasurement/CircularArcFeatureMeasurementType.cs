/*! \file CircularArcFeatureMeasurementType.cs
    \brief defines measurement information for an individual circular arc feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The CircularArcFeatureMeasurementType defines measurement information for an individual circular arc feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularArcFeatureMeasurementType : CurveFeatureMeasurementBaseType
    {
        /// <remarks/>
        public MeasuredPointType Location { get; set; }

        /// <remarks/>
        public MeasuredUnitVectorType Normal { get; set; }

        /// <remarks/>
        public MeasuredLinearValueType Radius { get; set; }

        /// <remarks/>
        public MeasuredLinearValueType RadiusMin { get; set; }

        /// <remarks/>
        public MeasuredLinearValueType RadiusMax { get; set; }

        /// <remarks/>
        public SweepType SweepMeasurementRange { get; set; }

        /// <remarks/>
        public SweepType SweepFull { get; set; }

        /// <remarks/>
        public MeasuredLinearValueType Form { get; set; }
    }
}
