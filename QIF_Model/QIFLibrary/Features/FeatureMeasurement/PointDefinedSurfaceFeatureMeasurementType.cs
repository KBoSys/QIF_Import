/*! \file PointDefinedSurfaceFeatureMeasurementType.cs
    \brief defines the point-defined surface feature measurement information for an individual point-defined surface feature.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The PointDefinedSurfaceFeatureMeasurementType defines the
    /// point-defined surface feature measurement information for an individual point-defined surface feature./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDefinedSurfaceFeatureMeasurementType : SurfaceFeatureMeasurementBaseType
    {
        /// <remarks The optional DefiningPoints element gives a list of
        /// measured points defining the measured point-surface.The
        /// measured point-defined surface passes through these points./>
        public DefiningPointsMeasurementType DefiningPoints { get; set; }

        /// <remarks The optional Form element is the form error of the
        /// point-defined surface feature from a report or an analysis./>
        public MeasuredLinearValueType Form { get; set; }
    }
}
