/*! \file EllipseFeatureMeasurementType.cs
    \brief defines the ellipse feature measurement information for an individual ellipse feature.

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
    /// <remarks The EllipseFeatureMeasurementType defines the ellipse feature measurement information for an individual ellipse feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipseFeatureMeasurementType : CurveFeatureMeasurementBaseType
    {
        /// <remarks The optional Axis element is the measured center point and
        /// measured axis vector along the long axis of the ellipse./>
        public MeasuredAxisType Axis { get; set; }

        /// <remarks The optional Normal element is the measured unit normal
        /// vector of the plane of the ellipse./>
        public MeasuredUnitVectorType Normal { get; set; }

        /// <remarks The optional SweepMeasurementRange element gives the range
        /// over which the sweep was actually measured for a partial
        /// ellipse in terms of the start direction and the swept angle. 
        /// The StartVector of the sweep must lie in the plane of the ellipse./>
        public SweepType SweepMeasurementRange { get; set; }

        /// <remarks The optional SweepFull element gives the measured start
        /// direction and swept angle of a partial ellipse in terms of
        /// the start direction and the swept angle.The StartVector of
        /// the SweepFull must lie in the plane of the ellipse.This is
        /// intended for use when it has been possible to measure the
        /// start and end of the sweep./>
        public SweepType SweepFull { get; set; }

        /// <remarks The optional MajorDiameter element is the measured major diameter of the ellipse./>
        public MeasuredLinearValueType MajorDiameter { get; set; }

        /// <remarks The optional MinorDiameter element is the measured minor diameter of the ellipse./>
        public MeasuredLinearValueType MinorDiameter { get; set; }

        /// <remarks The optional Form element is the form error (ellipticity) of the ellipse from a report or an analysis./>
        public MeasuredLinearValueType Form { get; set; }
    }

    /// <remarks The EllipticalArcFeatureMeasurementType defines the elliptical arc
    /// feature measurement information for an individual elliptical arc feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticalArcFeatureMeasurementType : EllipseFeatureMeasurementType
    {
    }
}