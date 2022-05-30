/*! \file FeatureMeasurementsType.cs
    \brief defines a list of feature measurements.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Features.FeatureMeasurement
{
    /// <remarks The FeatureMeasurementsType defines a list of feature measurements./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FeatureMeasurementsType
    {
        /// <remarks Each FeatureMeasurement element gives information about a feature measurement./>
        [System.Xml.Serialization.XmlElementAttribute("CircularArcFeatureMeasurement", typeof(CircularArcFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("CircleFeatureMeasurement", typeof(CircleFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ConeFeatureMeasurement", typeof(ConeFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ConicalSegmentFeatureMeasurement", typeof(ConicalSegmentFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("CylinderFeatureMeasurement", typeof(CylinderFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("CylindricalSegmentFeatureMeasurement", typeof(CylindricalSegmentFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("EdgePointFeatureMeasurement", typeof(EdgePointFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("EllipseFeatureMeasurement", typeof(EllipseFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("EllipticalArcFeatureMeasurement", typeof(EllipticalArcFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ElongatedCylinderFeatureMeasurement", typeof(ElongatedCylinderFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ElongatedCircleFeatureMeasurement", typeof(ElongatedCircleFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ExtrudedCrossSectionFeatureMeasurement", typeof(ExtrudedCrossSectionFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("GroupFeatureMeasurement", typeof(GroupFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("LineFeatureMeasurement", typeof(LineFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("MarkingFeatureMeasurement", typeof(MarkingFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("OppositeParallelLinesFeatureMeasurement", typeof(OppositeParallelLinesFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("OppositeAngledLinesFeatureMeasurement", typeof(OppositeAngledLinesFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("OppositeParallelPlanesFeatureMeasurement", typeof(OppositeParallelPlanesFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("OppositeAngledPlanesFeatureMeasurement", typeof(OppositeAngledPlanesFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCurveFeatureMeasurement", typeof(OtherCurveFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherNonShapeFeatureMeasurement", typeof(OtherNonShapeFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherShapeFeatureMeasurement", typeof(OtherShapeFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherSurfaceFeatureMeasurement", typeof(OtherSurfaceFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("PlaneFeatureMeasurement", typeof(PlaneFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("PointDefinedCurveFeatureMeasurement", typeof(PointDefinedCurveFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("PointDefinedSurfaceFeatureMeasurement", typeof(PointDefinedSurfaceFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("PointFeatureMeasurement", typeof(PointFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SphereFeatureMeasurement", typeof(SphereFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalSegmentFeatureMeasurement", typeof(SphericalSegmentFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("SurfaceOfRevolutionFeatureMeasurement", typeof(SurfaceOfRevolutionFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ThreadedFeatureMeasurement", typeof(ThreadedFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("ToroidalSegmentFeatureMeasurement", typeof(ToroidalSegmentFeatureMeasurementType))]
        [System.Xml.Serialization.XmlElementAttribute("TorusFeatureMeasurement", typeof(TorusFeatureMeasurementType))]
        public FeatureMeasurementBaseType[] FeatureMeasurements { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.FeatureMeasurements.Length;
            set { }
        }
    }
}
