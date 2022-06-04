/*! \file SphereFeatureMeasurementType.cs
    \brief defines the sphere feature measurement information for an individual sphere feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The SphereFeatureMeasurementType defines the sphere feature measurement information for an individual sphere feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphereFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks The optional Location element is the measured center of the sphere./>
        public MeasuredPointType Location { get; set; }

        /// <remarks The optional Diameter element is the measured diameter of
        /// the sphere based on the substitute feature data fitting algorithm setting./>
        public MeasuredLinearValueType Diameter { get; set; }

        /// <remarks The optional DiameterMin element is the minimum diameter of
        /// the sphere from a report or an analysis./>
        public MeasuredLinearValueType DiameterMin { get; set; }

        /// <remarks The optional DiameterMax element is the maximum diameter of
        /// the sphere from a report or an analysis./>
        public MeasuredLinearValueType DiameterMax { get; set; }

        /// <remarks The optional LatitudeLongitudeSweepMeasurementRange element
        /// gives the range over which the sweep was actually measured
        /// for a partial sphere with angular sweep in two directions
        /// analogous to terrestrial latitude and longitude./>
        public OrientedLatitudeLongitudeSweepType LatitudeLongitudeSweepMeasurementRange { get; set; }

        /// <remarks The optional LatitudeLongitudeSweepFull element gives the
        /// measured extent of a partial sphere with angular sweep in
        /// two directions analogous to terrestrial latitude and
        /// longitude. This is intended for use when it has been
        /// possible to measure the start and end of the sweep in both directions./>
        public OrientedLatitudeLongitudeSweepType LatitudeLongitudeSweepFull { get; set; }

        /// <remarks The optional Form element is the form error (sphericity) of
        /// the sphere from a report or an analysis./>
        public MeasuredLinearValueType Form { get; set; }
    }

    /// <remarks The SphericalSegmentFeatureMeasurementType defines the spherical
    /// segment feature measurement information for an individual spherical segment feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalSegmentFeatureMeasurementType : SphereFeatureMeasurementType
    {
    }
}