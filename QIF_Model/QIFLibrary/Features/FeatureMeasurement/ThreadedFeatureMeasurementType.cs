﻿/*! \file ThreadedFeatureMeasurementType.cs
    \brief defines the threaded feature measurement information for an individual threaded feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The SpecifiedFeatureMeasurementBaseType is the abstract base type
    /// for shape feature measurements for features that are defined
    /// indirectly by a specification rather than by a direct shape description./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadedFeatureMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class SpecifiedFeatureMeasurementBaseType : ShapeFeatureMeasurementBaseType
    {
    }

    /// <remarks The ThreadedFeatureMeasurementType defines the threaded feature measurement information for an individual threaded feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThreadedFeatureMeasurementType : SpecifiedFeatureMeasurementBaseType
    {
        /// <remarks The optional Axis element gives the measured location of the
        /// start point and the measured unit vector of the threaded feature axis./>
        public MeasuredAxisType Axis { get; set; }

        /// <remarks The optional PitchDiameter element is the measured pitch
        /// diameter of the threaded feature based on the substitute
        /// feature data fitting algorithm setting./>
        public MeasuredLinearValueType PitchDiameter { get; set; }

        /// <remarks The optional FunctionalSize element is the measured
        /// functional size of the threaded feature based on the
        /// substitute feature data fitting algorithm setting./>
        public MeasuredLinearValueType FunctionalSize { get; set; }

        /// <remarks The optional Length element is the measured length of the
        /// threaded feature from the starting point in the direction
        /// of the threaded feature axis./>
        public MeasuredLinearValueType Length { get; set; }
    }
}
