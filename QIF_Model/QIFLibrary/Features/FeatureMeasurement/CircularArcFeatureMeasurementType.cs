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
        /// <remarks The optional Location element is the measured center point of the circular arc./>
        public PrimitivesPMI.MeasuredPointType Location { get; set; }

        /// <remarks The optional Normal element is the measured normal vector of the plane of the circular arc./>
        public PrimitivesPMI.MeasuredUnitVectorType Normal { get; set; }

        /// <remarks The optional Radius element is the measured radius of the
        /// circular arc based on substitute feature data fitting algorithm setting./>
        public MeasuredLinearValueType Radius { get; set; }

        /// <remarks The optional RadiusMin element is the minimum radius of the circular arc from a report or an analysis./>
        public MeasuredLinearValueType RadiusMin { get; set; }

        /// <remarks The optional RadiusMax element is the maximum radius of the circular arc from a report or an analysis./>
        public MeasuredLinearValueType RadiusMax { get; set; }

        /// <remarks The optional SweepMeasurementRange element gives the range
        /// over which the sweep was actually measured in terms of the
        /// start direction and the swept angle.The StartVector of the
        /// sweep must lie in the plane of the circular arc./>
        public SweepType SweepMeasurementRange { get; set; }

        /// <remarks The optional SweepFull element gives the measured start
        /// direction and swept angle of the circular arc.The
        /// StartVector of the sweep must lie in the plane of the
        /// circular arc. This is intended for use when it has been
        /// possible to measure the start and end of the sweep./>
        public SweepType SweepFull { get; set; }

        /// <remarks The optional Form element is the form error (roundness) of
        /// the circular arc from a report or an analysis./>
        public MeasuredLinearValueType Form { get; set; }
    }
}
