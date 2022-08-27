﻿/*! \file ToroidalSegmentFeatureMeasurementType.cs
    \brief defines the toroidal segment feature measurement information for an individual toroidal segment feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks> The ToroidalSegmentFeatureMeasurementType defines the toroidal
    /// segment feature measurement information for an individual toroidal segment feature.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidalSegmentFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks> The optional Location element is the measured center of the toroidal segment.</remarks>
        public MeasuredPointType Location { get; set; }

        /// <remarks> The optional AxisVector element is the measured unit axis vector of the toroidal segment.</remarks>
        public MeasuredUnitVectorType AxisVector { get; set; }

        /// <remarks> The optional MinorDiameter element is the measured minor
        /// diameter of the toroidal segment based on the substitute
        /// feature data fitting algorithm setting.</remarks>
        public MeasuredLinearValueType MinorDiameter { get; set; }

        /// <remarks> The optional MajorDiameter element is the measured major
        /// diameter of the toroidal segment based on the substitute
        /// feature data fitting algorithm setting.</remarks>
        public MeasuredLinearValueType MajorDiameter { get; set; }

        /// <remarks> The optional LatitudeLongitudeSweepMeasurementRange element
        /// gives the range over which the sweep was actually measured
        /// for a toroidal segment with angular sweep in two directions
        /// analogous to terrestrial latitude and longitude.</remarks>
        public OrientedLatitudeLongitudeSweepType LatitudeLongitudeSweepMeasurementRange { get; set; }

        /// <remarks> The optional LatitudeLongitudeSweepFull element gives the
        /// measured extent of a toroidal segment with angular sweep in
        /// two directions analogous to terrestrial latitude and
        /// longitude. This is intended for use when it has been
        /// possible to measure the start and end of the sweep in both directions.</remarks>
        public OrientedLatitudeLongitudeSweepType LatitudeLongitudeSweepFull { get; set; }

        /// <remarks> The optional Form element is the form error (toroidicity) of the toroidal segment from a report or an analysis.</remarks>
        public MeasuredLinearValueType Form { get; set; }
    }
}
